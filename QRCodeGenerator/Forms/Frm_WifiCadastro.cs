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
    public partial class Frm_WifiCadastro : Form
    {
        public string[] wifi = new string[4];
        public Frm_WifiCadastro()
        {
            InitializeComponent();
            Cmb_Wifi_cryption.Items.Add("WPA");
            Cmb_Wifi_cryption.Items.Add("WEP");
            Cmb_Wifi_cryption.Items.Add("Sem criptografia");
        }

        private void Btn_Wifi_OK_Click(object sender, EventArgs e)
        {
            wifi[0] = Cmb_Wifi_cryption.SelectedItem.ToString();
            wifi[1] = Txt_Wifi_SSID.Text;
            wifi[2] = Txt_Wifi_Pass.Text;
            if (Chk_Wifi_Hide.Checked)
            {
                wifi[3] = "H:true";
            }
            else
            {
                wifi[3] = "";
            }
            Close();
        }
    }
}
