namespace DAL.Schemas
{
	public class Evento
	{
		/// <summary>Select</summary>
		public Evento(int id, string nome, long dataInicio, long dataFim, string local, string descricao)
		{
			Id = id;
			Nome = nome;
			DataInicio = dataInicio;
			DataFim = dataFim;
			Local = local;
			Descricao = descricao;
		}

		/// <summary>Insert</summary>
		public Evento(string nome, long dataInicio, long dataFim, string local, string descricao)
		{
			Nome = nome;
			DataInicio = dataInicio;
			DataFim = dataFim;
			Local = local;
			Descricao = descricao;
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public long DataInicio { get; set; }
		public long DataFim { get; set; }
		public string Local { get; set; }
		public string Descricao { get; set; }
	}
}
