using System;
using System.Windows.Forms;

using DAL;
using DAL.Schemas;

namespace M16_68
{
	public partial class Form_CEventos : Form
	{
		private static Form_CEventos Instance;

		public static Form_CEventos GetInstance(int idEvento)
		{
			Form_CEventos instance = Instance ?? new Form_CEventos();

			instance.CarregarEvento(idEvento);

			return instance;
		}

		private Form_CEventos()
		{
			Instance = this;
			InitializeComponent();
		}

		private void CarregarEvento(int idEvento)
		{
			Tuple<CommandResult, Evento> resultEvento = Database.GetInstance().SelecionarEvento(idEvento);
			if (resultEvento.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter o evento.");
				Close();
			}
			Tuple<CommandResult, System.Collections.Generic.List<Colecao>> resultColecoesDoEvento = Database.GetInstance().SelecionarColecoesDoEvento(idEvento);
			if (resultColecoesDoEvento.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter as coleções do evento.");
				Close();
			}
			textBox1.Text = resultEvento.Item2.Nome;
			txt_local.Text = resultEvento.Item2.Local;
			txt_dataI.Text = Utils.UnixToDate(resultEvento.Item2.DataInicio).ToString();
			txt_dataF.Text = Utils.UnixToDate(resultEvento.Item2.DataFim).ToString();
			txt_desc.Text = resultEvento.Item2.Descricao;
			foreach (Colecao colecao in resultColecoesDoEvento.Item2)
			{
				lv_eventos.Items.Add(colecao.Nome);
			}
		}

		private void Form_CEventos_Load(object sender, EventArgs e)
		{
		}

		private void lv_eventos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
