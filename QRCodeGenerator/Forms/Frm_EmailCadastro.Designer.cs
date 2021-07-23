
namespace QRCodeGenerator.Forms
{
    partial class Frm_EmailCadastro
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
            this.Txt_EmailDest = new System.Windows.Forms.TextBox();
            this.Lbl_EmailDest = new System.Windows.Forms.Label();
            this.Lbl_EmailAssunto = new System.Windows.Forms.Label();
            this.Txt_EmailAssunto = new System.Windows.Forms.TextBox();
            this.Txt_EmailConteudo = new System.Windows.Forms.TextBox();
            this.Lbl_EmailConteudo = new System.Windows.Forms.Label();
            this.Btn_EmailOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_EmailDest
            // 
            this.Txt_EmailDest.Location = new System.Drawing.Point(25, 48);
            this.Txt_EmailDest.Name = "Txt_EmailDest";
            this.Txt_EmailDest.Size = new System.Drawing.Size(282, 20);
            this.Txt_EmailDest.TabIndex = 0;
            // 
            // Lbl_EmailDest
            // 
            this.Lbl_EmailDest.AutoSize = true;
            this.Lbl_EmailDest.Location = new System.Drawing.Point(22, 32);
            this.Lbl_EmailDest.Name = "Lbl_EmailDest";
            this.Lbl_EmailDest.Size = new System.Drawing.Size(107, 13);
            this.Lbl_EmailDest.TabIndex = 1;
            this.Lbl_EmailDest.Text = "E-mail do destinatário";
            // 
            // Lbl_EmailAssunto
            // 
            this.Lbl_EmailAssunto.AutoSize = true;
            this.Lbl_EmailAssunto.Location = new System.Drawing.Point(322, 32);
            this.Lbl_EmailAssunto.Name = "Lbl_EmailAssunto";
            this.Lbl_EmailAssunto.Size = new System.Drawing.Size(45, 13);
            this.Lbl_EmailAssunto.TabIndex = 3;
            this.Lbl_EmailAssunto.Text = "Assunto";
            // 
            // Txt_EmailAssunto
            // 
            this.Txt_EmailAssunto.Location = new System.Drawing.Point(325, 48);
            this.Txt_EmailAssunto.Name = "Txt_EmailAssunto";
            this.Txt_EmailAssunto.Size = new System.Drawing.Size(282, 20);
            this.Txt_EmailAssunto.TabIndex = 2;
            // 
            // Txt_EmailConteudo
            // 
            this.Txt_EmailConteudo.Location = new System.Drawing.Point(25, 104);
            this.Txt_EmailConteudo.Multiline = true;
            this.Txt_EmailConteudo.Name = "Txt_EmailConteudo";
            this.Txt_EmailConteudo.Size = new System.Drawing.Size(582, 139);
            this.Txt_EmailConteudo.TabIndex = 4;
            // 
            // Lbl_EmailConteudo
            // 
            this.Lbl_EmailConteudo.AutoSize = true;
            this.Lbl_EmailConteudo.Location = new System.Drawing.Point(25, 85);
            this.Lbl_EmailConteudo.Name = "Lbl_EmailConteudo";
            this.Lbl_EmailConteudo.Size = new System.Drawing.Size(96, 13);
            this.Lbl_EmailConteudo.TabIndex = 5;
            this.Lbl_EmailConteudo.Text = "Conteudo do Email";
            // 
            // Btn_EmailOK
            // 
            this.Btn_EmailOK.Location = new System.Drawing.Point(251, 266);
            this.Btn_EmailOK.Name = "Btn_EmailOK";
            this.Btn_EmailOK.Size = new System.Drawing.Size(129, 49);
            this.Btn_EmailOK.TabIndex = 6;
            this.Btn_EmailOK.Text = "OK";
            this.Btn_EmailOK.UseVisualStyleBackColor = true;
            this.Btn_EmailOK.Click += new System.EventHandler(this.Btn_EmailOK_Click);
            // 
            // Frm_EmailCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.Btn_EmailOK);
            this.Controls.Add(this.Lbl_EmailConteudo);
            this.Controls.Add(this.Txt_EmailConteudo);
            this.Controls.Add(this.Lbl_EmailAssunto);
            this.Controls.Add(this.Txt_EmailAssunto);
            this.Controls.Add(this.Lbl_EmailDest);
            this.Controls.Add(this.Txt_EmailDest);
            this.Name = "Frm_EmailCadastro";
            this.Text = "Criação de e-mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_EmailDest;
        private System.Windows.Forms.Label Lbl_EmailDest;
        private System.Windows.Forms.Label Lbl_EmailAssunto;
        private System.Windows.Forms.TextBox Txt_EmailAssunto;
        private System.Windows.Forms.TextBox Txt_EmailConteudo;
        private System.Windows.Forms.Label Lbl_EmailConteudo;
        private System.Windows.Forms.Button Btn_EmailOK;
    }
}