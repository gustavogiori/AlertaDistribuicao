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
    public partial class frmCadastroAnalista : Form
    {
        public frmCadastroAnalista()
        {
            InitializeComponent();
        }

        public void listarGrid()
        {
            Analista.clsAnalista ana = new clsAnalista();

            dataGridView1.DataSource = ana.retornarAnalistas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmNovoAnalista n = new frmNovoAnalista();
            n.ShowDialog();
            listarGrid();
        }

        private void frmCadastroAnalista_Load(object sender, EventArgs e)
        {
            listarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string ids = "";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {

                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True")
                    {
                        ids += dataGridView1.Rows[i].Cells[1].Value.ToString() + ";";
                    }
                    else
                    {
                        //Desmarcado
                    }
                }
            }
            if (ids.Length > 0)
            {
                DialogResult resultado = MessageBox.Show("Realmente deseja deletar os registros selecionados ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Analista.clsAnalista a = new clsAnalista();
                    a.deletar(ids.Remove(ids.Length-1));


                    MessageBox.Show("Deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarGrid();
                }
                else
                {
                    MessageBox.Show("Processo cancelado pelo usuário !", "Cancelamento!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar pelo menos 1 registro !", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
