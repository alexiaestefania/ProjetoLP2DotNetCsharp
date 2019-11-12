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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBFITFREEV1DataSet6.PROFCPF'. Você pode movê-la ou removê-la conforme necessário.
            this.pROFCPFTableAdapter1.Fill(this.dBFITFREEV1DataSet6.PROFCPF);
           


        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Caminho = "Data Source=LAB02-PC16\\SQLEXPRESS;Initial Catalog=DBFITFREEV1;Integrated Security=SSPI";
            SqlConnection conexaobanco = new SqlConnection(Caminho);
            conexaobanco.Open();
            SqlCommand Comandos = new SqlCommand();
            Comandos.Connection = conexaobanco;
            Comandos.CommandText = "INSERT INTO Cliente VALUES(@cpf, @nome, @ender, @tele, @email, @nasc, @med, @medvenc, @prof)";

            // listagem de textboxes

            Comandos.Parameters.Add(new SqlParameter("@cpf", TBCPF));
            Comandos.Parameters.Add(new SqlParameter("@nome", TBCPF));
            Comandos.Parameters.Add(new SqlParameter("@ender", TBCPF));
            Comandos.Parameters.Add(new SqlParameter("@tele", TBCPF));
            Comandos.Parameters.Add(new SqlParameter("@email", TBCPF));
            Comandos.Parameters.Add(new SqlParameter("@nasc", TBCPF));
            Comandos.Parameters.Add(new SqlParameter("@cpf", TBCPF));

            if (radioButton1.Checked)
            {
               
            }

              



        }
    }
}
