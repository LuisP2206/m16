using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DAL;
using DAL.Schemas;

namespace M16_68
{
	public partial class Form_Consulta : Form
	{
		private static Form_Consulta Instance;

		public static Form_Consulta GetInstance(Form previousForm)
		{
			PreviousForm = previousForm;
			return Instance ?? new Form_Consulta();
		}

		private static Form PreviousForm;

		private Form_Consulta()
		{
			Instance = this;
			InitializeComponent();
			FormClosing += new FormClosingEventHandler((s, e) =>
			{
				PreviousForm?.Show();
				Instance = null;
			});
		}

		private void Form_Consulta_Load(object sender, EventArgs e)
		{
			Tuple<CommandResult, List<Evento>> resultEventos = Database.GetInstance().SelecionarEventos();
			if (resultEventos.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter os eventos.");
				Close();
				return;
			}
			Utils.Bind(cbC_eventos, resultEventos.Item2, nameof(Evento.Nome), nameof(Evento.Id));

			Tuple<CommandResult, List<Colecao>> resultColecoes = Database.GetInstance().SelecionarColecoesDoColecionador(LoginInfo.CurrentUserId);
			if (resultColecoes.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter as coleções.");
				Close();
				return;
			}
			Utils.Bind(cbC_colecao, resultColecoes.Item2, nameof(Colecao.Nome), nameof(Colecao.Id));

			Tuple<CommandResult, List<Moeda>> resultMoedas = Database.GetInstance().SelecionarMoedasDoColecionador(LoginInfo.CurrentUserId);
			if (resultColecoes.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter as moedas.");
				Close();
				return;
			}
			Utils.Bind(cbC_moeda, resultMoedas.Item2, nameof(Moeda.Nome), nameof(Moeda.Id));
		}

		private void btnC_eventos_Click(object sender, EventArgs e)
		{
			try
			{
				Form_CEventos.GetInstance(this, (int)cbC_eventos.SelectedValue).Show();
			}
			catch { }
		}

		private void btnC_colecao_Click(object sender, EventArgs e)
		{
			try
			{
				Form_CColecao.GetInstance(this, (int)cbC_colecao.SelectedValue).Show();
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

		private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
			/*SqlCommand add = new SqlCommand(@"Insert into Acessos(Hora_fim,Observacoes) values())", ConString.con);*/
		}

		private void suasMoedasToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				Form_MinhaC.GetInstance(this, LoginInfo.CurrentUserId).Show();
				Close();
			}
			catch { }
		}

		private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Add.GetInstance(this).Show();
		}

		private void suasMoedasToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
