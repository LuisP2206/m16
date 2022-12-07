using System;

using DAL;

using NUnit.Framework;

namespace Testing
{
	internal class LoginTests
	{
		[Test]
		public void LoginSuccessAdmin()
		{
			Tuple<CommandResult, AccountType?> loginResult = Database.GetInstance().Login("admin", "admin");
			Assert.IsTrue(loginResult.Item1 == CommandResult.Success && loginResult.Item2 == AccountType.Admin);
		}

		[Test]
		public void LoginSuccessUser()
		{
			Tuple<CommandResult, AccountType?> loginResult = Database.GetInstance().Login("user", "user");
			Assert.IsTrue(loginResult.Item1 == CommandResult.Success && loginResult.Item2 == AccountType.Admin);
		}

		[Test]
		public void LoginFailure()
		{
			Tuple<CommandResult, AccountType?> loginResult = Database.GetInstance().Login("fail", "fail");
			Assert.IsTrue(loginResult.Item1 == CommandResult.Failed && loginResult.Item1 != CommandResult.Error);
		}
	}
}