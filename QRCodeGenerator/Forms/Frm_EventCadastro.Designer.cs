
namespace QRCodeGenerator.Forms
{
    partial class Frm_EventCadastro
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
            this.Lbl_DescricaoEvento = new System.Windows.Forms.Label();
            this.Txt_DescricaoEvento = new System.Windows.Forms.TextBox();
            this.Cal_InicioEvento = new System.Windows.Forms.MonthCalendar();
            this.Cal_FinalEvento = new System.Windows.Forms.MonthCalendar();
            this.Lbl_TimeZone = new System.Windows.Forms.Label();
            this.Cmb_TimeZone = new System.Windows.Forms.ComboBox();
            this.Btn_OK_CriarEvento = new System.Windows.Forms.Button();
            this.dateTimePicker_InicioEvento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_FinalEvento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_DescricaoEvento
            // 
            this.Lbl_DescricaoEvento.AutoSize = true;
            this.Lbl_DescricaoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DescricaoEvento.Location = new System.Drawing.Point(22, 19);
            this.Lbl_DescricaoEvento.Name = "Lbl_DescricaoEvento";
            this.Lbl_DescricaoEvento.Size = new System.Drawing.Size(179, 20);
            this.Lbl_DescricaoEvento.TabIndex = 0;
            this.Lbl_DescricaoEvento.Text = "Descrição do Evendo";
            // 
            // Txt_DescricaoEvento
            // 
            this.Txt_DescricaoEvento.Location = new System.Drawing.Point(25, 45);
            this.Txt_DescricaoEvento.Name = "Txt_DescricaoEvento";
            this.Txt_DescricaoEvento.Size = new System.Drawing.Size(379, 20);
            this.Txt_DescricaoEvento.TabIndex = 1;
            // 
            // Cal_InicioEvento
            // 
            this.Cal_InicioEvento.Location = new System.Drawing.Point(24, 25);
            this.Cal_InicioEvento.MaxSelectionCount = 1;
            this.Cal_InicioEvento.MinDate = new System.DateTime(2021, 7, 21, 0, 0, 0, 0);
            this.Cal_InicioEvento.Name = "Cal_InicioEvento";
            this.Cal_InicioEvento.TabIndex = 4;
            // 
            // Cal_FinalEvento
            // 
            this.Cal_FinalEvento.Location = new System.Drawing.Point(12, 21);
            this.Cal_FinalEvento.MaxSelectionCount = 1;
            this.Cal_FinalEvento.MinDate = new System.DateTime(2021, 7, 21, 0, 0, 0, 0);
            this.Cal_FinalEvento.Name = "Cal_FinalEvento";
            this.Cal_FinalEvento.TabIndex = 5;
            // 
            // Lbl_TimeZone
            // 
            this.Lbl_TimeZone.AutoSize = true;
            this.Lbl_TimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TimeZone.Location = new System.Drawing.Point(406, 19);
            this.Lbl_TimeZone.Name = "Lbl_TimeZone";
            this.Lbl_TimeZone.Size = new System.Drawing.Size(93, 20);
            this.Lbl_TimeZone.TabIndex = 6;
            this.Lbl_TimeZone.Text = "Time Zone";
            // 
            // Cmb_TimeZone
            // 
            this.Cmb_TimeZone.FormattingEnabled = true;
            this.Cmb_TimeZone.Location = new System.Drawing.Point(410, 44);
            this.Cmb_TimeZone.Name = "Cmb_TimeZone";
            this.Cmb_TimeZone.Size = new System.Drawing.Size(142, 21);
            this.Cmb_TimeZone.TabIndex = 7;
            // 
            // Btn_OK_CriarEvento
            // 
            this.Btn_OK_CriarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK_CriarEvento.Location = new System.Drawing.Point(240, 327);
            this.Btn_OK_CriarEvento.Name = "Btn_OK_CriarEvento";
            this.Btn_OK_CriarEvento.Size = new System.Drawing.Size(126, 43);
            this.Btn_OK_CriarEvento.TabIndex = 8;
            this.Btn_OK_CriarEvento.Text = "OK";
            this.Btn_OK_CriarEvento.UseVisualStyleBackColor = true;
            this.Btn_OK_CriarEvento.Click += new System.EventHandler(this.Btn_OK_CriarEvento_Click);
            // 
            // dateTimePicker_InicioEvento
            // 
            this.dateTimePicker_InicioEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_InicioEvento.Location = new System.Drawing.Point(75, 199);
            this.dateTimePicker_InicioEvento.Name = "dateTimePicker_InicioEvento";
            this.dateTimePicker_InicioEvento.ShowUpDown = true;
            this.dateTimePicker_InicioEvento.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker_InicioEvento.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cal_InicioEvento);
            this.groupBox1.Controls.Add(this.dateTimePicker_InicioEvento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio do evento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker_FinalEvento);
            this.groupBox2.Controls.Add(this.Cal_FinalEvento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(320, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 245);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Final do evento";
            // 
            // dateTimePicker_FinalEvento
            // 
            this.dateTimePicker_FinalEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_FinalEvento.Location = new System.Drawing.Point(75, 195);
            this.dateTimePicker_FinalEvento.Name = "dateTimePicker_FinalEvento";
            this.dateTimePicker_FinalEvento.ShowUpDown = true;
            this.dateTimePicker_FinalEvento.Size = new System.Drawing.Size(112, 26);
            this.dateTimePicker_FinalEvento.TabIndex = 6;
            // 
            // Frm_EventCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_OK_CriarEvento);
            this.Controls.Add(this.Cmb_TimeZone);
            this.Controls.Add(this.Lbl_TimeZone);
            this.Controls.Add(this.Txt_DescricaoEvento);
            this.Controls.Add(this.Lbl_DescricaoEvento);
            this.Name = "Frm_EventCadastro";
            this.Text = "Cadastro de Evento";
            this.Load += new System.EventHandler(this.Frm_EventCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_DescricaoEvento;
        private System.Windows.Forms.TextBox Txt_DescricaoEvento;
        private System.Windows.Forms.MonthCalendar Cal_InicioEvento;
        private System.Windows.Forms.MonthCalendar Cal_FinalEvento;
        private System.Windows.Forms.Label Lbl_TimeZone;
        private System.Windows.Forms.ComboBox Cmb_TimeZone;
        private System.Windows.Forms.Button Btn_OK_CriarEvento;
        private System.Windows.Forms.DateTimePicker dateTimePicker_InicioEvento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FinalEvento;
    }
}