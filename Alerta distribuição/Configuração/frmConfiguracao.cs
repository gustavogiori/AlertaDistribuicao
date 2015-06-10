using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alerta_distribuição.Configuração
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        public void teste(string texto, TextBox textBox)
        {
            string teste = textBox.Name;
            MessageBox.Show(teste);
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            preencherTextbox();
            //  btnOK.Enabled = false;
        }

        private void validarCamposNull(string [] valorTextBox, TextBox[] textBox)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        public void preencherTextbox()
        {
            System.Data.SqlClient.SqlDataReader retorno;

            clsConfiguracao conf = new clsConfiguracao();

            retorno = conf.retornarConfiguracoes();

            if (retorno.Read())
            {

                txtServidor.Text = retorno["SERVIDOR"].ToString();
                txtSenha.Text = clsCriptografia.Descriptografar(retorno["SENHA"].ToString());
                txtEmissor.Text = retorno["EMISSOR"].ToString();
                txtPorta.Text = retorno["PORTA"].ToString();
                txtUsuario.Text = retorno["USUARIO"].ToString();
                txtCaminho.Text = retorno["CAMINHO"].ToString();
            }

        }

        public bool verificarNullo()
        {
            bool validou = false;
            int cont = 0 ;
            foreach (Control ctl in this.Controls)
            {
                //verifica os controles adicionados em tela
                if (ctl is TextBox)
                {
                    //se TextBox vazio
                    if ((ctl as TextBox).Text == "")
                    {
                        //verifica se é obrigatório
                        if (obrigatorio1.GetObrigatorio((ctl as TextBox)))
                            errorProvider1.SetError((ctl as TextBox), "Preenchimento do campo obrigatório!");
                        cont++;
                        
                    }
                    else
                    {
                        errorProvider1.SetError((ctl as TextBox), "");
                       
                    }
                }
            }
            if (cont > 0)
            {
                validou = false;
            }
            else
            {
                validou = true;
            }
            return validou;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificarNullo() == false)
            {

            }
            else
            {
                try
                {
                    DateTime data = DateTime.Now;

                    clsConfiguracao conf = new clsConfiguracao(txtServidor.Text, txtPorta.Text, txtUsuario.Text, txtSenha.Text, txtEmissor.Text, data.ToShortDateString(), txtCaminho.Text);
                    conf.alterarConfiguracao();
                    MessageBox.Show("Dados alterados com sucesso !", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ocorrido : " + ex.Message + " em : " + ex.StackTrace);
                }
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.DefaultExt = ".xlsx";
            openFileDialog1.Filter = "Arquivo Excel|*.xlsx|Todos arquivos |*.*";
            openFileDialog1.FileName = "planilha";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "planilha")
            {
                MessageBox.Show("Processo cancelado pelo usuario!");
                openFileDialog1.FileName = "";
            }
            else
            {
                txtCaminho.Text = openFileDialog1.FileName;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
   
            this.Close();
        }

        private void btnCaminho_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.DefaultExt = ".xlsx";
            openFileDialog1.Filter = "Arquivo Excel|*.xlsx|Todos arquivos |*.*";
            openFileDialog1.FileName = "planilha";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "planilha")
            {
                MessageBox.Show("Processo cancelado pelo usuario!");
                openFileDialog1.FileName = "";
            }
            else
            {
                txtCaminho.Text = openFileDialog1.FileName;
            }
        }
    }
}
