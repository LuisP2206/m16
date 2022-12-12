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

		public static Form_MinhaC GetInstance(int idColecionador)
		{
			Form_MinhaC instance = Instance ?? new Form_MinhaC();

			instance.CarregarColecoes(idColecionador);

			return instance;
		}

		public Form_MinhaC()
		{
			Instance = this;
			InitializeComponent();
		}

		private void CarregarColecoes(int idColecionador)
		{
			Tuple<CommandResult, List<Colecao>> resultColecoes = Database.GetInstance().SelecionarColecoesDoColecionador(idColecionador);
			if (resultColecoes.Item1 == CommandResult.Error)
			{
				MessageBox.Show("Ocorreu um problema ao carregar as coleções.");
				return;
			}
			foreach (Colecao colecao in resultColecoes.Item2)
			{
				lv_colecao.Items.Add(colecao.Nome);
			}
		}

		private void Form_MinhaC_Load(object sender, EventArgs e)
		{

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
