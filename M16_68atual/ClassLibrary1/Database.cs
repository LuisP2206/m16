using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

using DAL.Schemas;

namespace DAL
{
	public enum CommandResult
	{
		Success,
		Failed,
		Error,
	}

	public enum AccountType
	{
		Admin,
		User,
	}

	public class Database
	{
		private static Database Instance;

		public static Database GetInstance()
		{
			return Instance ?? new Database();
		}

		private Database()
		{
			Instance = this;
			ConnectionString = "Data Source=DBMoedas.db;Version=3;New=True;Compress=True;";
			Connection = new SQLiteConnection(ConnectionString);
			Connection.Open();
		}

		~Database()
		{
			try
			{
				if (Connection.State == ConnectionState.Open)
				{
					Connection.Close();
				}
			}
			catch { }
		}

		private readonly string ConnectionString;
		private readonly SQLiteConnection Connection;

		private SQLiteConnection GetConnection()
		{
			if (Connection.State != ConnectionState.Open)
			{
				Connection.Open();
			}
			return Connection;
		}

		public Tuple<CommandResult, AccountType?> Login(string username, string password)
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand(@"SELECT TipoConta FROM Colecionadores WHERE Username = '" + username + "' AND Password = '" + Utils.Hash(password) + "'", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					if (dataTable.Rows.Count == 0)
					{
						return new Tuple<CommandResult, AccountType?>(CommandResult.Failed, null);
					}

					DataRow row = dataTable.Rows[0];

					string tipoConta = Convert.ToString(row["TipoConta"]);
					Console.WriteLine("Tipo conta: " + tipoConta);

					Enum.TryParse(Utils.Capitalize(tipoConta), out AccountType accountType);

					return new Tuple<CommandResult, AccountType?>(CommandResult.Success, accountType);
				}
			}
			catch
			{
				return new Tuple<CommandResult, AccountType?>(CommandResult.Error, null);
			}
		}

		public CommandResult RegistarUtilizador(Colecionador colecionador)
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand(@"INSERT INTO Colecionadores (BI, Nome, Morada, Email, Telefone, Localidade, DataInscricao, Username, Password, TipoConta) VALUES (@bi, @nome, @morada, @email, @telefone, @localidade, @dataInscricao, @username, @password, @tipoConta)", GetConnection()))
				{
					command.Parameters.AddWithValue("bi", colecionador.BI);
					command.Parameters.AddWithValue("nome", colecionador.Nome);
					command.Parameters.AddWithValue("morada", colecionador.Morada);
					command.Parameters.AddWithValue("email", colecionador.Email);
					command.Parameters.AddWithValue("telefone", colecionador.Telefone);
					command.Parameters.AddWithValue("localidade", colecionador.Localidade);
					command.Parameters.AddWithValue("dataInscricao", Utils.GetCurrentUnix());
					command.Parameters.AddWithValue("username", colecionador.Username);
					command.Parameters.AddWithValue("password", Utils.Hash(colecionador.Password));
					command.Parameters.AddWithValue("tipoConta", colecionador.TipoConta.ToString().ToLower());
					command.ExecuteNonQuery();
				}

				return CommandResult.Success;
			}
			catch
			{
				return CommandResult.Error;
			}
		}

		public Tuple<CommandResult, List<Evento>> SelecionarEventos()
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand($"SELECT ID FROM Eventos", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					List<Evento> eventos = new List<Evento>();
					foreach (DataRow row in dataTable.Rows)
					{
						int id = Convert.ToInt32(row["ID"]);
						var resultEvento = SelecionarEvento(id);
						if (resultEvento.Item1 != CommandResult.Success)
						{
							return new Tuple<CommandResult, List<Evento>>(CommandResult.Error, null);
						}
						eventos.Add(resultEvento.Item2);
					}

					return new Tuple<CommandResult, List<Evento>>(CommandResult.Success, eventos);
				}
			}
			catch
			{
				return new Tuple<CommandResult, List<Evento>>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, Evento> SelecionarEvento(int id)
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Eventos WHERE ID = '{id}'", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					DataRow row = dataTable.Rows[0];

					string nome = Convert.ToString(row["Nome"]);
					long dataInicio = Convert.ToInt64(row["DataInicio"]);
					long dataFim = Convert.ToInt64(row["DataFim"]);
					string local = Convert.ToString(row["Local"]);
					string descricao = Convert.ToString(row["Descricao"]);

					Evento evento = new Evento(id, nome, dataInicio, dataFim, local, descricao);

					return new Tuple<CommandResult, Evento>(CommandResult.Success, evento);
				}
			}
			catch
			{
				return new Tuple<CommandResult, Evento>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, List<Colecao>> SelecionarColecoes()
		{
			try
			{
				List<Colecao> colecoes = new List<Colecao>();
				using (SQLiteCommand command = new SQLiteCommand($"SELECT ID FROM Colecoes", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					foreach (DataRow row in dataTable.Rows)
					{
						int id = Convert.ToInt32(row["ID"]);
						Tuple<CommandResult, Colecao> resultColecao = SelecionarColecao(id);
						if (resultColecao.Item1 != CommandResult.Success)
						{
							return new Tuple<CommandResult, List<Colecao>>(CommandResult.Error, null);
						}
						colecoes.Add(resultColecao.Item2);
					}
				}
				return new Tuple<CommandResult, List<Colecao>>(CommandResult.Success, colecoes);
			}
			catch
			{
				return new Tuple<CommandResult, List<Colecao>>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, Colecao> SelecionarColecao(int id)
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Colecoes WHERE ID = '{id}'", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					DataRow row = dataTable.Rows[0];

					string nome = Convert.ToString(row["Nome"]);
					long dataCriacao = Convert.ToInt64(row["DataCriacao"]);
					int idEvento = Convert.ToInt32(row["IdEvento"]);

					Colecao colecao = new Colecao(id, nome, dataCriacao, idEvento);

					return new Tuple<CommandResult, Colecao>(CommandResult.Success, colecao);
				}
			}
			catch
			{
				return new Tuple<CommandResult, Colecao>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, List<Colecao>> SelecionarColecoesDoColecionador(int idColecionador)
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM JN_ColecionadoresColecoes WHERE IdColecionador = '{idColecionador}'", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					List<Colecao> colecoes = new List<Colecao>();
					foreach (DataRow row in dataTable.Rows)
					{
						int idColecao = Convert.ToInt32(row["IdColecao"]);

						Tuple<CommandResult, Colecao> result = SelecionarColecao(idColecao);
						if (result.Item1 != CommandResult.Success)
						{
							throw new Exception();
						}
						colecoes.Add(result.Item2);
					}

					return new Tuple<CommandResult, List<Colecao>>(CommandResult.Success, colecoes);
				}
			}
			catch
			{
				return new Tuple<CommandResult, List<Colecao>>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, List<Moeda>> SelecionarMoedas()
		{
			try
			{
				List<Moeda> moedas = new List<Moeda>();
				using (SQLiteCommand command = new SQLiteCommand($"SELECT ID FROM Moedas", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					foreach (DataRow row in dataTable.Rows)
					{
						int id = Convert.ToInt32(row["ID"]);
						Tuple<CommandResult, Moeda> resultMoeda = SelecionarMoeda(id);
						if (resultMoeda.Item1 != CommandResult.Success)
						{
							return new Tuple<CommandResult, List<Moeda>>(CommandResult.Error, null);
						}
						moedas.Add(resultMoeda.Item2);
					}
				}
				return new Tuple<CommandResult, List<Moeda>>(CommandResult.Success, moedas);
			}
			catch
			{
				return new Tuple<CommandResult, List<Moeda>>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, Moeda> SelecionarMoeda(int id)
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Moedas WHERE ID = '{id}'", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					DataRow row = dataTable.Rows[0];

					string nome = Convert.ToString(row["Nome"]);
					double valor = Convert.ToDouble(row["Valor"]);
					int peso = Convert.ToInt32(row["Peso"]);
					string material = Convert.ToString(row["Material"]);
					int diametro = Convert.ToInt32(row["Diametro"]);
					long dataLancamento = Convert.ToInt64(row["DataLancamento"]);
					string artista = Convert.ToString(row["Artista"]);
					string imagem = Convert.ToString(row["Imagem"]);
					int idEvento = Convert.ToInt32(row["IdEvento"]);

					Moeda moeda = new Moeda(id, nome, valor, peso, material, diametro, dataLancamento, artista, imagem, idEvento);

					return new Tuple<CommandResult, Moeda>(CommandResult.Success, moeda);
				}
			}
			catch
			{
				return new Tuple<CommandResult, Moeda>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, List<ColecionadoresMoedas>> SelecionarColecionadoresMoedas()
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM JN_ColecionadoresMoedas", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					List<ColecionadoresMoedas> colecionadoresMoedasList = new List<ColecionadoresMoedas>();
					foreach (DataRow row in dataTable.Rows)
					{
						int id = Convert.ToInt32(row["ID"]);
						int idColecionador = Convert.ToInt32(row["IdColecionador"]);
						int idMoeda = Convert.ToInt32(row["IdMoeda"]);

						ColecionadoresMoedas colecionadoresMoedas = new ColecionadoresMoedas(id, idColecionador, idMoeda);
						colecionadoresMoedasList.Add(colecionadoresMoedas);
					}

					return new Tuple<CommandResult, List<ColecionadoresMoedas>>(CommandResult.Success, colecionadoresMoedasList);
				}
			}
			catch
			{
				return new Tuple<CommandResult, List<ColecionadoresMoedas>>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, List<Moeda>> SelecionarMoedasDoColecionador(int idColecionador)
		{
			try
			{
				Tuple<CommandResult, List<ColecionadoresMoedas>> colecionadoresMoedas = SelecionarColecionadoresMoedas();
				if (colecionadoresMoedas.Item1 != CommandResult.Success)
				{
					throw new Exception();
				}
				List<Moeda> moedas = new List<Moeda>();
				List<ColecionadoresMoedas> cms = colecionadoresMoedas.Item2.FindAll(cm => cm.IdColecionador == idColecionador);
				foreach (ColecionadoresMoedas cm in cms)
				{
					Tuple<CommandResult, Moeda> resultMoeda = SelecionarMoeda(cm.IdMoeda);
					if (resultMoeda.Item1 != CommandResult.Success) { throw new Exception(); }
					moedas.Add(resultMoeda.Item2);
				}
				return new Tuple<CommandResult, List<Moeda>>(CommandResult.Success, moedas);
			}
			catch
			{
				return new Tuple<CommandResult, List<Moeda>>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, List<Moeda>> SelecionarMoedasDaColecao(int idColecao)
		{
			try
			{
				Tuple<CommandResult, List<MoedasColecoes>> moedasColecoes = SelecionarMoedasColecoes();
				if (moedasColecoes.Item1 != CommandResult.Success)
				{
					throw new Exception();
				}
				List<Moeda> moedas = new List<Moeda>();
				List<MoedasColecoes> mcs = moedasColecoes.Item2.FindAll(cm => cm.IdColecao == idColecao);
				foreach (MoedasColecoes mc in mcs)
				{
					Tuple<CommandResult, Moeda> resultMoeda = SelecionarMoeda(mc.IdMoeda);
					if (resultMoeda.Item1 != CommandResult.Success) { throw new Exception(); }
					moedas.Add(resultMoeda.Item2);
				}
				return new Tuple<CommandResult, List<Moeda>>(CommandResult.Success, moedas);
			}
			catch
			{
				return new Tuple<CommandResult, List<Moeda>>(CommandResult.Error, null);
			}
		}

		public Tuple<CommandResult, List<MoedasColecoes>> SelecionarMoedasColecoes()
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM JN_MoedasColecoes", GetConnection()))
				using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					List<MoedasColecoes> moedasColecoesList = new List<MoedasColecoes>();
					foreach (DataRow row in dataTable.Rows)
					{
						int id = Convert.ToInt32(row["ID"]);
						int idMoeda = Convert.ToInt32(row["IdMoeda"]);
						int idColecao = Convert.ToInt32(row["IdColecao"]);

						MoedasColecoes moedasColecoes = new MoedasColecoes(id, idColecao, idMoeda);
						moedasColecoesList.Add(moedasColecoes);
					}

					return new Tuple<CommandResult, List<MoedasColecoes>>(CommandResult.Success, moedasColecoesList);
				}
			}
			catch
			{
				return new Tuple<CommandResult, List<MoedasColecoes>>(CommandResult.Error, null);
			}
		}

		public CommandResult RegistarMoeda(Moeda moeda)
		{
			try
			{
				using (SQLiteCommand command = new SQLiteCommand(@"INSERT INTO Moedas (Nome, Valor, Peso, Material, Diametro, DataLancamento, Artista, Imagem, IdEvento) VALUES (@nome, @valor, @peso, @material, @diametro, @dataLancamento, @artista, @image, @idEvento)", GetConnection()))
				{
					command.Parameters.AddWithValue("nome", moeda.Nome);
					command.Parameters.AddWithValue("valor", moeda.Valor);
					command.Parameters.AddWithValue("peso", moeda.Peso);
					command.Parameters.AddWithValue("material", moeda.Material);
					command.Parameters.AddWithValue("diametro", moeda.Diametro);
					command.Parameters.AddWithValue("dataLancamento", moeda.DataLancamento);
					command.Parameters.AddWithValue("artista", moeda.Artista);
					command.Parameters.AddWithValue("imagem", moeda.Imagem);
					command.Parameters.AddWithValue("idEvento", moeda.IdEvento);
					command.ExecuteNonQuery();
				}

				return CommandResult.Success;
			}
			catch
			{
				return CommandResult.Error;
			}
		}

		public Tuple<CommandResult, List<Colecao>> SelecionarColecoesDoEvento(int idEvento)
		{
			try
			{
				Tuple<CommandResult, List<Colecao>> resultColecoes = SelecionarColecoes();
				if (resultColecoes.Item1 != CommandResult.Success)
				{
					throw new Exception();
				}
				return new Tuple<CommandResult, List<Colecao>>(CommandResult.Success, resultColecoes.Item2.FindAll(c => c.IdEvento == idEvento));
			}
			catch
			{
				return new Tuple<CommandResult, List<Colecao>>(CommandResult.Error, null);
			}
		}
	}
}