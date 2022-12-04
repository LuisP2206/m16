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
using System.Data.SqlClient;

namespace M16_68
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void cb_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pass.Checked == true)
                txt_pass.UseSystemPasswordChar = false;
            else
                txt_pass.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Proc login;
            string tipo;
            try
            {
                login = new Proc();
                tipo = login.login(txt_user.Text, txt_pass.Text);
                if (tipo != "Erro" && tipo != "loginfailed")
                {
                    if (tipo == "Colec")
                    {
                        Form_Consulta Cons = new Form_Consulta();               
                        this.Hide();
                        Cons.ShowDialog();
                        this.Show();
                        SqlCommand add = new SqlCommand(@"Insert into Acessos(Hora_inic,Observacoes) values())", ConString.con);
                    }
                    else
                    {
                        if (tipo == "adm")
                        {
                            Form_Adm Adm = new Form_Adm();
                            this.Hide();
                            Adm.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form_Register Reg = new Form_Register();
            this.Hide();
            Reg.ShowDialog();
            this.Show();
        }
    }
}
