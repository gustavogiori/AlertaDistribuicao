using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alerta_distribuição.Analista
{
    public partial class frmNovoAnalista : Form
    {
        public frmNovoAnalista()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Analista.clsAnalista a = new Analista.clsAnalista();
                a.cadastrarAnalista(txtNome.Text, txtEmail.Text);
   
                MessageBox.Show("Incluido com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorrido " + ex.Message + ex.InnerException, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
