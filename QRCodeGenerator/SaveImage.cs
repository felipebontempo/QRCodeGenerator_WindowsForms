using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public static class SaveImage
    {
        public static void Save(Image imgQRCode, string format)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();//Abre a janela para salvar arquivos, tipo DialogModal

            //verifica o formato da imagem
            if (format.Equals("png"))
            {
                sfDialog.Filter = "PNG Image|*.png";//o formato precisa ser assim mesmo '"PNG Image|*.png"'
            }
            else if (format.Equals("gif"))
            {
                sfDialog.Filter = "GIF Image|*.gif";
            }
            else if (format.Equals("jpeg"))
            {
                sfDialog.Filter = "JPEG Image|*.jpeg";
            }
            else //JPG
            {
                sfDialog.Filter = "JPG Image|*.jpg";
            }
            /*o método '.Filter', é para mostrar somente os tipos de arquivos que estamos definindo.*/

            sfDialog.Title = "Save QRCode"; //nome da janela
            sfDialog.FileName = "QRCode"; //nome padrão do arquivo
            sfDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //Ao abrir a janela a mesma será aberta por padrão no desktop do usuário.
            sfDialog.ShowDialog(); //Exiba a janela!
        }
    }
}
