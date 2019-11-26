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
    public partial class Form6 : Form
    {

        string caminho = "Data Source=DESKTOP-D46400L\\SQLEXPRESS;Initial Catalog=FITFREEDB;Integrated Security=SSPI";
        SqlDataAdapter adapt;
        DataTable dt;

        public Form6()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(caminho);
            con.Open();
            SqlCommand Comandos = new SqlCommand();
            Comandos.Connection = con;
            adapt = new SqlDataAdapter("SELECT PG_ID as 'Número', PG_Valor as 'Valor', PG_Ref as 'Mês Referente', CLI_Nome as 'Nome do Cliente', CLI_CPF as 'CPF do Cliente' FROM Mensalidade inner join Cliente on Mensalidade.fk_Cliente_CLI_CPF = CLI_CPF", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }



    
 
        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexaobanco = new SqlConnection(caminho);
            conexaobanco.Open();
            SqlCommand Comandos = new SqlCommand();
            Comandos.Connection = conexaobanco;
            Comandos.CommandText = "INSERT INTO Mensalidade VALUES (@valor, @mes, @cpf)";

            Comandos.Parameters.Add(new SqlParameter("@valor", Convert.ToDouble(TBVALOR.Text)));
            Comandos.Parameters.Add(new SqlParameter("@mes", TBMES.Text));
            Comandos.Parameters.Add(new SqlParameter("@cpf", TBCPF.Text));

            Comandos.ExecuteNonQuery();
            conexaobanco.Close();

            MessageBox.Show("Parcela cadastrada no sistema.", "Adição de Mensalidade");
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(caminho);
            con.Open();
            adapt = new SqlDataAdapter("SELECT PG_ID as 'Número', PG_Valor as 'Valor', PG_Ref as 'Mês Referente', CLI_Nome as 'Nome do Cliente', CLI_CPF as 'CPF do Cliente' FROM Mensalidade inner join Cliente on Mensalidade.fk_Cliente_CLI_CPF = CLI_CPF WHERE CLI_Nome LIKE'" + TextSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
    
       
}
