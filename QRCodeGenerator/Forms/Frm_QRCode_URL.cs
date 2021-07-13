using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Btn_GenerateClean_QRCode_URL_02_Click(Btn_GenerateClean_QRCode_URL_02, new EventArgs());
        }

        private void Btn_Generate_QRCode_URL_01_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GenerateClean_QRCode_URL_02_Click(object sender, EventArgs e)
        {
            _format = string.Empty;
            _imgQrcode = null;
            Txt_URL.Text = string.Empty;
            Pic_Image_QRCodeURL.BackgroundImage = null;
            /*O botão Clean, para limpar formulário não funciona, porque estou tentando chamar uma função em um form User Control, não consegui fazer funcionar, por isso criei uma botão a parte.*/
            //UC_QRConfig.SetDefaultOptions(); ta dando ruim
        }

        private void Btn_GenerateSave_QRCode_URL_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }
    }
}
