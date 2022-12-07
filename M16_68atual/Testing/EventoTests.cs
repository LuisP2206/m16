using System;

using DAL;
using DAL.Schemas;

using NUnit.Framework;

namespace Testing
{
	internal class EventoTests
	{
		[Test]
		public void SelecionarEvento()
		{
			Tuple<CommandResult, Evento> result = Database.GetInstance().SelecionarEvento(1);
			Assert.IsTrue(result.Item1 == CommandResult.Success);

			Evento evento = result.Item2;
			Assert.IsTrue(evento.Nome == "TesteEvento");
		}
	}
}
