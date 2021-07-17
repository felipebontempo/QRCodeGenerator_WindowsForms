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
    public partial class Frm_QRCode_Geolocation : Form
    {
        private Image _imgQrcode;
        private string _format;
        string[] geo = new string[2];
        public Frm_QRCode_Geolocation()
        {
            InitializeComponent();
        }

        private void Btn_Generate_QRCode_Geo_01_Click(object sender, EventArgs e)
        {
            geo[0] = Txt_Latitude.Text;
            geo[1] = Txt_Longitude.Text;

            var smsData = $"geo:{geo[0]},{geo[1]}";

            QRConfig config = uC_QRConfig6.GetConfig();
            string strData = WebUtility.UrlEncode(smsData);//transforma o conteudo digitado em uma string valida.

            _format = config.Format;

            _imgQrcode = new GoQRCode().GetQRCode(strData, config);

            if (_imgQrcode != null)
            {
                Pic_Image_QRCodeGeo.BackgroundImage = _imgQrcode;
                Pic_Image_QRCodeGeo.BackgroundImageLayout = ImageLayout.Stretch;
                Btn_Generate_Save_QRCode_Geo_03.Enabled = true;
            }
        }

        private void Btn_Generate_Save_QRCode_Geo_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Btn_Generate_Clean_QRCode_Geo_02_Click(object sender, EventArgs e)
        {
            Btn_Generate_Save_QRCode_Geo_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;

            Pic_Image_QRCodeGeo.BackgroundImage = null;
            uC_QRConfig6.SetDefaultOptions();
        }

        private void Frm_QRCode_Geolocation_Load(object sender, EventArgs e)
        {
            Btn_Generate_Clean_QRCode_Geo_02_Click(Btn_Generate_Clean_QRCode_Geo_02, new EventArgs());
        }
    }
}
