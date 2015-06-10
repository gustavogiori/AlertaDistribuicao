using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alerta_distribuição
{
    public partial class frmHome : Form
    {
        private FileSystemWatcher _watcher;
        public frmHome()
        {
            InitializeComponent();
            _watcher = new FileSystemWatcher();
            _watcher.SynchronizingObject = this;

            _watcher.Changed += new FileSystemEventHandler(LogFileSystemChanges);
            //          _watcher.Created += new FileSystemEventHandler(LogFileSystemChanges);
            //            _watcher.Deleted += new FileSystemEventHandler(LogFileSystemChanges);
            //            _watcher.Renamed += new RenamedEventHandler(LogFileSystemRenaming);
            // _watcher.Error += new ErrorEventHandler(LogBufferError);
        }

        void LogBufferError(object sender, ErrorEventArgs e)
        {

        }




        void LogFileSystemRenaming(object sender, RenamedEventArgs e)
        {

        }



        /// <summary>
        /// Process creations, modifications and deletions.
        /// </summary>
        /// 
        int cont = 0;
        void LogFileSystemChanges(object sender, FileSystemEventArgs e)
        {
            string caminhoBanco = Configuração.clsConfiguracao.caminho;

            if (caminhoBanco == e.FullPath && e.ChangeType.ToString() == "Changed")
            {
                /*
                 Foi preciso criar a logica do if e else do contador pois o metodo estava vendo que o arquivo havia sido alterado duas vezes disparando o evento
                 duas vezes fazendo assim de maneira errada , portanto foi preciso haver alteração para enviar somente uma vez o e-mail.
                 */
                cont++;
                if (cont >= 2)
                {
                    cont = 0;
                }
                else
                {
                    enviarEmail();
                    cont++;
                }
            }
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            Configuração.frmConfiguracao confi = new Configuração.frmConfiguracao();
            confi.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja encerrar a aplicação ?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            enviarEmail();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Configuração.clsConfiguracao conf = new Configuração.clsConfiguracao();
            string arquivoCompleto = Configuração.clsConfiguracao.caminho;
            string caminho = Path.GetDirectoryName(arquivoCompleto);
            string nomeArquivo = Path.GetFileName(arquivoCompleto);
            _watcher.Path = caminho;
            _watcher.Filter = string.Format("*{0}*", nomeArquivo);


            // Notification filters
            NotifyFilters notificationFilters = new NotifyFilters();
            notificationFilters = notificationFilters | NotifyFilters.Attributes;
            notificationFilters = notificationFilters | NotifyFilters.CreationTime;
            notificationFilters = notificationFilters | NotifyFilters.DirectoryName;
            notificationFilters = notificationFilters | NotifyFilters.FileName;
            notificationFilters = notificationFilters | NotifyFilters.LastAccess;
            notificationFilters = notificationFilters | NotifyFilters.LastWrite;
            notificationFilters = notificationFilters | NotifyFilters.Security;
            notificationFilters = notificationFilters | NotifyFilters.Size;
            _watcher.NotifyFilter = notificationFilters;

            _watcher.EnableRaisingEvents = true;
            Configuração.clsConfiguracao d = new Configuração.clsConfiguracao();

            string dataBanco = Convert.ToDateTime(d.data).ToShortDateString();
            string dataAtual = DateTime.Now.ToShortDateString();
            if (dataBanco != dataAtual)
            {

                d.iniciarDia();
            }

            d.atualizarDataBanco();

            
        }
        public void enviarEmail()
        {
            Configuração.clsConfiguracao conf = new Configuração.clsConfiguracao();
            Arquivos.clsManipulacaoArquivo arq = new Arquivos.clsManipulacaoArquivo();
            Analista.clsAnalista analista = new Analista.clsAnalista();


            progressBar1.Value = 1;
            int chamadosDistribuidosAtualizar = 0;
            progressBar1.Value = 2;
            List<string> emailEnviar = arq.retornarEmail();

            int MaximunProgressBar = emailEnviar.Count - 1;

            progressBar1.Maximum = MaximunProgressBar;

            int total = 0;

            for (int i = 0; i < emailEnviar.Count; i++)
            {

                string quantidade = Convert.ToString(arq.retornarQuantidadeChamadosDistruidos(emailEnviar[i], ref chamadosDistribuidosAtualizar));

                if (Convert.ToInt32(quantidade) > 0)
                {

                    Emails.clsEmailsManuais enviar = new Emails.clsEmailsManuais();
                    enviar.enviarEmail(Convert.ToInt32(quantidade), emailEnviar[i], "");
                    progressBar1.Value = i;
                    total = total + 1;
                    label1.Text = total.ToString() + " - Emails enviados!";
                    analista.atualizarDistribuicao(emailEnviar[i], chamadosDistribuidosAtualizar);
                }

            }
            if (total == 0)
            {
                progressBar1.Value = emailEnviar.Count - 1;
                MessageBox.Show("Não houve nenhuma atualização portanto o e-mail não será enviado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Value = emailEnviar.Count - 1;
                MessageBox.Show("E-mails enviados com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;

            }

        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            Configuração.clsConfiguracao c = new Configuração.clsConfiguracao();

            DialogResult resultado = MessageBox.Show("Realmente deseja zerar os dados da distribuição ? \n Isto fará com que todos analistas tenha seus chamados zerados .\nEste proceso é irreversivel.", "Atenção !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                c.iniciarDia();
                MessageBox.Show("Distribuição zerada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Processo cancelado pelo usuário !", "Cancelamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Analista.frmCadastroAnalista c = new Analista.frmCadastroAnalista();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emails.frmEmailRetificao r = new Emails.frmEmailRetificao();
            r.ShowDialog();
        }

        private void frmHome_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) { this.Hide(); notifyIcon1.Visible = true; }


        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
                
            
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
