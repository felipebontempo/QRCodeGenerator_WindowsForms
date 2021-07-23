
namespace QRCodeGenerator.Forms
{
    partial class Frm_QRCode_Email
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
            this.Configuration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_Image_QRCodeEmail = new System.Windows.Forms.PictureBox();
            this.Btn_Generate_QRCode_Email_01 = new System.Windows.Forms.Button();
            this.Btn_Generate_Save_QRCode_Email_03 = new System.Windows.Forms.Button();
            this.Btn_Generate_Clean_QRCode_Email_02 = new System.Windows.Forms.Button();
            this.Btn_CriarEmail = new System.Windows.Forms.Button();
            this.uC_QRConfig8 = new QRCodeGenerator.UC_QRConfig();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeEmail)).BeginInit();
            this.SuspendLayout();
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
            // Pic_Image_QRCodeEmail
            // 
            this.Pic_Image_QRCodeEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Image_QRCodeEmail.Location = new System.Drawing.Point(543, 78);
            this.Pic_Image_QRCodeEmail.Name = "Pic_Image_QRCodeEmail";
            this.Pic_Image_QRCodeEmail.Size = new System.Drawing.Size(512, 483);
            this.Pic_Image_QRCodeEmail.TabIndex = 6;
            this.Pic_Image_QRCodeEmail.TabStop = false;
            // 
            // Btn_Generate_QRCode_Email_01
            // 
            this.Btn_Generate_QRCode_Email_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_QRCode_Email_01.Location = new System.Drawing.Point(8, 570);
            this.Btn_Generate_QRCode_Email_01.Name = "Btn_Generate_QRCode_Email_01";
            this.Btn_Generate_QRCode_Email_01.Size = new System.Drawing.Size(523, 48);
            this.Btn_Generate_QRCode_Email_01.TabIndex = 7;
            this.Btn_Generate_QRCode_Email_01.Text = "Generate";
            this.Btn_Generate_QRCode_Email_01.UseVisualStyleBackColor = true;
            this.Btn_Generate_QRCode_Email_01.Click += new System.EventHandler(this.Btn_Generate_QRCode_Email_01_Click);
            // 
            // Btn_Generate_Save_QRCode_Email_03
            // 
            this.Btn_Generate_Save_QRCode_Email_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_Save_QRCode_Email_03.Location = new System.Drawing.Point(833, 570);
            this.Btn_Generate_Save_QRCode_Email_03.Name = "Btn_Generate_Save_QRCode_Email_03";
            this.Btn_Generate_Save_QRCode_Email_03.Size = new System.Drawing.Size(191, 48);
            this.Btn_Generate_Save_QRCode_Email_03.TabIndex = 8;
            this.Btn_Generate_Save_QRCode_Email_03.Text = "Save";
            this.Btn_Generate_Save_QRCode_Email_03.UseVisualStyleBackColor = true;
            this.Btn_Generate_Save_QRCode_Email_03.Click += new System.EventHandler(this.Btn_Generate_Save_QRCode_Email_03_Click);
            // 
            // Btn_Generate_Clean_QRCode_Email_02
            // 
            this.Btn_Generate_Clean_QRCode_Email_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_Clean_QRCode_Email_02.Location = new System.Drawing.Point(576, 570);
            this.Btn_Generate_Clean_QRCode_Email_02.Name = "Btn_Generate_Clean_QRCode_Email_02";
            this.Btn_Generate_Clean_QRCode_Email_02.Size = new System.Drawing.Size(192, 48);
            this.Btn_Generate_Clean_QRCode_Email_02.TabIndex = 9;
            this.Btn_Generate_Clean_QRCode_Email_02.Text = "Clean";
            this.Btn_Generate_Clean_QRCode_Email_02.UseVisualStyleBackColor = true;
            this.Btn_Generate_Clean_QRCode_Email_02.Click += new System.EventHandler(this.Btn_Generate_Clean_QRCode_Email_02_Click);
            // 
            // Btn_CriarEmail
            // 
            this.Btn_CriarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CriarEmail.Location = new System.Drawing.Point(187, 75);
            this.Btn_CriarEmail.Name = "Btn_CriarEmail";
            this.Btn_CriarEmail.Size = new System.Drawing.Size(163, 47);
            this.Btn_CriarEmail.TabIndex = 13;
            this.Btn_CriarEmail.Text = "Criar Email";
            this.Btn_CriarEmail.UseVisualStyleBackColor = true;
            this.Btn_CriarEmail.Click += new System.EventHandler(this.Btn_CriarEmail_Click);
            // 
            // uC_QRConfig8
            // 
            this.uC_QRConfig8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_QRConfig8.Location = new System.Drawing.Point(8, 131);
            this.uC_QRConfig8.Name = "uC_QRConfig8";
            this.uC_QRConfig8.Size = new System.Drawing.Size(523, 422);
            this.uC_QRConfig8.TabIndex = 10;
            // 
            // Frm_QRCode_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 627);
            this.Controls.Add(this.Btn_CriarEmail);
            this.Controls.Add(this.uC_QRConfig8);
            this.Controls.Add(this.Btn_Generate_Clean_QRCode_Email_02);
            this.Controls.Add(this.Btn_Generate_Save_QRCode_Email_03);
            this.Controls.Add(this.Btn_Generate_QRCode_Email_01);
            this.Controls.Add(this.Pic_Image_QRCodeEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Configuration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_QRCode_Email";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QRCode E-mail";
            this.Load += new System.EventHandler(this.Frm_QRCode_Email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Configuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_Image_QRCodeEmail;
        private System.Windows.Forms.Button Btn_Generate_QRCode_Email_01;
        private System.Windows.Forms.Button Btn_Generate_Save_QRCode_Email_03;
        private System.Windows.Forms.Button Btn_Generate_Clean_QRCode_Email_02;
        private UC_QRConfig uC_QRConfig8;
        private System.Windows.Forms.Button Btn_CriarEmail;
    }
}