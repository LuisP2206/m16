using System;
using System.Windows.Forms;

namespace M16_68
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(Form_Login.GetInstace(null));
		}
	}
}
