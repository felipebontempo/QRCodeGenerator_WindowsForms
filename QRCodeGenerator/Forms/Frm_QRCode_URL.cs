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
        public Frm_QRCode_URL()
        {
            InitializeComponent();
        }

        private void Btn_Generate_QRCode_URL_01_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GenerateClean_QRCode_URL_02_Click(object sender, EventArgs e)
        {
            Txt_URL.Text = string.Empty;
            Pic_Image_QRCodeURL.BackgroundImage = null;
            var F = new UC_QRConfig();
            F.SetDefaultOptions();
        }

        private void Btn_GenerateSave_QRCode_URL_03_Click(object sender, EventArgs e)
        {

        }
    }
}
