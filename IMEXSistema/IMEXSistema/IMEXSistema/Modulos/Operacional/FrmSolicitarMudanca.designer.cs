﻿namespace winfit.Modulos.Outros
{
    partial class FrmSolicitarMudanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitarMudanca));
            this.txtParaEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAssuntoEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkConSegSSL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParaEmail
            // 
            this.txtParaEmail.Location = new System.Drawing.Point(17, 25);
            this.txtParaEmail.Name = "txtParaEmail";
            this.txtParaEmail.ReadOnly = true;
            this.txtParaEmail.Size = new System.Drawing.Size(264, 20);
            this.txtParaEmail.TabIndex = 0;
            this.txtParaEmail.Text = "contato@imexsistemas.com.br";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 188;
            this.label13.Text = "Email Destino:";
            // 
            // txtAssuntoEmail
            // 
            this.txtAssuntoEmail.Location = new System.Drawing.Point(17, 64);
            this.txtAssuntoEmail.Name = "txtAssuntoEmail";
            this.txtAssuntoEmail.ReadOnly = true;
            this.txtAssuntoEmail.Size = new System.Drawing.Size(726, 20);
            this.txtAssuntoEmail.TabIndex = 4;
            this.txtAssuntoEmail.Text = "Solicitação de Mudanças no Sistema IMEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 190;
            this.label2.Text = "Assunto:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(16, 103);
            this.txtMensagem.MaxLength = 1000;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagem.Size = new System.Drawing.Size(727, 169);
            this.txtMensagem.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 192;
            this.label6.Text = "Mensagem:";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(101, 342);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 194;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(20, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Enviar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(287, 25);
            this.txtPorta.MaxLength = 4;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(65, 20);
            this.txtPorta.TabIndex = 1;
            this.txtPorta.Text = "0";
            this.txtPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 219;
            this.label1.Text = "Porta:";
            // 
            // chkConSegSSL
            // 
            this.chkConSegSSL.AutoSize = true;
            this.chkConSegSSL.Location = new System.Drawing.Point(358, 28);
            this.chkConSegSSL.Name = "chkConSegSSL";
            this.chkConSegSSL.Size = new System.Drawing.Size(153, 17);
            this.chkConSegSSL.TabIndex = 2;
            this.chkConSegSSL.Text = "Usar conexão segura: SSL";
            this.chkConSegSSL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(17, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(672, 15);
            this.label3.TabIndex = 220;
            this.label3.Text = "Caso o cliente desejar que a equipe técnica da IMEX Sistemas execute alguma munda" +
    "ça no sistema de";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(17, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(706, 15);
            this.label4.TabIndex = 221;
            this.label4.Text = "qualquer natureza, esta poderá ser feita mediante a aprovação de orçamento repass" +
    "ado pela IMEX Sistemas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 15);
            this.label5.TabIndex = 222;
            this.label5.Text = "equivalente à quantidade de horas necessárias para a execução do serviço.";
            // 
            // FrmSolicitarMudanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkConSegSSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAssuntoEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParaEmail);
            this.Controls.Add(this.label13);
            this.Name = "FrmSolicitarMudanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Mudança";
            this.Load += new System.EventHandler(this.FrmContato_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContato_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParaEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAssuntoEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkConSegSSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}