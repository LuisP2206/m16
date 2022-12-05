using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace M16_68
{
    public partial class Form_AddMo : Form
    {
        public Form_AddMo()
        {
            InitializeComponent();
        }

        private void Form_AddMo_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            Stream myStream;
            var fd = new SaveFileDialog();
            fd.Filter = "Bmp(*.BMP;)|*.BMP;| Jpg(*Jpg)|*.jpg| Png(*.Png;)|*.Png";
            fd.AddExtension = true;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (Path.GetExtension(fd.FileName).ToUpper())
                {
                    case ".BMP":
                        pictureBox1.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case ".JPG":
                        pictureBox1.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".PNG":
                        pictureBox1.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
                if ((myStream = fd.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

		private void btn_add_Click(object sender, EventArgs e)
		{
            string imagemBase64 = ImageToBase64(pictureBox1.Image);
            // guardar na bd num campo de texto com tamanho de mais ou menos 10-20 milhoes de caracteres (long text)
		}

		private static string ImageToBase64(Image image)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, image.RawFormat);
				return Convert.ToBase64String(ms.ToArray());
			}
		}

		private static Image Base64ToImage(string base64)
		{
			byte[] imageBytes = Convert.FromBase64String(base64);
			return new Bitmap(new MemoryStream(imageBytes));
		}
	}
}
