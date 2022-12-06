using DAL;
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
    public partial class Form_Consulta : Form
    {
        public Form_Consulta()
        {
            InitializeComponent();
        }

        private void Form_Consulta_Load(object sender, EventArgs e)
        {
            ObE Eventos;
            string eventos;
            try
            {
                Eventos = new ObE();
                eventos = Eventos.Eventos(cbC_eventos.Text);
                //eventos.Eventos(cbC_eventos.Text);
                cbC_eventos.Text = eventos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /*ConString.con.Open(); 
            SqlCommand CE = new SqlCommand("Select Nome from Evento", ConString.con);
            SqlDataAdapter da = new SqlDataAdapter(CE);
            DataSet ds = new DataSet();
            //string[] item = new string[1];
            da.Fill(ds);
            cbC_eventos.Text = ds.Tables[0].Columns["Nome"].ToString();

            SqlCommand CM = new SqlCommand("Select * from Moeda", ConString.con);
            SqlDataAdapter da1 = new SqlDataAdapter(CM);
            DataSet ds1 = new DataSet();
            //string[] item1 = new string[1];
            da.Fill(ds1);
            cbC_eventos.Text = ds.Tables[0].Columns["Nome"].ToString();

            SqlCommand CC = new SqlCommand("Select * from Colecoes", ConString.con);
            SqlDataAdapter da2 = new SqlDataAdapter(CC);
            DataSet ds2 = new DataSet();
            //string[] item2 = new string[1];
            da.Fill(ds2);
            cbC_eventos.Text = ds.Tables[0].Columns["Nome"].ToString();
            ConString.con.Close();*/
        }

        private void btnC_eventos_Click(object sender, EventArgs e)
        {
            Form_CEventos cev = new Form_CEventos();
            cev.ShowDialog();
        }

        private void btnC_colecao_Click(object sender, EventArgs e)
        {
            Form_CColecao cc = new Form_CColecao();
            cc.ShowDialog();
        }

        private void btnC_moedas_Click(object sender, EventArgs e)
        {
            Form_CMoedas cm = new Form_CMoedas();
            cm.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SqlCommand add = new SqlCommand(@"Insert into Acessos(Hora_fim,Observacoes) values())", ConString.con);
        }

        private void suasMoedasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_MinhaC mc = new Form_MinhaC();
            this.Hide();
            mc.ShowDialog();
            this.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add ad = new Form_Add();
            ad.ShowDialog();
        }

        private void suasMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
