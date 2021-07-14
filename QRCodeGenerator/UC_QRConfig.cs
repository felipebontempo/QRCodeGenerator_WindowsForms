using System;
using System.Windows.Forms;
using Entities.Configurations;
using System.Drawing;

namespace QRCodeGenerator
{
    public partial class UC_QRConfig : UserControl
    {
        string CorFundoQrCode = "";
        string CorQrCode = "";
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
            CorQrCode = "000000";

            //BG Color
            CorFundoQrCode = "FFFFFF";

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
            CMB_Margin.SelectedIndex = 1;
            CMB_QZone.SelectedIndex = 0;
            CMB_Format.SelectedIndex = 0;
        }
        public QRConfig GetConfig()
        {
            QRConfig config = new QRConfig();
            config.Size = CMB_Size.SelectedItem.ToString();
            config.CharsetSource = CMB_CharsetSource.SelectedItem.ToString();
            config.CharsetTarget = CMB_CharsetTarget.SelectedItem.ToString();
            config.ECC = CMB_ECC.SelectedItem.ToString()[0]; //a propriedade é do tipo char, e o ECC retorna string, para acessar um unico caractere seleciono como um array, que a conversão é feita sem problema.
            config.Color = CorQrCode;
            config.BGColor = CorFundoQrCode;//CMB_BGColor.SelectedItem.ToString();
            config.Margin = Convert.ToInt32(CMB_Margin.SelectedItem.ToString()); //O comboBox retorna uma string, por isso preciso fazer uma conversão.
            config.QZone = Convert.ToInt32(CMB_QZone.SelectedItem.ToString());
            config.Format = CMB_Format.SelectedItem.ToString();
            return config;
        }

        public void Btn_RedefinirConfig_Click(object sender, EventArgs e)
        {
            CMB_Size.SelectedIndex = 1;
            CMB_CharsetSource.SelectedIndex = 1;
            CMB_CharsetTarget.SelectedIndex = 1;
            CMB_ECC.SelectedIndex = 0;
            CMB_Margin.SelectedIndex = 1;
            CMB_QZone.SelectedIndex = 0;
            CMB_Format.SelectedIndex = 0;
        }        

        private void Btn_BGColor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {                
                Color myColor = CDb.Color;
                string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                CorFundoQrCode = hex;
            }
        }

        private void Btn_ColorQrcode_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                Color myColor = CDb.Color;
                string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                CorQrCode = hex;
            }
        }
    }
}