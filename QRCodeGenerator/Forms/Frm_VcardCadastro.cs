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
    public partial class Frm_VcardCadastro : Form
    {
        public Vcard cartaoPreenchido { get; set; }
        public Frm_VcardCadastro()
        {
            InitializeComponent();
        }
        private void Btn_OK_vcardForm_Click(object sender, EventArgs e)
        {
            var cartao = new Vcard();
            cartao.Nome_vcard = Txt_Nome_vcard.Text;
            cartao.Sobrenome_vcard = Txt_Sobrenome_vcard.Text;
            cartao.Titulo_vcard = Txt_Titulo_vcard.Text;
            cartao.Rua_vcard = Txt_Rua_vcard.Text;
            cartao.Cep_vcard = Txt_Cep_vcard.Text;
            cartao.Cidade_vcard = Txt_Cidade_vcard.Text;
            cartao.Pais_vcard = Txt_Pais_vcard.Text;
            cartao.Empresa_vcard = Txt_Empresa_vcard.Text;
            cartao.Email_vcard = Txt_Email_vcard.Text;
            cartao.Email_empresa_vcard = Txt_EmailEmpresa_vcard.Text;
            cartao.Telefone_vcard = Txt_TelefonePessoal_vcard.Text;
            cartao.Celular_vcard = Txt_Celular_vcard.Text;
            cartao.TelefoneEmpresa_vcard = Txt_TelefoneEmpresa_vcard.Text;
            cartao.Site_vcard = Txt_Site_vcard.Text;
            cartaoPreenchido = cartao;
            Close();
        }
    }
}
