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
    public partial class Frm_QRCode_Text : Form
    {
        private Image _imgQrcode;
        private string _format;
        public Frm_QRCode_Text()
        {
            InitializeComponent();
        }

        private void Btn_GenerateClean_QRCode_Text_02_Click(object sender, EventArgs e)
        {
            Btn_GenerateSave_QRCode_Text_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;
            Txt_Texto.Text = string.Empty;
            Pic_Image_QRCodeText.BackgroundImage = null;
            uC_QRConfig2.SetDefaultOptions();
        }
        private void Btn_Generate_QRCode_Text_01_Click(object sender, EventArgs e)
        {
            if (Txt_Texto.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe um valor para o campo de URI!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRConfig config = uC_QRConfig2.GetConfig();

                string strData = WebUtility.UrlEncode(Txt_Texto.Text.Trim());//transforma o conteudo digitado em uma url valida.

                _format = config.Format;

                _imgQrcode = new GoQRCode().GetQRCode(strData, config);

                if (_imgQrcode != null)
                {
                    Pic_Image_QRCodeText.BackgroundImage = _imgQrcode;
                    Pic_Image_QRCodeText.BackgroundImageLayout = ImageLayout.Stretch;
                    Btn_GenerateSave_QRCode_Text_03.Enabled = true;
                }
            }
        }
        private void Btn_GenerateSave_QRCode_Text_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Frm_QRCode_Text_Load(object sender, EventArgs e)
        {
            Btn_GenerateClean_QRCode_Text_02_Click(Btn_GenerateClean_QRCode_Text_02, new EventArgs());
        }
    }
}
