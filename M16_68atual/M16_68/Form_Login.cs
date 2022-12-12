using System;
using System.Windows.Forms;

using DAL;

namespace M16_68
{
	public partial class Form_Login : Form
	{
		private static Form_Login Instance;

		public static Form_Login GetInstace(Form previousForm)
		{
			PreviousForm = previousForm;
			return Instance ?? new Form_Login();
		}

		private static Form PreviousForm;

		private Form_Login()
		{
			Instance = this;
			InitializeComponent();
			FormClosing += new FormClosingEventHandler((s, e) =>
			{
				PreviousForm?.Show();
				Instance = null;
			});
		}

		private void cb_pass_CheckedChanged(object sender, EventArgs e)
		{
			txt_pass.UseSystemPasswordChar = !cb_pass.Checked;
		}

		private void btn_login_Click(object sender, EventArgs e)
		{

			Tuple<CommandResult, AccountType?> result = Database.GetInstance().Login(txt_user.Text, txt_pass.Text);
			if (result.Item1 == CommandResult.Error)
			{
				MessageBox.Show("Ocorreu um problema no login.");
				return;
			}
			else if (result.Item1 == CommandResult.Failed)
			{
				MessageBox.Show("Dados de login incorretos.");
				return;
			}

			if (result.Item2 == AccountType.User)
			{
				Form_Consulta.GetInstance(this).Show();
				Hide();
			}
			else
			{
				Form_Adm.GetInstance(this).Show();
				Hide();
			}
		}

		private void btn_register_Click(object sender, EventArgs e)
		{
			Form_Register.GetInstance(this).Show();
		}
	}
}
