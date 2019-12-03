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
    public partial class Form7 : Form
    {

        public string Caminho = "Data Source=LAPTOPMAMIS;Initial Catalog=FITFREEDB;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public Form7()

        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fITFREEDBDataSet4.ProfCadastros' table. You can move, or remove it, as needed.

            SqlConnection con = new SqlConnection(Caminho);
            con.Open();

            adapt = new SqlDataAdapter("select PROF_Nome as 'Nome', PROF_CPF as 'CPF',  PROF_Ender as 'Endereço', PROF_Tel as 'Telefone', PROF_Nasc	as 'Data de Nascimento' FROM Professor", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Caminho);
            con.Open();
            adapt = new SqlDataAdapter("SELECT PROF_Nome as 'Nome', PROF_CPF as 'CPF',  PROF_Ender as 'Endereço', PROF_Tel as 'Telefone', PROF_Nasc	as 'Data de Nascimento' FROM Professor WHERE PROF_Nome LIKE '" + TextSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Caminho);
            con.Open();
            SqlCommand Comandos = new SqlCommand();
            Comandos.Connection = con;
            Comandos.CommandText = "UPDATE Professor SET PROF_Nome=@nome, PROF_Ender=@ender, PROF_Tel=@tele, PROF_Nasc=@nasc WHERE PROF_CPF=@cpf";
            //CLI_Nome=@nome, CLI_Ender=@ender, WHERE CLI_Cpf=@cpf";
            Comandos.Parameters.Add(new SqlParameter("@cpf", PROFcpf.Text));
            Comandos.Parameters.Add(new SqlParameter("@nome", PROFnome.Text));
            Comandos.Parameters.Add(new SqlParameter("@ender", PROFend.Text));
            Comandos.Parameters.Add(new SqlParameter("@tele", PROFtel.Text));
            Comandos.Parameters.Add(new SqlParameter("@nasc", PROFnasc.Text));

            if ((PROFcpf.Text == "") || (PROFnome.Text == "") || (PROFend.Text == "") || (PROFtel.Text == "") || (PROFnasc.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos.", "Erro!");
            }
            else
            {
                Comandos.ExecuteNonQuery();

                MessageBox.Show("Cadastro de professor alterado com sucesso.", "Atualização Completa");
                con.Close();
            }
            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PROFcpf.Text = "";
            PROFnome.Text = "";
            PROFend.Text = "";
            PROFtel.Text = "";
            PROFnasc.Text = "";
        }
    }
}
