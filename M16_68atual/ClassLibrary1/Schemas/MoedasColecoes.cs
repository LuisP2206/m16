namespace DAL.Schemas
{
	public class MoedasColecoes
	{
		/// <summary>Select</summary>
		public MoedasColecoes(int id, int idColecao, int idMoeda)
		{
			Id = id;
			IdColecao = idColecao;
			IdMoeda = idMoeda;
		}

		/// <summary>Insert</summary>
		public MoedasColecoes(int idColecao, int idMoeda)
		{

			IdColecao = IdColecao;
			IdMoeda = IdMoeda;
		}

		public int Id { get; set; }
		public int IdColecao { get; set; }
		public int IdMoeda { get; set; }
	}
}
