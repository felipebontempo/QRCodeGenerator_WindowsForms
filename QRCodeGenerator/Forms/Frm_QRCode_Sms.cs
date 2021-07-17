using Entities.Configurations;
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
    public partial class Frm_QRCode_Sms : Form
    {
        private Image _imgQrcode;
        private string _format;
        string[] novoSmsPrenchido = new string[4];
        public Frm_QRCode_Sms()
        {
            InitializeComponent();
        }

        private void Btn_SmsCadastro_Click(object sender, EventArgs e)
        {
            Frm_SmsCadastro FForm = new Frm_SmsCadastro();
            FForm.ShowDialog();            
            for (int i = 0; i < FForm.novoSms.Length; i++)
            {
                novoSmsPrenchido[i] = FForm.novoSms[i];
            }
        }

        private void Btn_Generate_QRCode_SMS_01_Click(object sender, EventArgs e)
        {
            var smsData = $"SMSTO:{novoSmsPrenchido[0]}{novoSmsPrenchido[1]}{novoSmsPrenchido[2]}:{novoSmsPrenchido[3]}";

            QRConfig config = uC_QRConfig4.GetConfig();
            string strData = WebUtility.UrlEncode(smsData);//transforma o conteudo digitado em uma string valida.
            
            _format = config.Format;

            _imgQrcode = new GoQRCode().GetQRCode(strData, config);

            if (_imgQrcode != null)
            {
                Pic_Image_QRCodeSms.BackgroundImage = _imgQrcode;
                Pic_Image_QRCodeSms.BackgroundImageLayout = ImageLayout.Stretch;
                Btn_Generate_Save_QRCode_SMS_03.Enabled = true;
            }
        }

        private void Btn_Generate_Save_QRCode_SMS_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Btn_Generate_Clean_QRCode_SMS_02_Click(object sender, EventArgs e)
        {
            Btn_Generate_Save_QRCode_SMS_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;

            Pic_Image_QRCodeSms.BackgroundImage = null;
            uC_QRConfig4.SetDefaultOptions();
        }

        private void Frm_QRCode_Sms_Load(object sender, EventArgs e)
        {
            Btn_Generate_Clean_QRCode_SMS_02_Click(Btn_Generate_Clean_QRCode_SMS_02, new EventArgs());
        }
    }
}
