using System;
using System.Windows.Forms;

using DAL;
using DAL.Schemas;

namespace M16_68
{
	public partial class Form_CColecao : Form
	{
		private static Form_CColecao Instance;

		public static Form_CColecao GetInstance(Form previousForm, int idColecao)
		{
			PreviousForm = previousForm;

			Form_CColecao instance = Instance ?? new Form_CColecao();

			instance.CarregarColecao(idColecao);

			return instance;
		}

		private static Form PreviousForm;

		private Form_CColecao()
		{
			Instance = this;
			InitializeComponent();
			FormClosing += new FormClosingEventHandler((s, e) =>
			{
				PreviousForm?.Show();
				Instance = null;
			});
		}

		private void CarregarColecao(int idColecao)
		{
			Tuple<CommandResult, Colecao> resultColecao = Database.GetInstance().SelecionarColecao(idColecao);
			if (resultColecao.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter a coleção.");
				Close();
				return;
			}
			Tuple<CommandResult, Evento> resultEvento = Database.GetInstance().SelecionarEvento(resultColecao.Item2.IdEvento);
			if (resultEvento.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter o evento.");
				Close();
				return;
			}
			Tuple<CommandResult, System.Collections.Generic.List<Moeda>> resultMoedasColecao = Database.GetInstance().SelecionarMoedasDaColecao(idColecao);
			if (resultMoedasColecao.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter as moedas da coleção.");
				Close();
				return;
			}

			textBox1.Text = resultColecao.Item2.Nome;
			textBox2.Text = Utils.UnixToDate(resultColecao.Item2.DataCriacao).ToString();
			textBox3.Text = resultEvento.Item2.Nome;

			foreach (Moeda mc in resultMoedasColecao.Item2)
			{
				listBox1.Items.Add(mc.Nome);
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
