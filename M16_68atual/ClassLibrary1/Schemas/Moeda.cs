namespace DAL.Schemas
{
	public class Moeda
	{
		/// <summary>Select</summary>
		public Moeda(int id, string nome, double valor, int peso, string material, int diametro, long dataLancamento, string artista, string imagem, int idEvento)
		{
			Id = id;
			Nome = nome;
			Valor = valor;
			Peso = peso;
			Material = material;
			Diametro = diametro;
			DataLancamento = dataLancamento;
			Artista = artista;
			Imagem = imagem;
			IdEvento = idEvento;
		}

		/// <summary>Insert</summary>
		public Moeda(string nome, double valor, int peso, string material, int diametro, long dataLancamento, string artista, string imagem, int idEvento)
		{
			Nome = nome;
			Valor = valor;
			Peso = peso;
			Material = material;
			Diametro = diametro;
			DataLancamento = dataLancamento;
			Artista = artista;
			Imagem = imagem;
			IdEvento = idEvento;
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public double Valor { get; set; }
		public int Peso { get; set; }
		public string Material { get; set; }
		public int Diametro { get; set; }
		public long DataLancamento { get; set; }
		public string Artista { get; set; }
		public string Imagem { get; set; }
		public int IdEvento { get; set; }
	}
}
