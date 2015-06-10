using Alerta_distribuição.Configuração;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alerta_distribuição.Emails
{
   public abstract class  clsEmails
    {

       protected string servidor { get; set; }
       protected string porta { get; set; }
       protected string usuario { get; set; }
       protected string senha { get; set; }
       protected string emissor { get; set; }
       protected string destinatario {get;set;}

       public clsEmails()
       {
          // preencherVariaveis();
       }
        public abstract void enviarEmail(int quantidade, string destino,string conteudo);

        public void preencherVariaveis()
        {

            Configuração.clsConfiguracao confi = new Configuração.clsConfiguracao();
            SqlDataReader retorno = confi.retornarDadosConfiguracao();

            if (retorno.Read())
            {
               
                    servidor = retorno["SERVIDOR"].ToString();
                    porta = retorno["PORTA"].ToString();
                    usuario = retorno["USUARIO"].ToString();
                    senha = clsCriptografia.Descriptografar(retorno["SENHA"].ToString());
                    Configuração.clsConfiguracao.caminho = retorno["CAMINHO"].ToString();
                    emissor = retorno["EMISSOR"].ToString();
                   
                
            }

        }
     
    }
}
