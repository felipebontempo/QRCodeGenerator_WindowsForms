using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            
            sfDialog.ShowDialog(); //Exiba a janela!, para aguardar o usuário escolher nome e diretorio onde vai salvar o arquivo.

            //verifica se foi digitado um nome para o arquivo.
            if (!sfDialog.FileName.Equals(string.Empty))//se diferente de vazio, entra no IF
            {
                FileStream fs = (FileStream)sfDialog.OpenFile();//pego a referencia do arquivo selecionado

                if (format.Equals("png"))
                {
                    imgQRCode.Save(fs, ImageFormat.Png);
                }
                else if (format.Equals("gif"))
                {
                    imgQRCode.Save(fs, ImageFormat.Gif);
                }                
                else
                {
                    imgQRCode.Save(fs, ImageFormat.Jpeg);
                }

                fs.Close();
            }
        }
    }
}
