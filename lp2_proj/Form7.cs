using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lp2_proj
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fITFREEDBDataSet4.ProfCadastros' table. You can move, or remove it, as needed.
            this.profCadastrosTableAdapter.Fill(this.fITFREEDBDataSet4.ProfCadastros);

        }
    }
}
