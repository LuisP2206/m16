using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DAL;
using DAL.Schemas;

namespace M16_68
{
	public partial class Form_Adm : Form
	{
		private static Form_Adm Instance;

		public static Form_Adm GetInstance(Form previousForm)
		{
			PreviousForm = previousForm;
			return Instance ?? new Form_Adm();
		}

		private static Form PreviousForm;

		public Form_Adm()
		{
			Instance = this;
			InitializeComponent();
			FormClosing += new FormClosingEventHandler((s, e) =>
			{
				PreviousForm?.Show();
				Instance = null;
			});
		}

		private void btnC_eventos_Click(object sender, EventArgs e)
		{
			try
			{
				Form_CEventos.GetInstance(this, (int)cbC_eventos.SelectedValue).Show();
			}
			catch { }
		}

		private void adicionarMoedaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_AddMo.GetInstance(this).Show();
		}

		private void Form_Adm_Load(object sender, EventArgs e)
		{
			Tuple<CommandResult, List<Evento>> resultEventos = Database.GetInstance().SelecionarEventos();
			if (resultEventos.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter os eventos.");
				Close();
				return;
			}
			Tuple<CommandResult, List<Colecao>> resultColecoes = Database.GetInstance().SelecionarColecoes();
			if (resultColecoes.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter as coleções.");
				Close();
				return;
			}
			Tuple<CommandResult, List<Moeda>> resultMoedas = Database.GetInstance().SelecionarMoedas();
			if (resultMoedas.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter as moedas.");
				Close();
				return;
			}
			Utils.Bind(cbC_eventos, resultEventos.Item2, "Nome", "Id");
			Utils.Bind(cbC_colecao, resultColecoes.Item2, "Nome", "Id");
			Utils.Bind(cbC_moeda, resultMoedas.Item2, "Nome", "Id");
		}

		private void btnC_colecao_Click(object sender, EventArgs e)
		{
			try
			{
				Form_CColecao.GetInstance(this, (int)cbC_colecao.SelectedValue).Show();
				Close();
			}
			catch { }
		}

		private void btnC_moedas_Click(object sender, EventArgs e)
		{
			try
			{
				Form_CMoedas.GetInstance(this, (int)cbC_moeda.SelectedValue).Show();
			}
			catch { }
		}
	}
}
