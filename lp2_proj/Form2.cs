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
            // TODO: This line of code loads data into the 'fITFREEDBDataSet1.PROFCPF' table. You can move, or remove it, as needed.
            this.pROFCPFTableAdapter2.Fill(this.fITFREEDBDataSet1.PROFCPF);
            // TODO: esta linha de código carrega dados na tabela 'dBFITFREEV1DataSet6.PROFCPF'. Você pode movê-la ou removê-la conforme necessário.




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

            Comandos.Parameters.Add(new SqlParameter("@cpf", TBCPF.Text));
            Comandos.Parameters.Add(new SqlParameter("@nome", TBnome.Text));
            Comandos.Parameters.Add(new SqlParameter("@ender", TBender.Text));
            Comandos.Parameters.Add(new SqlParameter("@tele", TBtel.Text));
            Comandos.Parameters.Add(new SqlParameter("@email", TBemail.Text));
            Comandos.Parameters.Add(new SqlParameter("@nasc", TBnasc.Text));
            Comandos.Parameters.Add(new SqlParameter("@medvenc", TBvenc.Text));
            Comandos.Parameters.Add(new SqlParameter("@prof", TBprof.Text));

            if (medbutton.Checked)
            {
                Comandos.Parameters.Add(new SqlParameter("@med", 'S'));
            }
            else
                Comandos.Parameters.Add(new SqlParameter("@med", 'N'));
            Comandos.ExecuteNonQuery();
            MessageBox.Show("Cliente cadastrado com sucesso.", "Cadastro de Cliente");
            conexaobanco.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBCPF.Text = "";
            TBnome.Text = "";
            TBender.Text = "";
            TBemail.Text = "";
            TBtel.Text = "";
            TBnasc.Text = "";
            TBvenc.Text = "";
            TBprof.Text = "";
            medbutton.Checked = false;
            medbutton2.Checked = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
