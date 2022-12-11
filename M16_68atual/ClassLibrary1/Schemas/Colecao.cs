namespace DAL.Schemas
{
	public class Colecao
	{
		/// <summary>Select</summary>
		public Colecao(int id, string nome, long dataCriacao, int idEvento)
		{
			Id = id;
			Nome = nome;
			DataCriacao = dataCriacao;
			IdEvento = idEvento;
		}

		/// <summary>Insert</summary>
		public Colecao(string nome, int idEvento)
		{
			Nome = nome;
			IdEvento = idEvento;
			DataCriacao = Utils.GetCurrentUnix();
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public long DataCriacao { get; set; }
		public int IdEvento { get; set; }
	}
}
