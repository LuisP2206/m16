using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DAL;
using DAL.Schemas;

namespace M16_68
{
	public partial class Form_MinhaC : Form
	{
		private static Form_MinhaC Instance;

		public static Form_MinhaC GetInstance()
		{
			return Instance ?? new Form_MinhaC();
		}

		private readonly List<Colecao> colecoes = new List<Colecao>();

		public Form_MinhaC()
		{
			Instance = this;
			InitializeComponent();
		}

		private void Form_MinhaC_Load(object sender, EventArgs e)
		{
			Tuple<CommandResult, List<int>> result = Database.GetInstance().SelecionarColecoesDoColecionador(LoginInfo.CurrentUserId);
			if (result.Item1 == CommandResult.Error)
			{
				MessageBox.Show("Ocorreu um problema ao carregar as coleções.");
				return;
			}
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
