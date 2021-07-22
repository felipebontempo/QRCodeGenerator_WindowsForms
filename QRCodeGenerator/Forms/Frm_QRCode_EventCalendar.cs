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
    public partial class Frm_QRCode_EventCalendar : Form
    {
        string[] evento = new string[5];
        private Image _imgQrcode;
        private string _format;
        public Frm_QRCode_EventCalendar()
        {
            InitializeComponent();
        }

        private void Btn_CriarEvento_Click(object sender, EventArgs e)
        {
            Frm_EventCadastro FForm = new Frm_EventCadastro();
            FForm.ShowDialog();
            for (int i = 0; i < FForm.dadosEvento.Length; i++)
            {
                evento[i] = FForm.dadosEvento[i];
            }
        }

        private void Btn_Generate_QRCode_Text_01_Click(object sender, EventArgs e)
        {
            //var smsData = $"geo:{geo[0]},{geo[1]}"; //DTSTART:20210803T191200Z
            string eventoData =
                $"BEGIN:VEVENT \n" +
                $"SUMMARY:{evento[0]} \n" +
                $"DTSTART:{evento[1]}T{evento[3]}Z \n" +
                $"DTEND:{evento[2]}T{evento[4]}Z \n" +
                $"END:VEVENT \n";

            QRConfig config = uC_QRConfig7.GetConfig();
            string strData = WebUtility.UrlEncode(eventoData);//transforma o conteudo digitado em uma string valida.

            _format = config.Format;

            _imgQrcode = new GoQRCode().GetQRCode(strData, config);

            if (_imgQrcode != null)
            {
                Pic_Image_QRCodeCal.BackgroundImage = _imgQrcode;
                Pic_Image_QRCodeCal.BackgroundImageLayout = ImageLayout.Stretch;
                Btn_Generate_Save_QRCode_Calendar_03.Enabled = true;
            }
        }

        private void Btn_Generate_Clean_QRCode_Calendar_02_Click(object sender, EventArgs e)
        {
            Btn_Generate_Save_QRCode_Calendar_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;

            Pic_Image_QRCodeCal.BackgroundImage = null;
            uC_QRConfig7.SetDefaultOptions();
        }

        private void Btn_Generate_Save_QRCode_Calendar_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Frm_QRCode_EventCalendar_Load(object sender, EventArgs e)
        {
            Btn_Generate_Clean_QRCode_Calendar_02_Click(Btn_Generate_Clean_QRCode_Calendar_02, new EventArgs());
        }
    }
}
