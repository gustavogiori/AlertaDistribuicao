namespace Alerta_distribuição.Configuração
{
    partial class frmConfiguracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.erroServidor = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroPorta = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroArquivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.obrigatorio1 = new TheClubExtendedComponent.Obrigatorio(this.components);
            this.btnCaminho = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmissor = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erroServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(444, 243);
            this.btnOK.Name = "btnOK";
            this.obrigatorio1.SetObrigatorio(this.btnOK, false);
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 42;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(534, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.obrigatorio1.SetObrigatorio(this.btnSalvar, false);
            this.btnSalvar.Size = new System.Drawing.Size(75, 27);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(342, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.obrigatorio1.SetObrigatorio(this.btnCancelar, false);
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erroServidor
            // 
            this.erroServidor.ContainerControl = this;
            // 
            // erroUsuario
            // 
            this.erroUsuario.ContainerControl = this;
            // 
            // erroEmail
            // 
            this.erroEmail.ContainerControl = this;
            // 
            // erroPorta
            // 
            this.erroPorta.ContainerControl = this;
            // 
            // erroSenha
            // 
            this.erroSenha.ContainerControl = this;
            // 
            // erroArquivo
            // 
            this.erroArquivo.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCaminho
            // 
            this.btnCaminho.Location = new System.Drawing.Point(556, 134);
            this.btnCaminho.Name = "btnCaminho";
            this.obrigatorio1.SetObrigatorio(this.btnCaminho, false);
            this.btnCaminho.Size = new System.Drawing.Size(31, 23);
            this.btnCaminho.TabIndex = 60;
            this.btnCaminho.Text = "...";
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 139);
            this.label4.Name = "label4";
            this.obrigatorio1.SetObrigatorio(this.label4, false);
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Arquivo:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(383, 134);
            this.txtCaminho.Name = "txtCaminho";
            this.obrigatorio1.SetObrigatorio(this.txtCaminho, true);
            this.txtCaminho.Size = new System.Drawing.Size(167, 20);
            this.txtCaminho.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 142);
            this.label3.Name = "label3";
            this.obrigatorio1.SetObrigatorio(this.label3, false);
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "E-mail Emissor";
            // 
            // txtEmissor
            // 
            this.txtEmissor.Location = new System.Drawing.Point(141, 139);
            this.txtEmissor.Name = "txtEmissor";
            this.obrigatorio1.SetObrigatorio(this.txtEmissor, true);
            this.txtEmissor.Size = new System.Drawing.Size(100, 20);
            this.txtEmissor.TabIndex = 56;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(141, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.obrigatorio1.SetObrigatorio(this.txtUsuario, true);
            this.txtUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtUsuario.TabIndex = 55;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(383, 98);
            this.txtSenha.Name = "txtSenha";
            this.obrigatorio1.SetObrigatorio(this.txtSenha, true);
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(92, 20);
            this.txtSenha.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 105);
            this.label8.Name = "label8";
            this.obrigatorio1.SetObrigatorio(this.label8, false);
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Senha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 97);
            this.label7.Name = "label7";
            this.obrigatorio1.SetObrigatorio(this.label7, false);
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Usuário:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(383, 52);
            this.txtPorta.Name = "txtPorta";
            this.obrigatorio1.SetObrigatorio(this.txtPorta, true);
            this.txtPorta.Size = new System.Drawing.Size(76, 20);
            this.txtPorta.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 55);
            this.label2.Name = "label2";
            this.obrigatorio1.SetObrigatorio(this.label2, false);
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Porta:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(141, 52);
            this.txtServidor.Name = "txtServidor";
            this.obrigatorio1.SetObrigatorio(this.txtServidor, true);
            this.txtServidor.Size = new System.Drawing.Size(150, 20);
            this.txtServidor.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 55);
            this.label1.Name = "label1";
            this.obrigatorio1.SetObrigatorio(this.label1, false);
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Servidor:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 280);
            this.Controls.Add(this.btnCaminho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmissor);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnOK);
            this.Name = "frmConfiguracao";
            this.obrigatorio1.SetObrigatorio(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider erroServidor;
        private System.Windows.Forms.ErrorProvider erroUsuario;
        private System.Windows.Forms.ErrorProvider erroEmail;
        private System.Windows.Forms.ErrorProvider erroPorta;
        private System.Windows.Forms.ErrorProvider erroSenha;
        private System.Windows.Forms.ErrorProvider erroArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private TheClubExtendedComponent.Obrigatorio obrigatorio1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCaminho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmissor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}