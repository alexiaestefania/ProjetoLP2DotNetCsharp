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
    public partial class Form3 : Form
    {
        public string Caminho = "Data Source=LAPTOPMAMIS;Initial Catalog=FITFREEDB;Integrated Security=True";
        SqlDataAdapter adapt;
        DataTable dt;

        public Form3()

        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fITFREEDB_LAPTOPDATASET.PROFCPF'. Você pode movê-la ou removê-la conforme necessário.
            this.pROFCPFTableAdapter1.Fill(this.fITFREEDB_LAPTOPDATASET.PROFCPF);



            SqlConnection con = new SqlConnection(Caminho);
            con.Open();

            adapt = new SqlDataAdapter("SELECT CLI_Nome as 'Nome', CLI_CPF as 'CPF', CLI_Ender as 'Endereço', CLI_Tel as 'Telefone', CLI_Email as 'e-mail', CLI_Nasc as 'Data de Nascimento', CLI_Medic as 'Status do Atestado Médico', CLI_MedVenc as 'Vencimento do Atestado Médico', fk_Professor_PROF_CPF as 'CPF do Professor Responsável' FROM Cliente", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close(); 
        
        }

        /*
        

      }  
      //txt_SearchName TextChanged Event  
      private void txt_SearchName_TextChanged(object sender, EventArgs e)  
      {  
          SqlConnection conexaobanco = new SqlConnection(Caminho);
            conexaobanco.Open();
          adapt = new SqlDataAdapter("select * from tbl_Employee where FirstName like '"+txt_SearchName.Text+"%'", con);  
          dt = new DataTable();  
          adapt.Fill(dt);  
          dataGridView1.DataSource = dt;  
          con.Close();  
      }  



  }  */


        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexaobanco = new SqlConnection(Caminho);
            conexaobanco.Open();
            SqlCommand Comandos = new SqlCommand();
            Comandos.Connection = conexaobanco;
            Comandos.CommandText = "UPDATE Cliente SET CLI_Nome=@nome, CLI_Ender=@ender, CLI_Tel=@tele, CLI_Email=@email, CLI_Nasc=@nasc, CLI_Medic=@med, CLI_MedVenc=@medvenc, fk_Professor_PROF_CPF=@prof WHERE CLI_Cpf=@cpf";

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

            if ((TBCPF.Text == "") || (TBnome.Text == "") || (TBender.Text == "") || (TBtel.Text == "") || (TBnasc.Text == "") || (TBemail.Text == "") || (TBprof.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos.", "Erro!");
            }

            else

            {
                Comandos.ExecuteNonQuery();
            MessageBox.Show("Cliente atualizado com sucesso.", "Atualização de Cliente");
            conexaobanco.Close();
            }


           
          



        }

       

        private void TextSearch_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Caminho);
            con.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Cliente WHERE CLI_Nome LIKE '" + TextSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}

