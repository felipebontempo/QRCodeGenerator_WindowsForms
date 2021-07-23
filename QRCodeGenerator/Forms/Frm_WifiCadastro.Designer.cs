
namespace QRCodeGenerator.Forms
{
    partial class Frm_WifiCadastro
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
            this.Lbl_Wifi_Criptografia = new System.Windows.Forms.Label();
            this.Lbl_Wifi_SSID = new System.Windows.Forms.Label();
            this.Lbl_Wifi_Pass = new System.Windows.Forms.Label();
            this.Cmb_Wifi_cryption = new System.Windows.Forms.ComboBox();
            this.Txt_Wifi_SSID = new System.Windows.Forms.TextBox();
            this.Txt_Wifi_Pass = new System.Windows.Forms.TextBox();
            this.Chk_Wifi_Hide = new System.Windows.Forms.CheckBox();
            this.Btn_Wifi_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Wifi_Criptografia
            // 
            this.Lbl_Wifi_Criptografia.AutoSize = true;
            this.Lbl_Wifi_Criptografia.Location = new System.Drawing.Point(16, 22);
            this.Lbl_Wifi_Criptografia.Name = "Lbl_Wifi_Criptografia";
            this.Lbl_Wifi_Criptografia.Size = new System.Drawing.Size(104, 13);
            this.Lbl_Wifi_Criptografia.TabIndex = 0;
            this.Lbl_Wifi_Criptografia.Text = "Criptografia da Rede";
            // 
            // Lbl_Wifi_SSID
            // 
            this.Lbl_Wifi_SSID.AutoSize = true;
            this.Lbl_Wifi_SSID.Location = new System.Drawing.Point(157, 22);
            this.Lbl_Wifi_SSID.Name = "Lbl_Wifi_SSID";
            this.Lbl_Wifi_SSID.Size = new System.Drawing.Size(109, 13);
            this.Lbl_Wifi_SSID.TabIndex = 1;
            this.Lbl_Wifi_SSID.Text = "SSID/Nome da Rede";
            // 
            // Lbl_Wifi_Pass
            // 
            this.Lbl_Wifi_Pass.AutoSize = true;
            this.Lbl_Wifi_Pass.Location = new System.Drawing.Point(16, 63);
            this.Lbl_Wifi_Pass.Name = "Lbl_Wifi_Pass";
            this.Lbl_Wifi_Pass.Size = new System.Drawing.Size(82, 13);
            this.Lbl_Wifi_Pass.TabIndex = 3;
            this.Lbl_Wifi_Pass.Text = "Senha da Rede";
            // 
            // Cmb_Wifi_cryption
            // 
            this.Cmb_Wifi_cryption.FormattingEnabled = true;
            this.Cmb_Wifi_cryption.Location = new System.Drawing.Point(19, 39);
            this.Cmb_Wifi_cryption.Name = "Cmb_Wifi_cryption";
            this.Cmb_Wifi_cryption.Size = new System.Drawing.Size(101, 21);
            this.Cmb_Wifi_cryption.TabIndex = 4;
            // 
            // Txt_Wifi_SSID
            // 
            this.Txt_Wifi_SSID.Location = new System.Drawing.Point(160, 38);
            this.Txt_Wifi_SSID.Name = "Txt_Wifi_SSID";
            this.Txt_Wifi_SSID.Size = new System.Drawing.Size(205, 20);
            this.Txt_Wifi_SSID.TabIndex = 5;
            // 
            // Txt_Wifi_Pass
            // 
            this.Txt_Wifi_Pass.Location = new System.Drawing.Point(19, 79);
            this.Txt_Wifi_Pass.Name = "Txt_Wifi_Pass";
            this.Txt_Wifi_Pass.Size = new System.Drawing.Size(205, 20);
            this.Txt_Wifi_Pass.TabIndex = 6;
            // 
            // Chk_Wifi_Hide
            // 
            this.Chk_Wifi_Hide.AutoSize = true;
            this.Chk_Wifi_Hide.Location = new System.Drawing.Point(243, 79);
            this.Chk_Wifi_Hide.Name = "Chk_Wifi_Hide";
            this.Chk_Wifi_Hide.Size = new System.Drawing.Size(295, 17);
            this.Chk_Wifi_Hide.TabIndex = 7;
            this.Chk_Wifi_Hide.Text = "Apenas marque essa opção se a rede Wifi estiver oculta.";
            this.Chk_Wifi_Hide.UseVisualStyleBackColor = true;
            // 
            // Btn_Wifi_OK
            // 
            this.Btn_Wifi_OK.Location = new System.Drawing.Point(194, 116);
            this.Btn_Wifi_OK.Name = "Btn_Wifi_OK";
            this.Btn_Wifi_OK.Size = new System.Drawing.Size(142, 41);
            this.Btn_Wifi_OK.TabIndex = 8;
            this.Btn_Wifi_OK.Text = "OK";
            this.Btn_Wifi_OK.UseVisualStyleBackColor = true;
            this.Btn_Wifi_OK.Click += new System.EventHandler(this.Btn_Wifi_OK_Click);
            // 
            // Frm_WifiCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 186);
            this.Controls.Add(this.Btn_Wifi_OK);
            this.Controls.Add(this.Chk_Wifi_Hide);
            this.Controls.Add(this.Txt_Wifi_Pass);
            this.Controls.Add(this.Txt_Wifi_SSID);
            this.Controls.Add(this.Cmb_Wifi_cryption);
            this.Controls.Add(this.Lbl_Wifi_Pass);
            this.Controls.Add(this.Lbl_Wifi_SSID);
            this.Controls.Add(this.Lbl_Wifi_Criptografia);
            this.Name = "Frm_WifiCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode - Wifi conexão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Wifi_Criptografia;
        private System.Windows.Forms.Label Lbl_Wifi_SSID;
        private System.Windows.Forms.Label Lbl_Wifi_Pass;
        private System.Windows.Forms.ComboBox Cmb_Wifi_cryption;
        private System.Windows.Forms.TextBox Txt_Wifi_SSID;
        private System.Windows.Forms.TextBox Txt_Wifi_Pass;
        private System.Windows.Forms.CheckBox Chk_Wifi_Hide;
        private System.Windows.Forms.Button Btn_Wifi_OK;
    }
}