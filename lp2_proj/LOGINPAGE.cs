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
    public partial class LOGINPAGE : Form
    {
        public LOGINPAGE()
        {



            InitializeComponent();

            //"select userid,password from login where userid='" + textBox1.Text + "'and password='" + text            Box2.Text + "'", con); 
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {


            string Caminho = "Data Source=LAPTOPMAMIS;Initial Catalog=FITFREEDB;Integrated Security=True";
            SqlConnection conexaobanco = new SqlConnection(Caminho);

                conexaobanco.Open();
                SqlCommand Comandos = new SqlCommand();
                Comandos.Connection = conexaobanco;
                Comandos.CommandText = "SELECT * FROM Auth WHERE Authlog = @Authlog and Authpw = @Authpw";
                Comandos.Parameters.Add(new SqlParameter("@Authlog", textBox1.Text));
                Comandos.Parameters.Add(new SqlParameter("@Authpw", textBox2.Text));

                Comandos.CommandType = CommandType.Text;
                SqlDataReader Autentica = Comandos.ExecuteReader();

            if (Autentica.Read())
            {
                F_main telacli = new F_main();
                telacli.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Verifique suas credenciais.", "Falha de autenticação");
            }      
                conexaobanco.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }  
}
