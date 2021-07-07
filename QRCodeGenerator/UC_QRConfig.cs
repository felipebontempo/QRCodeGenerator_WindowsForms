using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class UC_QRConfig : UserControl
    {
        public UC_QRConfig()
        {
            InitializeComponent();
        }

        private void UC_QRConfig_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            //size
            CMB_Size.Items.Clear();
            for (int i = 1; i <= 10; i++)
                CMB_Size.Items.Add(string.Format("{0}x{0}", i*100)); //oia que legal, o string.Format recebe o formato de exibicao, onde cada cahaves com 0  é ref ao primeiro item depois da virgula, se quiser ixibir mais intes, pode-se adicionar mais chaves com o valor 1 dentro por exemplo e adicionar mais uma virgula indicando que o valor de {1}, da hora!

            //Charset-source
            CMB_CharsetSource.Items.Clear();
            CMB_CharsetSource.Items.Add("ISO-8859-1");
            CMB_CharsetSource.Items.Add("UTF-8");

            //Charset-target
            CMB_CharsetTarget.Items.Clear();
            CMB_CharsetTarget.Items.Add("ISO-8859-1");
            CMB_CharsetTarget.Items.Add("UTF-8");

            //ECC
            CMB_ECC.Items.Clear();
            CMB_ECC.Items.Add("L");
            CMB_ECC.Items.Add("M");
            CMB_ECC.Items.Add("Q");
            CMB_ECC.Items.Add("H");

            //Color
            CMB_Color.Items.Clear();
            CMB_Color.Items.Add("000000"); //Preto
            CMB_Color.Items.Add("00FFFF");

            //BG Color
            CMB_BGColor.Items.Clear();
            CMB_BGColor.Items.Add("FFFFFF"); //Branco
            CMB_BGColor.Items.Add("000000");
            CMB_BGColor.Items.Add("00FFFF");

            //margin
            CMB_Margin.Items.Clear();
            for (int i = 0; i < 50; i++)
                CMB_Margin.Items.Add(i);

            //QZone
            CMB_QZone.Items.Clear();
            for (int i = 0; i < 100; i++)
                CMB_QZone.Items.Add(i);

            //format
            CMB_Format.Items.Clear();
            CMB_Format.Items.Add("png");
            CMB_Format.Items.Add("gif");
            CMB_Format.Items.Add("jpeg");
            CMB_Format.Items.Add("jpg");

            SetDefaultOptions();
        }
        public void SetDefaultOptions()
        {
            //valor padrões que será carregado quando o sistema é iniciado, nos respesctivos comboboxs.
            CMB_Size.SelectedIndex = 1;
            CMB_CharsetSource.SelectedIndex = 1;
            CMB_CharsetTarget.SelectedIndex = 1;
            CMB_ECC.SelectedIndex = 0;
            CMB_Color.SelectedIndex = 0;
            CMB_BGColor.SelectedIndex = 0;
            CMB_Margin.SelectedIndex = 1;
            CMB_QZone.SelectedIndex = 0;
            CMB_Format.SelectedIndex = 0;
        }
    }
}
