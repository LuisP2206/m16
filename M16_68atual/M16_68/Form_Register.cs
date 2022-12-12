using System;
using System.Windows.Forms;

using DAL;
using DAL.Schemas;

namespace M16_68
{
	public partial class Form_Register : Form
	{
		private static Form_Register Instance;

		public static Form_Register GetInstance(Form previousForm)
		{
			PreviousForm = previousForm;
			return Instance ?? new Form_Register();
		}

		private static Form PreviousForm;

		private Form_Register()
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

		private void btn_back_Click(object sender, EventArgs e)
		{
			Close();
			Form_Login.GetInstace(this).Show();
		}

		private void btn_regis_Click(object sender, EventArgs e)
		{
			Colecionador colecionador = new Colecionador(txt_bi.Text, txt_nome.Text, txt_morada.Text, txt_mail.Text, txt_tel.Text, txt_local.Text, txt_user.Text, txt_pass.Text, AccountType.User);
			CommandResult result = Database.GetInstance().RegistarUtilizador(colecionador);
			if (result == CommandResult.Error)
			{
				MessageBox.Show("Ocorreu um problema ao registar o utilizador.");
				return;
			}
			MessageBox.Show("Utilizador registado com sucesso.");
		}

		private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}
	}
}
