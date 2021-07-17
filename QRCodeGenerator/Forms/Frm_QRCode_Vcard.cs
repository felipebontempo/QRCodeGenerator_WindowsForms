using Entities.Configurations;
using GoQR.Net;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace QRCodeGenerator.Forms
{
    public partial class Frm_QRCode_Vcard : Form
    {
        private Image _imgQrcode;
        private string _format;
        public Vcard destino { get; set; }
        public Frm_QRCode_Vcard()
        {
            InitializeComponent();
        }

        private void Btn_FormContato_Click(object sender, EventArgs e)
        {
            Frm_VcardCadastro FForm = new Frm_VcardCadastro();
            FForm.ShowDialog();
                        
            destino = FForm.cartaoPreenchido;
            //Debug.WriteLine(FForm.cartaoPreenchido.Nome_vcard);
        }

        private void Btn_Generate_QRCode_Vcard_01_Click(object sender, EventArgs e)
        {   
            string VcardString = 
                $"BEGIN:VCARD \n" +
                $"VERSION:2.1" +
                $"FN:{destino.Nome_vcard} {destino.Sobrenome_vcard} \n" +
                $"N:{destino.Sobrenome_vcard};{destino.Nome_vcard} \n" +
                $"TITLE:{destino.Titulo_vcard} \n" +
                $"TEL;CELL:{destino.Telefone_vcard} \n" +
                $"TEL;WORK;VOICE:{destino.TelefoneEmpresa_vcard} \n" +
                $"TEL;HOME;VOICE:{destino.TelefoneEmpresa_vcard} \n" +
                $"EMAIL;HOME;INTERNET:{destino.Email_vcard} \n" +
                $"EMAIL;WORK;INTERNET:{destino.Email_empresa_vcard} \n" +
                $"URL:{destino.Site_vcard} \n" +
                $"ADR:;;{destino.Rua_vcard};{destino.Cidade_vcard};;{destino.Cep_vcard};{destino.Pais_vcard} \n" +
                $"ORG:{destino.Empresa_vcard} \n" +
                $"END:VCARD";
            
            QRConfig config = uC_QRConfig3.GetConfig();
            string strData = WebUtility.UrlEncode(VcardString);//transforma o conteudo digitado em uma string valida.
            _format = config.Format;

            _imgQrcode = new GoQRCode().GetQRCode(strData, config);

            if (_imgQrcode != null)
            {
                Pic_Image_QRCodeURL.BackgroundImage = _imgQrcode;
                Pic_Image_QRCodeURL.BackgroundImageLayout = ImageLayout.Stretch;
                Btn_GenerateSave_QRCode_Vcard_03.Enabled = true;
            }
        }

        private void Btn_GenerateClean_QRCode_Vcard_02_Click(object sender, EventArgs e)
        {
            Btn_GenerateSave_QRCode_Vcard_03.Enabled = false;
            _format = string.Empty;
            _imgQrcode = null;
            
            Pic_Image_QRCodeURL.BackgroundImage = null;
            uC_QRConfig3.SetDefaultOptions();
        }

        private void Btn_GenerateSave_QRCode_Vcard_03_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQrcode, _format);
        }

        private void Frm_QRCode_Vcard_Load(object sender, EventArgs e)
        {
            Btn_GenerateClean_QRCode_Vcard_02_Click(Btn_GenerateClean_QRCode_Vcard_02, new EventArgs());
        }
    }
}
