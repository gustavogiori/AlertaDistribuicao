using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Alerta_distribuição.Emails
{
    public class clsEmailsManuais : clsEmails
    {
        public clsEmailsManuais()
        {
            base.preencherVariaveis();
        }

        public override void enviarEmail(int quantidade,string destino,string conteudo)
        {
        
            try
            {
             
                string email="";
                string SmtpServer = servidor;
                int SmtpPort = Convert.ToInt32(base.porta);
                string FromAddress = base.usuario;
                string Password = base.senha;
                if (conteudo == string.Empty)
                {
                    email= string.Format("Você recebeu {0} chamados do portal , favor verificar!", quantidade);
                }
                else 
                {
                    email = conteudo;
                }
                var client = new SmtpClient(SmtpServer, SmtpPort)
                {
                    Credentials = new NetworkCredential(FromAddress, Password),
                    EnableSsl = true
                };

                client.Send(FromAddress, destino, "Ditribuição de chamado", email);


            }

              // This catches the exceptions, if any.
            catch (Exception ex)
            {
                // Show a message, explaining the problem.
                throw new Exception(ex.Message);

            }
        }
    }
}

