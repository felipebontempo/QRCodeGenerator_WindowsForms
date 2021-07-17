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
    public partial class Frm_QRCode_Call : Form
    {
        private Image _imgQrcode;
        private string _format;
        string[] novoTelefonePrenchido = new string[3];
        public Frm_QRCode_Call()
        {
            InitializeComponent();
        }

        private void Btn_Generate_QRCode_Call_01_Click(object sender, EventArgs e)
        {
            novoTelefonePrenchido[0] = Txt_CodPais.Text;
            novoTelefonePrenchido[1] = Txt_CodArea.Text;
            novoTelefonePrenchido[2] = Txt_NumCall.Text;

            var smsData = $"tel:{novoTelefonePrenchido[0]}{novoTelefonePrenchido[1]}{novoTelefonePrenchido[2]}";

            QRConfig config = uC_QRConfig5.GetConfig();
            string strData = WebUtility.UrlEncode(smsData);//transforma o conteudo digitado em uma string valida.

            _format = config.Format;

            _imgQrcode = new GoQRCode().GetQRCode(strData, config);

            if (_imgQrcode != null)
            {
                Pic_Image_QRCodeCall.BackgroundImage = _imgQrcode;
                Pic_Image_QRCodeCall.BackgroundImageLayout = ImageLayout.Stretch;
                Btn_Generate_Save_QRCode_Call_03.Enabled = true;
            }
        }
        private void Btn_Generate_Save_QRCode_Call_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }
        private void Btn_Generate_Clean_QRCode_Call_02_Click(object sender, EventArgs e)
        {
            Btn_Generate_Save_QRCode_Call_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;

            Pic_Image_QRCodeCall.BackgroundImage = null;
            uC_QRConfig5.SetDefaultOptions();
        }

        private void Frm_QRCode_Call_Load(object sender, EventArgs e)
        {
            Btn_Generate_Clean_QRCode_Call_02_Click(Btn_Generate_Clean_QRCode_Call_02, new EventArgs());
        }
    }
}
