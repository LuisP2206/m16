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
    public partial class Form_CMoedas : Form
    {
        private static Form_CMoedas Instance;

        public static Form_CMoedas GetInstance()
        {
            return Instance ?? new Form_CMoedas();
        }

        public Form_CMoedas()
        {
            Instance = this;
            InitializeComponent();
        }
    }
}
