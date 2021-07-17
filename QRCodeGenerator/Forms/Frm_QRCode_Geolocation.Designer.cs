
namespace QRCodeGenerator.Forms
{
    partial class Frm_QRCode_Geolocation
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
            this.Lbl_Latitude = new System.Windows.Forms.Label();
            this.Configuration = new System.Windows.Forms.Label();
            this.Txt_Latitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_Image_QRCodeGeo = new System.Windows.Forms.PictureBox();
            this.Btn_Generate_QRCode_Geo_01 = new System.Windows.Forms.Button();
            this.Btn_Generate_Save_QRCode_Geo_03 = new System.Windows.Forms.Button();
            this.Btn_Generate_Clean_QRCode_Geo_02 = new System.Windows.Forms.Button();
            this.Txt_Longitude = new System.Windows.Forms.TextBox();
            this.Lbl_Longitude = new System.Windows.Forms.Label();
            this.uC_QRConfig6 = new QRCodeGenerator.UC_QRConfig();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeGeo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Latitude
            // 
            this.Lbl_Latitude.AutoSize = true;
            this.Lbl_Latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Latitude.Location = new System.Drawing.Point(8, 78);
            this.Lbl_Latitude.Name = "Lbl_Latitude";
            this.Lbl_Latitude.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Latitude.TabIndex = 3;
            this.Lbl_Latitude.Text = "Latitude:";
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
            // Txt_Latitude
            // 
            this.Txt_Latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Latitude.Location = new System.Drawing.Point(8, 102);
            this.Txt_Latitude.Name = "Txt_Latitude";
            this.Txt_Latitude.Size = new System.Drawing.Size(241, 23);
            this.Txt_Latitude.TabIndex = 1;
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
            // Pic_Image_QRCodeGeo
            // 
            this.Pic_Image_QRCodeGeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Image_QRCodeGeo.Location = new System.Drawing.Point(543, 78);
            this.Pic_Image_QRCodeGeo.Name = "Pic_Image_QRCodeGeo";
            this.Pic_Image_QRCodeGeo.Size = new System.Drawing.Size(512, 483);
            this.Pic_Image_QRCodeGeo.TabIndex = 6;
            this.Pic_Image_QRCodeGeo.TabStop = false;
            // 
            // Btn_Generate_QRCode_Geo_01
            // 
            this.Btn_Generate_QRCode_Geo_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_QRCode_Geo_01.Location = new System.Drawing.Point(8, 570);
            this.Btn_Generate_QRCode_Geo_01.Name = "Btn_Generate_QRCode_Geo_01";
            this.Btn_Generate_QRCode_Geo_01.Size = new System.Drawing.Size(523, 48);
            this.Btn_Generate_QRCode_Geo_01.TabIndex = 3;
            this.Btn_Generate_QRCode_Geo_01.Text = "Generate";
            this.Btn_Generate_QRCode_Geo_01.UseVisualStyleBackColor = true;
            this.Btn_Generate_QRCode_Geo_01.Click += new System.EventHandler(this.Btn_Generate_QRCode_Geo_01_Click);
            // 
            // Btn_Generate_Save_QRCode_Geo_03
            // 
            this.Btn_Generate_Save_QRCode_Geo_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_Save_QRCode_Geo_03.Location = new System.Drawing.Point(833, 570);
            this.Btn_Generate_Save_QRCode_Geo_03.Name = "Btn_Generate_Save_QRCode_Geo_03";
            this.Btn_Generate_Save_QRCode_Geo_03.Size = new System.Drawing.Size(191, 48);
            this.Btn_Generate_Save_QRCode_Geo_03.TabIndex = 5;
            this.Btn_Generate_Save_QRCode_Geo_03.Text = "Save";
            this.Btn_Generate_Save_QRCode_Geo_03.UseVisualStyleBackColor = true;
            this.Btn_Generate_Save_QRCode_Geo_03.Click += new System.EventHandler(this.Btn_Generate_Save_QRCode_Geo_03_Click);
            // 
            // Btn_Generate_Clean_QRCode_Geo_02
            // 
            this.Btn_Generate_Clean_QRCode_Geo_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_Clean_QRCode_Geo_02.Location = new System.Drawing.Point(576, 570);
            this.Btn_Generate_Clean_QRCode_Geo_02.Name = "Btn_Generate_Clean_QRCode_Geo_02";
            this.Btn_Generate_Clean_QRCode_Geo_02.Size = new System.Drawing.Size(192, 48);
            this.Btn_Generate_Clean_QRCode_Geo_02.TabIndex = 4;
            this.Btn_Generate_Clean_QRCode_Geo_02.Text = "Clean";
            this.Btn_Generate_Clean_QRCode_Geo_02.UseVisualStyleBackColor = true;
            this.Btn_Generate_Clean_QRCode_Geo_02.Click += new System.EventHandler(this.Btn_Generate_Clean_QRCode_Geo_02_Click);
            // 
            // Txt_Longitude
            // 
            this.Txt_Longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Longitude.Location = new System.Drawing.Point(293, 102);
            this.Txt_Longitude.Name = "Txt_Longitude";
            this.Txt_Longitude.Size = new System.Drawing.Size(241, 23);
            this.Txt_Longitude.TabIndex = 2;
            // 
            // Lbl_Longitude
            // 
            this.Lbl_Longitude.AutoSize = true;
            this.Lbl_Longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Longitude.Location = new System.Drawing.Point(289, 78);
            this.Lbl_Longitude.Name = "Lbl_Longitude";
            this.Lbl_Longitude.Size = new System.Drawing.Size(89, 20);
            this.Lbl_Longitude.TabIndex = 11;
            this.Lbl_Longitude.Text = "Longitude";
            // 
            // uC_QRConfig6
            // 
            this.uC_QRConfig6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_QRConfig6.Location = new System.Drawing.Point(8, 131);
            this.uC_QRConfig6.Name = "uC_QRConfig6";
            this.uC_QRConfig6.Size = new System.Drawing.Size(523, 422);
            this.uC_QRConfig6.TabIndex = 10;
            this.uC_QRConfig6.TabStop = false;
            // 
            // Frm_QRCode_Geolocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 627);
            this.Controls.Add(this.Txt_Longitude);
            this.Controls.Add(this.Lbl_Longitude);
            this.Controls.Add(this.uC_QRConfig6);
            this.Controls.Add(this.Btn_Generate_Clean_QRCode_Geo_02);
            this.Controls.Add(this.Btn_Generate_Save_QRCode_Geo_03);
            this.Controls.Add(this.Btn_Generate_QRCode_Geo_01);
            this.Controls.Add(this.Pic_Image_QRCodeGeo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Latitude);
            this.Controls.Add(this.Lbl_Latitude);
            this.Controls.Add(this.Configuration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_QRCode_Geolocation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QRCode Localização";
            this.Load += new System.EventHandler(this.Frm_QRCode_Geolocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeGeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Latitude;
        private System.Windows.Forms.Label Configuration;
        private System.Windows.Forms.TextBox Txt_Latitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_Image_QRCodeGeo;
        private System.Windows.Forms.Button Btn_Generate_QRCode_Geo_01;
        private System.Windows.Forms.Button Btn_Generate_Save_QRCode_Geo_03;
        private System.Windows.Forms.Button Btn_Generate_Clean_QRCode_Geo_02;
        private UC_QRConfig uC_QRConfig6;
        private System.Windows.Forms.TextBox Txt_Longitude;
        private System.Windows.Forms.Label Lbl_Longitude;
    }
}