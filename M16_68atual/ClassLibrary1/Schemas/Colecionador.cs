namespace DAL.Schemas
{
	public class Colecionador
	{
		/// <summary>Select</summary>
		public Colecionador(int id, string bi, string nome, string morada, string email, string telefone, string localidade, long dataInscricao, string username, string password, AccountType tipoConta)
		{
			Id = id;
			BI = bi;
			Nome = nome;
			Morada = morada;
			Email = email;
			Telefone = telefone;
			Localidade = localidade;
			DataInscricao = dataInscricao;
			Username = username;
			Password = password;
			TipoConta = tipoConta;
		}

		/// <summary>Insert</summary>
		public Colecionador(string bi, string nome, string morada, string email, string telefone, string localidade, string username, string password, AccountType tipoConta)
		{
			BI = bi;
			Nome = nome;
			Morada = morada;
			Email = email;
			Telefone = telefone;
			Localidade = localidade;
			DataInscricao = Utils.GetCurrentUnix();
			Username = username;
			Password = password;
			TipoConta = tipoConta;
		}

		public int Id { get; set; }
		public string BI { get; set; }
		public string Nome { get; set; }
		public string Morada { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public string Localidade { get; set; }
		public long DataInscricao { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public AccountType TipoConta { get; set; }
	}
}
