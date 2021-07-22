using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator.Forms
{
    public partial class Frm_EventCadastro : Form
    {
        public string[] dadosEvento = new string[5];
        public Frm_EventCadastro()
        {
            InitializeComponent();
        }

        private void Frm_EventCadastro_Load(object sender, EventArgs e)
        {            
            Cmb_TimeZone.Items.Add("GMT -12:00");
            Cmb_TimeZone.Items.Add("GMT -11:00");
            Cmb_TimeZone.Items.Add("GMT -10:00");
            Cmb_TimeZone.Items.Add("GMT -09:00");
            Cmb_TimeZone.Items.Add("GMT -08:00");
            Cmb_TimeZone.Items.Add("GMT -07:00");
            Cmb_TimeZone.Items.Add("GMT -06:00");
            Cmb_TimeZone.Items.Add("GMT -05:00");
            Cmb_TimeZone.Items.Add("GMT -04:00");
            Cmb_TimeZone.Items.Add("GMT -03:00");
            Cmb_TimeZone.Items.Add("GMT -02:00");
            Cmb_TimeZone.Items.Add("GMT -01:00");
            Cmb_TimeZone.Items.Add("GMT");
            Cmb_TimeZone.Items.Add("GMT +01:00");
            Cmb_TimeZone.Items.Add("GMT +02:00");
            Cmb_TimeZone.Items.Add("GMT +03:00");
            Cmb_TimeZone.Items.Add("GMT +04:00");
            Cmb_TimeZone.Items.Add("GMT +05:00");
            Cmb_TimeZone.Items.Add("GMT +06:00");
            Cmb_TimeZone.Items.Add("GMT +07:00");
            Cmb_TimeZone.Items.Add("GMT +08:00");
            Cmb_TimeZone.Items.Add("GMT +09:00");
            Cmb_TimeZone.Items.Add("GMT +10:00");
            Cmb_TimeZone.Items.Add("GMT +11:00");
            Cmb_TimeZone.Items.Add("GMT +12:00");

            
            Cmb_TimeZone.SelectedIndex = 12; //valor padrão GMT
        }

        private void Btn_OK_CriarEvento_Click(object sender, EventArgs e)
        {
            /*A API que gera o QRCODE contem falha na criação de QRCODE do tipo evento!, ao todo são 37 horários locais diferentes em uso, e no site está listado apenas 25, ou seja quando se escolhe o "-03:00" (timezone ref ao Brasil) o evento vem com hora errada.*/
            Debug.WriteLine("Zona selecionada " + Cmb_TimeZone.SelectedItem.ToString());
            dadosEvento[0] = Txt_DescricaoEvento.Text;   
            
            string[] DataInicio = Cal_InicioEvento.SelectionStart.ToString().Split(' ');
            //string[] DataInicioFatia = new string[8];
            string[] DataInicioFatia = DataInicio[0].Split('/');            
            string DataInicioFormat = DataInicioFatia[2] + DataInicioFatia[1] + DataInicioFatia[0];
            dadosEvento[1] = DataInicioFormat;


            string[] DataFinal = Cal_FinalEvento.SelectionStart.ToString().Split(' ');
            //string DataFinalFormat = DataFinal[0].Replace('/', ' ').Replace(" ", String.Empty);
            string[] DataFinalFatia = DataFinal[0].Split('/');
            string DataFinalFormat = DataFinalFatia[2] + DataFinalFatia[1] + DataFinalFatia[0]; 
            dadosEvento[2] = DataFinalFormat;

            var getHora_Inicio = dateTimePicker_InicioEvento.Value.Hour.ToString("D2");
            var getMinute_Inicio = dateTimePicker_InicioEvento.Value.Minute.ToString("D2");
            var getSecond_Inicio = dateTimePicker_InicioEvento.Value.Second.ToString("D2");
            var horaInicialEvento = getHora_Inicio + getMinute_Inicio + getSecond_Inicio;
            dadosEvento[3] = horaInicialEvento;

            var getHora_Final = dateTimePicker_FinalEvento.Value.Hour.ToString("D2");
            var getMinute_Final = dateTimePicker_FinalEvento.Value.Minute.ToString("D2");
            var getSecond_Final = dateTimePicker_FinalEvento.Value.Second.ToString("D2");
            var horaFinalEvento = getHora_Final + getMinute_Final + getSecond_Final;
            dadosEvento[4] = horaFinalEvento;
            
            Debug.WriteLine("Data inicial do evento: " + DataInicio[0]);
            Debug.WriteLine("Data inicial do evento: " + DataInicio[0]);
            Debug.WriteLine("Data final do evento: " + DataFinal[0]);
            Debug.WriteLine(getHora_Inicio + getMinute_Inicio + getSecond_Inicio);
            /*Data inicial do evento: 22/07/2021
            Data inicial do evento: 22/07/2021
            Data final do evento: 22/07/2021
            164835
            */
            Close();
        }
    }
}
