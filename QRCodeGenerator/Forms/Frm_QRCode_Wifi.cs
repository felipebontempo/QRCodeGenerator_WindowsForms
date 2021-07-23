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
    public partial class Frm_QRCode_Wifi : Form
    {
        private Image _imgQrcode;
        private string _format;
        string[] wifi = new string[4];
        public Frm_QRCode_Wifi()
        {
            InitializeComponent();
        }

        private void Btn_CriarWifi_Click(object sender, EventArgs e)
        {
            Frm_WifiCadastro FForm = new Frm_WifiCadastro();
            FForm.ShowDialog();
            for (int i = 0; i < FForm.wifi.Length; i++)
            {
                wifi[i] = FForm.wifi[i];
            }
        }

        private void Btn_Generate_QRCode_Wifi_01_Click(object sender, EventArgs e)
        {
            //WIFI:T:WEP;S:toca;P:321321;H:true;
            var smsData = $"WIFI:T:{wifi[0]};S:{wifi[1]};P:{wifi[2]};{wifi[3]};";

            QRConfig config = uC_QRConfig9.GetConfig();
            string strData = WebUtility.UrlEncode(smsData);//transforma o conteudo digitado em uma string valida.

            _format = config.Format;

            _imgQrcode = new GoQRCode().GetQRCode(strData, config);

            if (_imgQrcode != null)
            {
                Pic_Image_QRCodeWifi.BackgroundImage = _imgQrcode;
                Pic_Image_QRCodeWifi.BackgroundImageLayout = ImageLayout.Stretch;
                Btn_Generate_Save_QRCode_Wifi_03.Enabled = true;
            }
        }

        private void Btn_Generate_Clean_QRCode_Wifi_02_Click(object sender, EventArgs e)
        {
            Btn_Generate_Save_QRCode_Wifi_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;

            Pic_Image_QRCodeWifi.BackgroundImage = null;
            uC_QRConfig9.SetDefaultOptions();
        }

        private void Btn_Generate_Save_QRCode_Wifi_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Frm_QRCode_Wifi_Load(object sender, EventArgs e)
        {
            Btn_Generate_Clean_QRCode_Wifi_02_Click(Btn_Generate_Clean_QRCode_Wifi_02, new EventArgs());
        }
    }
}
