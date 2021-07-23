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
    public partial class Frm_EmailCadastro : Form
    {
        public string[] email = new string[3];
        public Frm_EmailCadastro()
        {
            InitializeComponent();
        }

        private void Btn_EmailOK_Click(object sender, EventArgs e)
        {
            email[0] = Txt_EmailDest.Text;
            email[1] = Txt_EmailAssunto.Text;
            email[2] = Txt_EmailConteudo.Text;
            Close();
        }
    }
}
