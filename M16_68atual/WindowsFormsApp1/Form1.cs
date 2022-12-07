using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Tuple<CommandResult, AccountType?> loginResult = Database.GetInstance().Login("admin", "admin");
			MessageBox.Show("result: " + loginResult.Item1.ToString() + " | " + loginResult.Item2.ToString());
		}
	}
}
