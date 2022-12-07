using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M16_68
{
    public partial class Form_CEventos : Form
    {
        private static Form_CEventos Instance;

        public static Form_CEventos GetInstance()
        {
            return Instance ?? new Form_CEventos();
        }

        public Form_CEventos()
        {
            Instance = this;
            InitializeComponent();
        }

        private void Form_CEventos_Load(object sender, EventArgs e)
        {
        }

        private void lv_eventos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
