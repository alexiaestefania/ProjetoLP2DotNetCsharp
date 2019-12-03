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

namespace lp2_proj
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Caminho = "Data Source=LAPTOPMAMIS;Initial Catalog=FITFREEDB;Integrated Security=True";
            SqlConnection conexaobanco = new SqlConnection(Caminho);
            conexaobanco.Open();
            SqlCommand Comandos = new SqlCommand();
            Comandos.Connection = conexaobanco;
            Comandos.CommandText = "INSERT INTO Professor VALUES(@cpf, @nome, @ender, @tele, @nasc)";

            Comandos.Parameters.Add(new SqlParameter("@cpf", PROFcpf.Text));
            Comandos.Parameters.Add(new SqlParameter("@nome", PROFnome.Text));
            Comandos.Parameters.Add(new SqlParameter("@ender", PROFend.Text));
            Comandos.Parameters.Add(new SqlParameter("@tele", PROFtel.Text));
            Comandos.Parameters.Add(new SqlParameter("@nasc", PROFnasc.Text));
            if ((PROFcpf.Text == "") || (PROFnome.Text == "")|| (PROFend.Text == "") || (PROFtel.Text == "") || (PROFnasc.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos.", "Erro!");
            }
            else
            {
                Comandos.ExecuteNonQuery();

                MessageBox.Show("Professor cadastrado com sucesso.", "Cadastro de Professor");
                conexaobanco.Close();
            }
             



           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PROFcpf.Text = "";
            PROFnome.Text = "";
            PROFend.Text = "";
            PROFtel.Text = "";
            PROFnasc.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
