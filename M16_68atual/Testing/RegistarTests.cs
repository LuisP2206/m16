using DAL;
using DAL.Schemas;

using NUnit.Framework;

namespace Testing
{
	internal class RegistarTests
	{
		[Test]
		public void Registar()
		{
			Colecionador colecionador = new Colecionador("12345", "Utilizador", "Portugal", "email@example.com", "987654321", "Portugal", "user2", "user", AccountType.User);
			CommandResult result = Database.GetInstance().RegistarUtilizador(colecionador);
			Assert.IsTrue(result == CommandResult.Success);
		}

		[SetUp]
		[TearDown]
		public void DeleteUser()
		{
			// TODO
		}
	}
}
