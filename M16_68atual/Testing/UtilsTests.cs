using System;

using DAL;

using NUnit.Framework;

namespace Testing
{
	internal class UtilsTests
	{
		[Test]
		public void GetCurrentUnix()
		{
			Assert.IsTrue(Utils.GetCurrentUnix() > 1670351760L);
		}

		[Test]
		public void UnixToDate()
		{
			DateTime date = Utils.UnixToDate(1670351760L);
			Assert.IsTrue(date.ToString() == "06/12/2022 18:36:00");
		}

		[Test]
		public void Hash()
		{
			string hashed = Utils.Hash("teste");
			Assert.IsTrue(hashed.ToLower() == "46070d4bf934fb0d4b06d9e2c46e346944e322444900a435d7d9a95e6d7435f5");
		}
	}
}
