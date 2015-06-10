using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace Alerta_distribuição
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            this.btnOK.Enabled = false;
            txtServidor.Text= ConfigurationManager.AppSettings["Servidor"];
            txtBase.Text = ConfigurationManager.AppSettings["Base"];
            btnConectar_Click(e, e);
            //btnOK_Click(e,e);
            frmHome inicial = new frmHome();
            this.Hide();
            this.Close();
            inicial.ShowDialog();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConexaoBanco.ConexaoSQL.BaseDados = txtBase.Text;
            ConexaoBanco.ConexaoSQL.NomeServidor = txtServidor.Text;

            if (txtBase.Text == "" || txtServidor.Text == "")
            {
                if (txtBase.Text == string.Empty && txtServidor.Text == string.Empty)
                {
                    erroServidor.SetError(txtServidor, "Favor preencher o campo Servidor!");
                    erroBase.SetError(txtBase, "Favor preencher o campo Base!");
                }

                else if (txtBase.Text == string.Empty)
                {
                    erroBase.SetError(txtBase, "Favor preencher o campo Base!");
                    erroServidor.Clear();
                }

                else if (txtServidor.Text == string.Empty)
                {
                    erroServidor.SetError(txtServidor, "Favor preencher o campo Servidor!");
                    erroBase.Clear();
                }
            }

            else
            {
                try
                {
                    ConexaoBanco.ConexaoSQL.abrirConexao();
                    MessageBox.Show("Conectado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnConectar.Enabled = false;
                    btnOK.Enabled = true;
                    erroBase.Clear();
                    erroServidor.Clear();
                   
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings.Remove("Servidor");
                    config.AppSettings.Settings.Remove("Base");
                    config.AppSettings.Settings.Add("Servidor", txtServidor.Text);
                    config.AppSettings.Settings.Add("Base", txtBase.Text);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }

                catch
                {

                    MessageBox.Show("Erro ao conectar! \n Favor  verificar os dados informados e tentar novamente.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    erroBase.Clear();
                    erroServidor.Clear();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmHome inicial = new frmHome();
            this.Hide();
            inicial.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

       
    }
}
