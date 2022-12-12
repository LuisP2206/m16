using System;
using System.Windows.Forms;

using DAL;

namespace M16_68
{
	public partial class Form_CMoedas : Form
	{
		private static Form_CMoedas Instance;

		public static Form_CMoedas GetInstance(int idMoeda)
		{
			Form_CMoedas instance = Instance ?? new Form_CMoedas();

			instance.CarregarMoeda(idMoeda);

			return instance;
		}

		private Form_CMoedas()
		{
			Instance = this;
			InitializeComponent();
		}

		private void CarregarMoeda(int idMoeda)
		{
			Tuple<CommandResult, DAL.Schemas.Moeda> resultMoeda = Database.GetInstance().SelecionarMoeda(idMoeda);
			if (resultMoeda.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter a moeda.");
				Close();
			}
			Tuple<CommandResult, DAL.Schemas.Evento> resultEvento = Database.GetInstance().SelecionarEvento(resultMoeda.Item2.IdEvento);
			if (resultEvento.Item1 != CommandResult.Success)
			{
				MessageBox.Show("Ocorreu um problema ao obter o evento da moeda.");
				Close();
			}
			txt_nome.Text = resultMoeda.Item2.Nome;
			txt_val.Text = resultMoeda.Item2.Valor.ToString();
			txt_peso.Text = resultMoeda.Item2.Peso.ToString();
			txt_mat.Text = resultMoeda.Item2.Material;
			txt_dim.Text = resultMoeda.Item2.Diametro.ToString();
			txt_datalac.Text = Utils.UnixToDate(resultMoeda.Item2.DataLancamento).ToString();
			txt_evento.Text = resultEvento.Item2.Nome;
			txt_criador.Text = resultMoeda.Item2.Artista;
		}
	}
}
