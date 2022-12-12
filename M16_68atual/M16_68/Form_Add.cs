using System;
using System.Windows.Forms;

namespace M16_68
{
	public partial class Form_Add : Form
	{
		private static Form_Add Instance;

		public static Form_Add GetInstance(Form previousForm)
		{
			PreviousForm = previousForm;
			return Instance ?? new Form_Add();
		}

		private static Form PreviousForm;

		private Form_Add()
		{
			Instance = this;
			InitializeComponent();
			FormClosing += new FormClosingEventHandler((s, e) =>
			{
				PreviousForm?.Show();
				Instance = null;
			});
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
