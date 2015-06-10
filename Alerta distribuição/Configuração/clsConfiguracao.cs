using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alerta_distribuição.Configuração
{
    public class clsConfiguracao 
    {
        private string servidor { get; set; }
        private string porta { get; set; }
        private string usuario { get; set; }
        private string senha { get; set; }
        private string emissor { get; set; }
        public string data { get; set; }
        public static string caminho { get; set; }

        public clsConfiguracao()
        {
            preencherDadosVariaveis();
        }
        
        public clsConfiguracao(string servidor, string porta, string usuario, string senha, string emissor, string data, string caminho)
        {
            this.servidor = servidor;
            this.porta = porta;
            this.usuario = usuario;
            this.senha = senha;
            this.emissor = emissor;
            this.data = data;
            Configuração.clsConfiguracao.caminho = caminho;
        }


        public void atualizarDataBanco()
        {
            try
            {
                ConexaoBanco.ConexaoSQL.Update(("UPDATE CONFIGURACAO SET DATA=GETDATE()"));//Guardar no banco a data de acesso ao sistema.
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + "  " + ex.StackTrace);
            }
        }

        public SqlDataReader retornarDadosConfiguracao()
        {

            try
            {
                SqlDataReader retorno = ConexaoBanco.ConexaoSQL.RetornarRegistros("SELECT * FROM CONFIGURACAO");
                return retorno;
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException("Erro ocorrido "+ex.Message + " Em:" +ex.StackTrace);
            }
            
        }

        public void guardarDataAcesso()
        {
            try
            {
                ConexaoBanco.ConexaoSQL.Update(("UPDATE CONFIGURACAO SET DATA=GETDATE()"));//Guardar no banco a data de acesso ao sistema.
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + "   " + ex.StackTrace);
            }
            }
        public void alterarConfiguracao()
        {
            DateTime data = DateTime.Now;

            string alterar = string.Format("update configuracao set servidor='{0}',porta ='{1}',usuario='{2}',senha='{3}',emissor='{4}',data=GETDATE(),caminho='{5}'", this.servidor, this.porta, this.usuario, retornarSenhaCriptografada( this.senha), this.emissor, Configuração.clsConfiguracao.caminho);
            ConexaoBanco.ConexaoSQL.insert(alterar);
        }

        public string retornarSenhaCriptografada(string senha)

       {
           try
           {
               

               string senhaCriptografada = clsCriptografia.Criptografar(senha);

               return senhaCriptografada;
           }

           catch (Exception ex)
           {
               throw new System.ArgumentException(ex.Message + ex.StackTrace, ex.InnerException);
              
           }

       }

        public void iniciarDia()
        {
            try
            {
                string consulta = "UPDATE ANALISTA SET DISTRIBUIDOS=0,CHAMADOS=0 ";

                ConexaoBanco.ConexaoSQL.Update(consulta);
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message, ex.StackTrace);
            }
        }

        public SqlDataReader retornarConfiguracoes()
        {

            var configuracao = ConexaoBanco.ConexaoSQL.RetornarRegistros("Select * from CONFIGURACAO");

            return configuracao;
        }

        public void preencherDadosVariaveis ()
        {
            SqlDataReader retorno = retornarConfiguracoes();

            if (retorno.Read())
            {
                servidor = retorno["SERVIDOR"].ToString();
                porta = retorno["PORTA"].ToString();
                usuario = retorno["USUARIO"].ToString();
                senha = clsCriptografia.Descriptografar(retorno["SENHA"].ToString());
                Configuração.clsConfiguracao.caminho = retorno["CAMINHO"].ToString();
                emissor = retorno["EMISSOR"].ToString();
                data = retorno["DATA"].ToString();
            }
        }
    }
}
