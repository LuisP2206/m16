namespace DAL.Schemas
{
	public class ColecionadoresMoedas
	{
		/// <summary>Select</summary>
		public ColecionadoresMoedas(int id, int idColecionador, int idMoeda)
		{
			Id = id;
			IdColecionador = IdColecionador;
			IdMoeda = IdMoeda;
		}

		/// <summary>Insert</summary>
		public ColecionadoresMoedas(int idColecionador, int idMoeda)
		{
			IdColecionador = IdColecionador;
			IdMoeda = IdMoeda;
		}

		public int Id { get; set; }
		public int IdColecionador { get; set; }
		public int IdMoeda { get; set; }
	}
}
