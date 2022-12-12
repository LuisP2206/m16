using System;
using System.Windows.Forms;

namespace M16_68
{
	public partial class Form_Adm : Form
	{
		private static Form_Adm Instance;

		public static Form_Adm GetInstance()
		{
			return Instance ?? new Form_Adm();
		}

		public Form_Adm()
		{
			Instance = this;
			InitializeComponent();
		}

		private void btnC_eventos_Click(object sender, EventArgs e)
		{

		}

		private void adicionarMoedaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_AddMo admo = new Form_AddMo();
			admo.ShowDialog();
		}
	}
}
