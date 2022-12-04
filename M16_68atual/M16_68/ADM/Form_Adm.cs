using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M16_68
{
    public partial class Form_Adm : Form
    {
        public Form_Adm()
        {
            InitializeComponent();
        }

        private void btnC_eventos_Click(object sender, EventArgs e)
        {

        }

        private void adicionarMoedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddMo admo = new Form_AddMo();
            admo.ShowDialog();
        }
    }
}
