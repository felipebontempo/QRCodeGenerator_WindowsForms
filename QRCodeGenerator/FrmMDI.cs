using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeGenerator.Forms;

namespace QRCodeGenerator
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(Form oFrm)
        {
            oFrm.MdiParent = this; //o formulario que passar como param será inserido como filho desde que estou no caso o 'FrmMDI.cs'
            oFrm.Top = 0; //o local onde ele será inserido, apartir do pixel ZERO!, no TOPO!!! 
            //oFrm.Left = 0;//o local onde ele será inserido, apartir do pixel ZERO!, no canto ESQUERDO!!!
            //lembrando que temos um menu do lado esquerdo, logo é preciso calcular o tamanho correto para que o form não fica embaixo do menu, mas tudo bem, é só arrastar do mesmo.
            oFrm.Left = Pnl_Menu.Size.Width;
            oFrm.Show();
        }

        private void Btn_UrlType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_QRCode_URL());
        }

        private void Btn_TextType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_QRCode_Text());
        }

        private void Btn_vCardType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_QRCode_Vcard());
        }

        private void Btn_SMSType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_QRCode_Sms());
        }

        private void Btn_CallType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_QRCode_Call());
        }

        private void Btn_LocalizacaoType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_QRCode_Geolocation());
        }

        private void Btn_CalendarioType_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_QRCode_EventCalendar());
        }
    }
}
