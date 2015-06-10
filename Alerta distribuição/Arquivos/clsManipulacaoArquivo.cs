using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Alerta_distribuição.Arquivos
{
    public class clsManipulacaoArquivo
    {
        
        
        OleDbConnection connect = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES';", Configuração.clsConfiguracao.caminho));
        string comandoSql = "Select * from [Plan1$]";


        public int retornarQuantidadeChamadosDistruidos(string email, ref int chamadosDistribuidos)
        {
            int chamados = 0;
            string nome = "";
            int ultimosDistribuidos;
            string consultaNome = string.Format(@"select nome from analista where email='{0}' ", email);
            string consulta = string.Format(@"
                            select distribuidos from analista where email='{0}'
                            ", email);
            ultimosDistribuidos = Convert.ToInt32(ConexaoBanco.ConexaoSQL.RetornarUmRegistro(consulta));
            nome = Convert.ToString(ConexaoBanco.ConexaoSQL.RetornarUmRegistro(consultaNome));
            OleDbCommand comando = new OleDbCommand(comandoSql, connect);

            try
            {
                connect.Open();
                OleDbDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {

                    if (nome == rd["Rótulos de Linha"].ToString())
                    {
                        if (rd["DISTRIBUIDOS"].ToString() != string.Empty)
                        {
                            chamadosDistribuidos = Convert.ToInt32(rd["DISTRIBUIDOS"]);
                            chamados = chamadosDistribuidos - ultimosDistribuidos;
                        }
                        else
                        {
                            chamados = 0;
                        }
                    }
                }
                return chamados;

            }
            catch (Exception ex)
            {
                
                return 0;
            }
            finally
            {
                connect.Close();
            }
        }

        public List<string> retornarEmail()
        {
            List<string> Emails = new List<string>();
            DataSet resultado = retornarNomes();
            DataSet resultadoBanco = ConexaoBanco.ConexaoSQL.retornarRegistrosDataSet("SELECT NOME FROM ANALISTA");
            int NomesArquivo = resultado.Tables[0].Rows.Count;
            string email = "";
            int count = resultadoBanco.Tables[0].Rows.Count;
            
            for (int i = 0; i < NomesArquivo; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    string NomeRetornardosExcel = resultado.Tables[0].Rows[i]["Rótulos de Linha"].ToString();
                    string NomesRetornadosBanco = resultadoBanco.Tables[0].Rows[j]["NOME"].ToString();
                    if (NomesRetornadosBanco == NomeRetornardosExcel )
                    {
                    email=    ConexaoBanco.ConexaoSQL.RetornarUmRegistro(string.Format("Select email from analista where nome='{0}'", NomesRetornadosBanco));
                    Emails.Add(email);
                    
                    }
                }
               
            }
            return Emails;
        }

        public DataSet retornarNomes()
        {
            try
            {
                connect.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter data = new OleDbDataAdapter(comandoSql, connect);

                data.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                
                throw new System.ArgumentException(ex.Message + "   " + ex.StackTrace);
            }

            finally
            {
                connect.Close();
            }
        }
    }
}
