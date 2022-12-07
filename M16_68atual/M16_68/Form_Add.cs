using System;
using System.Windows.Forms;

namespace M16_68
{
	public partial class Form_Add : Form
	{
		private static Form_Add Instance;

		public static Form_Add GetInstance()
		{
			return Instance ?? new Form_Add();
		}

		public Form_Add()
		{
			Instance = this;
			InitializeComponent();
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{

		}
	}
}
