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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                            errorProvider1.SetError((ctl as TextBox), "Campo obrigatório!");
                    }
                    else
                        errorProvider1.SetError((ctl as TextBox), "");
                }

                //verifica se é ComboBox
                if (ctl is ComboBox)
                {
                    //se não foi escolhido item
                    if ((ctl as ComboBox).SelectedIndex == -1)
                    {
                        //verifica se é obrigatório
                        if (obrigatorio1.GetObrigatorio((ctl as ComboBox)))
                            errorProvider1.SetError((ctl as ComboBox), "Selecione pelo menos um item");
                    }
                    else
                        errorProvider1.SetError((ctl as ComboBox), "");
                }

                //verifica se é ListBox
                if (ctl is ListBox)
                {
                    //se não foi escolhido item
                    if ((ctl as ListBox).SelectedIndex == -1)
                    {
                        //verifica se é obrigatório
                        if (obrigatorio1.GetObrigatorio((ctl as ListBox)))
                            errorProvider1.SetError((ctl as ListBox), "Selecione pelo menos um item");
                    }
                    else
                        errorProvider1.SetError((ctl as ListBox), "");
                }

                //verifica se é RichTextBox
                if (ctl is RichTextBox)
                {
                    //se não foi escolhido item
                    if ((ctl as RichTextBox).Text == "")
                    {
                        //verifica se é obrigatório
                        if (obrigatorio1.GetObrigatorio((ctl as RichTextBox)))
                            errorProvider1.SetError((ctl as RichTextBox), "Campo obrigatório!");
                    }
                    else
                        errorProvider1.SetError((ctl as RichTextBox), "");
                }
            }
        }
    }
}
