namespace Alerta_distribuição.Emails
{
    partial class frmEmailRetificao
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
            this.txtEmailRetificacao = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailRetificacao
            // 
            this.txtEmailRetificacao.Location = new System.Drawing.Point(12, 86);
            this.txtEmailRetificacao.Multiline = true;
            this.txtEmailRetificacao.Name = "txtEmailRetificacao";
            this.txtEmailRetificacao.Size = new System.Drawing.Size(548, 168);
            this.txtEmailRetificacao.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(8, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(565, 40);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Escreva o texto que será enviado como justificativa para os analistas \r\nreferente" +
    " a distribuição incorreta dos chamados .";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(389, 278);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar E-mail";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(484, 278);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmEmailRetificao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 313);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtEmailRetificacao);
            this.Name = "frmEmailRetificao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retificação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailRetificacao;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnOK;
    }
}