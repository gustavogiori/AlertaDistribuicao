using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Alerta_distribuição.Analista
{
    public class clsAnalista
    {

        string nome { get; set; }
        string email { get; set; }
        string chamados { get; set; }
        string distribuidos { get; set; }


        public void deletar(string ids)
        {

            try
            {
                string[] codigoSeparado = ids.Split(';');
                string consulta = "delete ANALISTA where ";
                string teste = "";

                for (int i = 0; i < codigoSeparado.Length; i++)
                {

                    teste += "id = " + codigoSeparado[i] + "  or ";
                }
                if (teste.Length > 0)
                {

                    ConexaoBanco.ConexaoSQL.deletar(consulta + teste.Remove(teste.Length - 3));
                }
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException("Erro ocorrido" + ex.Message);
            }
        }

        public object retornarAnalistas()
        {
            var retorno = ConexaoBanco.ConexaoSQL.ListarGrid("SELECT ID AS 'CODIGO' , NOME , EMAIL FROM ANALISTA");

            return retorno;
        }

        public void cadastrarAnalista(string nome, string email)
        {
            DateTime data = DateTime.Now;
            ConexaoBanco.ConexaoSQL.insert(string.Format("INSERT INTO ANALISTA VALUES ('{0}','{1}',{2},{3},{4},{5})", nome, email, 0, 0, data.Month, data.Year));
        }

        public void atualizarDistribuicao(string email, int distribuidos)
        {
            try
            {
                ConexaoBanco.ConexaoSQL.Update(string.Format("update ANALISTA set CHAMADOS= (select CHAMADOS from ANALISTA where EMAIL='{0}')+{1}, distribuidos={1} where email='{0}'", email, distribuidos));
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + "  " + ex.StackTrace);
            }
        }


    }

}
