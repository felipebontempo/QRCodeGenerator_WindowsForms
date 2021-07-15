
namespace QRCodeGenerator.Forms
{
    partial class Frm_QRCode_Text
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
            this.Lbl_Texto = new System.Windows.Forms.Label();
            this.Configuration = new System.Windows.Forms.Label();
            this.Txt_Texto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_Image_QRCodeText = new System.Windows.Forms.PictureBox();
            this.Btn_Generate_QRCode_Text_01 = new System.Windows.Forms.Button();
            this.Btn_GenerateSave_QRCode_Text_03 = new System.Windows.Forms.Button();
            this.Btn_GenerateClean_QRCode_Text_02 = new System.Windows.Forms.Button();
            this.uC_QRConfig2 = new QRCodeGenerator.UC_QRConfig();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeText)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Texto
            // 
            this.Lbl_Texto.AutoSize = true;
            this.Lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Texto.Location = new System.Drawing.Point(8, 78);
            this.Lbl_Texto.Name = "Lbl_Texto";
            this.Lbl_Texto.Size = new System.Drawing.Size(58, 20);
            this.Lbl_Texto.TabIndex = 3;
            this.Lbl_Texto.Text = "Texto:";
            // 
            // Configuration
            // 
            this.Configuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuration.ForeColor = System.Drawing.SystemColors.Info;
            this.Configuration.Location = new System.Drawing.Point(12, 9);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(519, 57);
            this.Configuration.TabIndex = 2;
            this.Configuration.Text = "Data";
            this.Configuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Texto
            // 
            this.Txt_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Texto.Location = new System.Drawing.Point(8, 102);
            this.Txt_Texto.Name = "Txt_Texto";
            this.Txt_Texto.Size = new System.Drawing.Size(523, 23);
            this.Txt_Texto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(543, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "QRCode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic_Image_QRCodeText
            // 
            this.Pic_Image_QRCodeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Image_QRCodeText.Location = new System.Drawing.Point(543, 78);
            this.Pic_Image_QRCodeText.Name = "Pic_Image_QRCodeText";
            this.Pic_Image_QRCodeText.Size = new System.Drawing.Size(512, 483);
            this.Pic_Image_QRCodeText.TabIndex = 6;
            this.Pic_Image_QRCodeText.TabStop = false;
            // 
            // Btn_Generate_QRCode_Text_01
            // 
            this.Btn_Generate_QRCode_Text_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_QRCode_Text_01.Location = new System.Drawing.Point(8, 570);
            this.Btn_Generate_QRCode_Text_01.Name = "Btn_Generate_QRCode_Text_01";
            this.Btn_Generate_QRCode_Text_01.Size = new System.Drawing.Size(523, 48);
            this.Btn_Generate_QRCode_Text_01.TabIndex = 7;
            this.Btn_Generate_QRCode_Text_01.Text = "Generate";
            this.Btn_Generate_QRCode_Text_01.UseVisualStyleBackColor = true;
            this.Btn_Generate_QRCode_Text_01.Click += new System.EventHandler(this.Btn_Generate_QRCode_Text_01_Click);
            // 
            // Btn_GenerateSave_QRCode_Text_03
            // 
            this.Btn_GenerateSave_QRCode_Text_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerateSave_QRCode_Text_03.Location = new System.Drawing.Point(833, 570);
            this.Btn_GenerateSave_QRCode_Text_03.Name = "Btn_GenerateSave_QRCode_Text_03";
            this.Btn_GenerateSave_QRCode_Text_03.Size = new System.Drawing.Size(191, 48);
            this.Btn_GenerateSave_QRCode_Text_03.TabIndex = 8;
            this.Btn_GenerateSave_QRCode_Text_03.Text = "Save";
            this.Btn_GenerateSave_QRCode_Text_03.UseVisualStyleBackColor = true;
            this.Btn_GenerateSave_QRCode_Text_03.Click += new System.EventHandler(this.Btn_GenerateSave_QRCode_Text_03_Click);
            // 
            // Btn_GenerateClean_QRCode_Text_02
            // 
            this.Btn_GenerateClean_QRCode_Text_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerateClean_QRCode_Text_02.Location = new System.Drawing.Point(576, 570);
            this.Btn_GenerateClean_QRCode_Text_02.Name = "Btn_GenerateClean_QRCode_Text_02";
            this.Btn_GenerateClean_QRCode_Text_02.Size = new System.Drawing.Size(192, 48);
            this.Btn_GenerateClean_QRCode_Text_02.TabIndex = 9;
            this.Btn_GenerateClean_QRCode_Text_02.Text = "Clean";
            this.Btn_GenerateClean_QRCode_Text_02.UseVisualStyleBackColor = true;
            this.Btn_GenerateClean_QRCode_Text_02.Click += new System.EventHandler(this.Btn_GenerateClean_QRCode_Text_02_Click);
            // 
            // uC_QRConfig2
            // 
            this.uC_QRConfig2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_QRConfig2.Location = new System.Drawing.Point(8, 131);
            this.uC_QRConfig2.Name = "uC_QRConfig2";
            this.uC_QRConfig2.Size = new System.Drawing.Size(523, 422);
            this.uC_QRConfig2.TabIndex = 10;
            // 
            // Frm_QRCode_Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 627);
            this.Controls.Add(this.uC_QRConfig2);
            this.Controls.Add(this.Btn_GenerateClean_QRCode_Text_02);
            this.Controls.Add(this.Btn_GenerateSave_QRCode_Text_03);
            this.Controls.Add(this.Btn_Generate_QRCode_Text_01);
            this.Controls.Add(this.Pic_Image_QRCodeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Texto);
            this.Controls.Add(this.Lbl_Texto);
            this.Controls.Add(this.Configuration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_QRCode_Text";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QRCode Texto";
            this.Load += new System.EventHandler(this.Frm_QRCode_Text_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Texto;
        private System.Windows.Forms.Label Configuration;
        private System.Windows.Forms.TextBox Txt_Texto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_Image_QRCodeText;
        private System.Windows.Forms.Button Btn_Generate_QRCode_Text_01;
        private System.Windows.Forms.Button Btn_GenerateSave_QRCode_Text_03;
        private System.Windows.Forms.Button Btn_GenerateClean_QRCode_Text_02;
        private UC_QRConfig uC_QRConfig2;
    }
}