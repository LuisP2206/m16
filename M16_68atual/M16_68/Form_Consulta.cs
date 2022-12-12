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

		public static Form_Consulta GetInstance()
		{
			return Instance ?? new Form_Consulta();
		}

		public Form_Consulta()
		{
			Instance = this;
			InitializeComponent();
		}

		private void Form_Consulta_Load(object sender, EventArgs e)
		{
			Tuple<CommandResult, List<Evento>> resultEventos = Database.GetInstance().SelecionarEventos();
			if (resultEventos.Item1 != CommandResult.Success)
			{
				Close();
				MessageBox.Show("Ocorreu um problema ao obter os eventos.");
			}
			Utils.Bind(cbC_eventos, resultEventos.Item1, nameof(Evento.Nome), nameof(Evento.Id));

			Tuple<CommandResult, List<Colecao>> resultColecoes = Database.GetInstance().SelecionarColecoesDoColecionador(LoginInfo.CurrentUserId);
			if (resultColecoes.Item1 != CommandResult.Success)
			{
				Close();
				MessageBox.Show("Ocorreu um problema ao obter as coleções.");
			}
			Utils.Bind(cbC_colecao, resultColecoes.Item2, nameof(Colecao.Nome), nameof(Colecao.Id));

			Tuple<CommandResult, List<Moeda>> resultMoedas = Database.GetInstance().SelecionarMoedasDoColecionador(LoginInfo.CurrentUserId);
			if (resultColecoes.Item1 != CommandResult.Success)
			{
				Close();
				MessageBox.Show("Ocorreu um problema ao obter as moedas.");
			}
			Utils.Bind(cbC_moeda, resultMoedas.Item2, nameof(Moeda.Nome), nameof(Moeda.Id));
		}

		private void btnC_eventos_Click(object sender, EventArgs e)
		{
			Form_CEventos.GetInstance().Show();
		}

		private void btnC_colecao_Click(object sender, EventArgs e)
		{
			Form_CColecao.GetInstance().Show();
		}

		private void btnC_moedas_Click(object sender, EventArgs e)
		{
			Form_CMoedas.GetInstance().Show();
		}

		private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
			/*SqlCommand add = new SqlCommand(@"Insert into Acessos(Hora_fim,Observacoes) values())", ConString.con);*/
		}

		private void suasMoedasToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Form_MinhaC.GetInstance().Show();
			Hide();
		}

		private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Add.GetInstance().Show();
		}

		private void suasMoedasToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
