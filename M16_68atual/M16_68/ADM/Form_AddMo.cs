using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

using DAL;
using DAL.Schemas;

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
			Close();
		}

		private void btn_browse_Click(object sender, EventArgs e)
		{
			Stream myStream;
			SaveFileDialog fd = new SaveFileDialog
			{
				Filter = "Bmp(*.BMP;)|*.BMP;| Jpg(*Jpg)|*.jpg| Png(*.Png;)|*.Png",
				AddExtension = true
			};
			if (fd.ShowDialog() == DialogResult.OK)
			{
				switch (Path.GetExtension(fd.FileName).ToUpper())
				{
					case ".BMP":
						pictureBox1.Image.Save(fd.FileName, ImageFormat.Bmp);
						break;
					case ".JPG":
						pictureBox1.Image.Save(fd.FileName, ImageFormat.Jpeg);
						break;
					case ".PNG":
						pictureBox1.Image.Save(fd.FileName, ImageFormat.Png);
						break;
					default:
						break;
				}
				if ((myStream = fd.OpenFile()) != null)
				{
					// guardar na bd num campo de texto com tamanho de mais ou menos 10-20 milhoes de caracteres (long text)
					myStream.Close();
				}
			}
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			string imagemBase64 = Utils.ImagemParaBase64(pictureBox1.Image);
			// TODO: Meter o id do evento selecionado de uma combobox com todos os eventos no ultimo parametro da linha debaixo
			Moeda moeda = new Moeda(txt_nome.Text, Convert.ToDouble(txt_val.Text), Convert.ToInt32(txt_peso.Text), txt_met.Text, Convert.ToInt32(txt_dimen.Text), Convert.ToInt64(txt_data.Text), txt_criador.Text, imagemBase64, 0);
			CommandResult result = Database.GetInstance().RegistarMoeda(moeda);
			if (result == CommandResult.Error)
			{
				MessageBox.Show("Ocorreu um problema ao registar a nova moeda.");
			}
		}
	}
}
