using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Alerta_distribuição.Emails
{
    public class clsEmailsAutomaticos : clsEmails
    {
        public override void enviarEmail(int quantidade, string destino,string conteudo)
        {

            try
            {

                string SmtpServer = servidor;
                int SmtpPort = Convert.ToInt32(base.porta);
                string FromAddress = base.usuario;
                string Password = base.senha;
                string email = string.Format("Você recebeu {0} chamados do portal , favor verificar!", quantidade);

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

