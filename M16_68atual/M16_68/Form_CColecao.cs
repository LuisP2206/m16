using System;
using System.Windows.Forms;

namespace M16_68
{
	public partial class Form_CColecao : Form
	{
		private static Form_CColecao Instance;

		public static Form_CColecao GetInstance()
		{
			return Instance ?? new Form_CColecao();
		}

		public Form_CColecao()
		{
			Instance = this;
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
