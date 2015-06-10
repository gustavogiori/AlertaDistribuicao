using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alerta_distribuição.Emails
{
    public partial class frmEmailRetificao : Form
    {
        public frmEmailRetificao()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {


            try { 
            Configuração.clsConfiguracao conf = new Configuração.clsConfiguracao();
            Arquivos.clsManipulacaoArquivo arq = new Arquivos.clsManipulacaoArquivo();
            Analista.clsAnalista analista = new Analista.clsAnalista();

            List<string> emailEnviar = arq.retornarEmail();
            for (int i = 0; i < emailEnviar.Count; i++)
            {

                Emails.clsEmailsManuais enviar = new Emails.clsEmailsManuais();
                enviar.enviarEmail(0, emailEnviar[i],txtEmailRetificacao.Text);

            }
            MessageBox.Show("E-mail enviado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
            MessageBox.Show("Erro ocorrido :" + ex.Message + "  "  +  ex.StackTrace);
            }
        }
    }
}
