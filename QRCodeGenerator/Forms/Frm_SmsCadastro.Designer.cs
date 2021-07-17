
namespace QRCodeGenerator.Forms
{
    partial class Frm_SmsCadastro
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
            this.Lbl_SMS_CodigoPais = new System.Windows.Forms.Label();
            this.Txt_SMS_CodigoPais = new System.Windows.Forms.TextBox();
            this.Txt_SMS_CodigoArea = new System.Windows.Forms.TextBox();
            this.Lbl_SMS_CodigoArea = new System.Windows.Forms.Label();
            this.Txt_SMS_NumeroTelefone = new System.Windows.Forms.TextBox();
            this.Lbl_SMS_NumeroTelefone = new System.Windows.Forms.Label();
            this.Txt_SMS_Mensagem = new System.Windows.Forms.TextBox();
            this.Lbl_SMS_Mensagem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_SMS_CodigoPais
            // 
            this.Lbl_SMS_CodigoPais.AutoSize = true;
            this.Lbl_SMS_CodigoPais.Location = new System.Drawing.Point(18, 30);
            this.Lbl_SMS_CodigoPais.Name = "Lbl_SMS_CodigoPais";
            this.Lbl_SMS_CodigoPais.Size = new System.Drawing.Size(77, 13);
            this.Lbl_SMS_CodigoPais.TabIndex = 0;
            this.Lbl_SMS_CodigoPais.Text = "Código do pais";
            // 
            // Txt_SMS_CodigoPais
            // 
            this.Txt_SMS_CodigoPais.Location = new System.Drawing.Point(20, 46);
            this.Txt_SMS_CodigoPais.Name = "Txt_SMS_CodigoPais";
            this.Txt_SMS_CodigoPais.Size = new System.Drawing.Size(73, 20);
            this.Txt_SMS_CodigoPais.TabIndex = 1;
            // 
            // Txt_SMS_CodigoArea
            // 
            this.Txt_SMS_CodigoArea.Location = new System.Drawing.Point(121, 46);
            this.Txt_SMS_CodigoArea.Name = "Txt_SMS_CodigoArea";
            this.Txt_SMS_CodigoArea.Size = new System.Drawing.Size(73, 20);
            this.Txt_SMS_CodigoArea.TabIndex = 3;
            // 
            // Lbl_SMS_CodigoArea
            // 
            this.Lbl_SMS_CodigoArea.AutoSize = true;
            this.Lbl_SMS_CodigoArea.Location = new System.Drawing.Point(119, 30);
            this.Lbl_SMS_CodigoArea.Name = "Lbl_SMS_CodigoArea";
            this.Lbl_SMS_CodigoArea.Size = new System.Drawing.Size(79, 13);
            this.Lbl_SMS_CodigoArea.TabIndex = 2;
            this.Lbl_SMS_CodigoArea.Text = "Código da area";
            // 
            // Txt_SMS_NumeroTelefone
            // 
            this.Txt_SMS_NumeroTelefone.Location = new System.Drawing.Point(223, 46);
            this.Txt_SMS_NumeroTelefone.Name = "Txt_SMS_NumeroTelefone";
            this.Txt_SMS_NumeroTelefone.Size = new System.Drawing.Size(120, 20);
            this.Txt_SMS_NumeroTelefone.TabIndex = 5;
            // 
            // Lbl_SMS_NumeroTelefone
            // 
            this.Lbl_SMS_NumeroTelefone.AutoSize = true;
            this.Lbl_SMS_NumeroTelefone.Location = new System.Drawing.Point(231, 30);
            this.Lbl_SMS_NumeroTelefone.Name = "Lbl_SMS_NumeroTelefone";
            this.Lbl_SMS_NumeroTelefone.Size = new System.Drawing.Size(100, 13);
            this.Lbl_SMS_NumeroTelefone.TabIndex = 4;
            this.Lbl_SMS_NumeroTelefone.Text = "Número de telefone";
            // 
            // Txt_SMS_Mensagem
            // 
            this.Txt_SMS_Mensagem.Location = new System.Drawing.Point(20, 111);
            this.Txt_SMS_Mensagem.Name = "Txt_SMS_Mensagem";
            this.Txt_SMS_Mensagem.Size = new System.Drawing.Size(323, 20);
            this.Txt_SMS_Mensagem.TabIndex = 7;
            // 
            // Lbl_SMS_Mensagem
            // 
            this.Lbl_SMS_Mensagem.AutoSize = true;
            this.Lbl_SMS_Mensagem.Location = new System.Drawing.Point(18, 95);
            this.Lbl_SMS_Mensagem.Name = "Lbl_SMS_Mensagem";
            this.Lbl_SMS_Mensagem.Size = new System.Drawing.Size(100, 13);
            this.Lbl_SMS_Mensagem.TabIndex = 6;
            this.Lbl_SMS_Mensagem.Text = "Mensagem do SMS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_SmsCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_SMS_Mensagem);
            this.Controls.Add(this.Lbl_SMS_Mensagem);
            this.Controls.Add(this.Txt_SMS_NumeroTelefone);
            this.Controls.Add(this.Lbl_SMS_NumeroTelefone);
            this.Controls.Add(this.Txt_SMS_CodigoArea);
            this.Controls.Add(this.Lbl_SMS_CodigoArea);
            this.Controls.Add(this.Txt_SMS_CodigoPais);
            this.Controls.Add(this.Lbl_SMS_CodigoPais);
            this.Name = "Frm_SmsCadastro";
            this.Text = "Cadastro para criar um QrCode de SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_SMS_CodigoPais;
        private System.Windows.Forms.TextBox Txt_SMS_CodigoPais;
        private System.Windows.Forms.TextBox Txt_SMS_CodigoArea;
        private System.Windows.Forms.Label Lbl_SMS_CodigoArea;
        private System.Windows.Forms.TextBox Txt_SMS_NumeroTelefone;
        private System.Windows.Forms.Label Lbl_SMS_NumeroTelefone;
        private System.Windows.Forms.TextBox Txt_SMS_Mensagem;
        private System.Windows.Forms.Label Lbl_SMS_Mensagem;
        private System.Windows.Forms.Button button1;
    }
}