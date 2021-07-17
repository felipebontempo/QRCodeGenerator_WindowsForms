﻿using System;
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
    public partial class Frm_SmsCadastro : Form
    {
        public string[] novoSms = new string[4];
        public Frm_SmsCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novoSms[0] = Txt_SMS_CodigoPais.Text;
            novoSms[1] = Txt_SMS_CodigoArea.Text;
            novoSms[2] = Txt_SMS_NumeroTelefone.Text;
            novoSms[3] = Txt_SMS_Mensagem.Text;
            Close();
        }
    }
}
