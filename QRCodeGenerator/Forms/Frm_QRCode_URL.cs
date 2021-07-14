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
    public partial class Frm_QRCode_URL : Form
    {
        private Image _imgQrcode;
        private string _format;
        public Frm_QRCode_URL()
        {
            InitializeComponent();            
        }

        private void Btn_Generate_QRCode_URL_01_Click(object sender, EventArgs e)
        {
            if (Txt_URL.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe um valor para o campo de URI!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Txt_URL.Text.Trim().Contains("http://") || Txt_URL.Text.Trim().Contains("https://"))
            {
                QRConfig config = uC_QRConfig1.GetConfig();

                string strData = WebUtility.UrlEncode(Txt_URL.Text.Trim());//transforma o conteudo digitado em uma url valida.

                _format = config.Format;

                _imgQrcode = new GoQRCode().GetQRCode(strData, config);

                if (_imgQrcode != null)
                {
                    Pic_Image_QRCodeURL.BackgroundImage = _imgQrcode;
                    Pic_Image_QRCodeURL.BackgroundImageLayout = ImageLayout.Stretch;
                    Btn_GenerateSave_QRCode_URL_03.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("URI em formato invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Btn_GenerateClean_QRCode_URL_02_Click(object sender, EventArgs e)
        {
            Btn_GenerateSave_QRCode_URL_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;
            Txt_URL.Text = string.Empty;
            Pic_Image_QRCodeURL.BackgroundImage = null;            
            uC_QRConfig1.SetDefaultOptions();
        }

        private void Btn_GenerateSave_QRCode_URL_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Frm_QRCode_URL_Load(object sender, EventArgs e) //ação que executa depois do form pai ser carregado por completo.
        {
            Btn_GenerateClean_QRCode_URL_02_Click(Btn_GenerateClean_QRCode_URL_02, new EventArgs());
        }
    }
}
