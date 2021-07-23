﻿using Entities.Configurations;
using GoQR.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator.Forms
{
    public partial class Frm_QRCode_Email : Form
    {
        private Image _imgQrcode;
        private string _format;
        string[] email = new string[3];
        public Frm_QRCode_Email()
        {
            InitializeComponent();
        }

        private void Btn_CriarEmail_Click(object sender, EventArgs e)
        {
            Frm_EmailCadastro FForm = new Frm_EmailCadastro();
            FForm.ShowDialog();
            for (int i = 0; i < FForm.email.Length; i++)
            {
                email[i] = FForm.email[i];
            }
        }

        private void Btn_Generate_QRCode_Email_01_Click(object sender, EventArgs e)
        {
            var smsData = $"MATMSG:TO:{email[0]};SUB:{email[1]};BODY:{email[2]};;";

            QRConfig config = uC_QRConfig8.GetConfig();
            string strData = WebUtility.UrlEncode(smsData);//transforma o conteudo digitado em uma string valida.

            _format = config.Format;

            _imgQrcode = new GoQRCode().GetQRCode(strData, config);

            if (_imgQrcode != null)
            {
                Pic_Image_QRCodeEmail.BackgroundImage = _imgQrcode;
                Pic_Image_QRCodeEmail.BackgroundImageLayout = ImageLayout.Stretch;
                Btn_Generate_Save_QRCode_Email_03.Enabled = true;
            }
        }

        private void Btn_Generate_Clean_QRCode_Email_02_Click(object sender, EventArgs e)
        {
            Btn_Generate_Save_QRCode_Email_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;

            Pic_Image_QRCodeEmail.BackgroundImage = null;
            uC_QRConfig8.SetDefaultOptions();
        }

        private void Btn_Generate_Save_QRCode_Email_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Frm_QRCode_Email_Load(object sender, EventArgs e)
        {
            Btn_Generate_Clean_QRCode_Email_02_Click(Btn_Generate_Clean_QRCode_Email_02, new EventArgs());
        }
    }
}
