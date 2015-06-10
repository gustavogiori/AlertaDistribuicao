using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisa1.Pesquisar();
        }

        private void pesquisa1_CloseSearch(object sender, DialogResult drRetorno)
        {
            if (drRetorno == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = "Código: " + pesquisa1.ToValue() + " - Descrição: " + pesquisa1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisa2.Pesquisar();
        }

        private void pesquisa2_CloseSearch(object sender, DialogResult drRetorno)
        {
            if (drRetorno == System.Windows.Forms.DialogResult.OK)
                textBox2.Text = "Código: " + pesquisa2.ToValue() + " - Descrição: " + pesquisa2.ToString();
        }
    }
}
