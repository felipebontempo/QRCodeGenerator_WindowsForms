
namespace QRCodeGenerator.Forms
{
    partial class Frm_QRCode_Call
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
            this.Lbl_CodPais = new System.Windows.Forms.Label();
            this.Configuration = new System.Windows.Forms.Label();
            this.Txt_CodPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_Image_QRCodeCall = new System.Windows.Forms.PictureBox();
            this.Btn_Generate_QRCode_Call_01 = new System.Windows.Forms.Button();
            this.Btn_Generate_Save_QRCode_Call_03 = new System.Windows.Forms.Button();
            this.Btn_Generate_Clean_QRCode_Call_02 = new System.Windows.Forms.Button();
            this.uC_QRConfig5 = new QRCodeGenerator.UC_QRConfig();
            this.Txt_CodArea = new System.Windows.Forms.TextBox();
            this.Lbl_CodArea = new System.Windows.Forms.Label();
            this.Txt_NumCall = new System.Windows.Forms.TextBox();
            this.Lbl_NumCall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeCall)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_CodPais
            // 
            this.Lbl_CodPais.AutoSize = true;
            this.Lbl_CodPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodPais.Location = new System.Drawing.Point(8, 78);
            this.Lbl_CodPais.Name = "Lbl_CodPais";
            this.Lbl_CodPais.Size = new System.Drawing.Size(128, 20);
            this.Lbl_CodPais.TabIndex = 3;
            this.Lbl_CodPais.Text = "Código do pais";
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
            // Txt_CodPais
            // 
            this.Txt_CodPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodPais.Location = new System.Drawing.Point(20, 102);
            this.Txt_CodPais.Name = "Txt_CodPais";
            this.Txt_CodPais.Size = new System.Drawing.Size(97, 23);
            this.Txt_CodPais.TabIndex = 4;
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
            // Pic_Image_QRCodeCall
            // 
            this.Pic_Image_QRCodeCall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Image_QRCodeCall.Location = new System.Drawing.Point(543, 78);
            this.Pic_Image_QRCodeCall.Name = "Pic_Image_QRCodeCall";
            this.Pic_Image_QRCodeCall.Size = new System.Drawing.Size(512, 483);
            this.Pic_Image_QRCodeCall.TabIndex = 6;
            this.Pic_Image_QRCodeCall.TabStop = false;
            // 
            // Btn_Generate_QRCode_Call_01
            // 
            this.Btn_Generate_QRCode_Call_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_QRCode_Call_01.Location = new System.Drawing.Point(8, 570);
            this.Btn_Generate_QRCode_Call_01.Name = "Btn_Generate_QRCode_Call_01";
            this.Btn_Generate_QRCode_Call_01.Size = new System.Drawing.Size(523, 48);
            this.Btn_Generate_QRCode_Call_01.TabIndex = 7;
            this.Btn_Generate_QRCode_Call_01.Text = "Generate";
            this.Btn_Generate_QRCode_Call_01.UseVisualStyleBackColor = true;
            this.Btn_Generate_QRCode_Call_01.Click += new System.EventHandler(this.Btn_Generate_QRCode_Call_01_Click);
            // 
            // Btn_Generate_Save_QRCode_Call_03
            // 
            this.Btn_Generate_Save_QRCode_Call_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_Save_QRCode_Call_03.Location = new System.Drawing.Point(833, 570);
            this.Btn_Generate_Save_QRCode_Call_03.Name = "Btn_Generate_Save_QRCode_Call_03";
            this.Btn_Generate_Save_QRCode_Call_03.Size = new System.Drawing.Size(191, 48);
            this.Btn_Generate_Save_QRCode_Call_03.TabIndex = 8;
            this.Btn_Generate_Save_QRCode_Call_03.Text = "Save";
            this.Btn_Generate_Save_QRCode_Call_03.UseVisualStyleBackColor = true;
            this.Btn_Generate_Save_QRCode_Call_03.Click += new System.EventHandler(this.Btn_Generate_Save_QRCode_Call_03_Click);
            // 
            // Btn_Generate_Clean_QRCode_Call_02
            // 
            this.Btn_Generate_Clean_QRCode_Call_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Generate_Clean_QRCode_Call_02.Location = new System.Drawing.Point(576, 570);
            this.Btn_Generate_Clean_QRCode_Call_02.Name = "Btn_Generate_Clean_QRCode_Call_02";
            this.Btn_Generate_Clean_QRCode_Call_02.Size = new System.Drawing.Size(192, 48);
            this.Btn_Generate_Clean_QRCode_Call_02.TabIndex = 9;
            this.Btn_Generate_Clean_QRCode_Call_02.Text = "Clean";
            this.Btn_Generate_Clean_QRCode_Call_02.UseVisualStyleBackColor = true;
            this.Btn_Generate_Clean_QRCode_Call_02.Click += new System.EventHandler(this.Btn_Generate_Clean_QRCode_Call_02_Click);
            // 
            // uC_QRConfig5
            // 
            this.uC_QRConfig5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_QRConfig5.Location = new System.Drawing.Point(8, 131);
            this.uC_QRConfig5.Name = "uC_QRConfig5";
            this.uC_QRConfig5.Size = new System.Drawing.Size(523, 422);
            this.uC_QRConfig5.TabIndex = 10;
            // 
            // Txt_CodArea
            // 
            this.Txt_CodArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodArea.Location = new System.Drawing.Point(154, 102);
            this.Txt_CodArea.Name = "Txt_CodArea";
            this.Txt_CodArea.Size = new System.Drawing.Size(97, 23);
            this.Txt_CodArea.TabIndex = 12;
            // 
            // Lbl_CodArea
            // 
            this.Lbl_CodArea.AutoSize = true;
            this.Lbl_CodArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodArea.Location = new System.Drawing.Point(142, 78);
            this.Lbl_CodArea.Name = "Lbl_CodArea";
            this.Lbl_CodArea.Size = new System.Drawing.Size(131, 20);
            this.Lbl_CodArea.TabIndex = 11;
            this.Lbl_CodArea.Text = "Código da area";
            // 
            // Txt_NumCall
            // 
            this.Txt_NumCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumCall.Location = new System.Drawing.Point(288, 102);
            this.Txt_NumCall.Name = "Txt_NumCall";
            this.Txt_NumCall.Size = new System.Drawing.Size(243, 23);
            this.Txt_NumCall.TabIndex = 14;
            // 
            // Lbl_NumCall
            // 
            this.Lbl_NumCall.AutoSize = true;
            this.Lbl_NumCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumCall.Location = new System.Drawing.Point(330, 79);
            this.Lbl_NumCall.Name = "Lbl_NumCall";
            this.Lbl_NumCall.Size = new System.Drawing.Size(167, 20);
            this.Lbl_NumCall.TabIndex = 13;
            this.Lbl_NumCall.Text = "Número de telefone";
            // 
            // Frm_QRCode_Call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 627);
            this.Controls.Add(this.Txt_NumCall);
            this.Controls.Add(this.Lbl_NumCall);
            this.Controls.Add(this.Txt_CodArea);
            this.Controls.Add(this.Lbl_CodArea);
            this.Controls.Add(this.uC_QRConfig5);
            this.Controls.Add(this.Btn_Generate_Clean_QRCode_Call_02);
            this.Controls.Add(this.Btn_Generate_Save_QRCode_Call_03);
            this.Controls.Add(this.Btn_Generate_QRCode_Call_01);
            this.Controls.Add(this.Pic_Image_QRCodeCall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_CodPais);
            this.Controls.Add(this.Lbl_CodPais);
            this.Controls.Add(this.Configuration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_QRCode_Call";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QRCode Telefone/Call";
            this.Load += new System.EventHandler(this.Frm_QRCode_Call_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image_QRCodeCall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_CodPais;
        private System.Windows.Forms.Label Configuration;
        private System.Windows.Forms.TextBox Txt_CodPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_Image_QRCodeCall;
        private System.Windows.Forms.Button Btn_Generate_QRCode_Call_01;
        private System.Windows.Forms.Button Btn_Generate_Save_QRCode_Call_03;
        private System.Windows.Forms.Button Btn_Generate_Clean_QRCode_Call_02;
        private UC_QRConfig uC_QRConfig5;
        private System.Windows.Forms.TextBox Txt_CodArea;
        private System.Windows.Forms.Label Lbl_CodArea;
        private System.Windows.Forms.TextBox Txt_NumCall;
        private System.Windows.Forms.Label Lbl_NumCall;
    }
}