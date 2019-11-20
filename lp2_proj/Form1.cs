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
    public partial class F_main : Form
    {
        public 
            F_main()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F_main_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 telacli = new Form2();
            telacli.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 consclick = new Form3();
            consclick.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 procad = new Form4();
            procad.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 finmenu = new Form6();
            finmenu.ShowDialog();
        }
    }
}
