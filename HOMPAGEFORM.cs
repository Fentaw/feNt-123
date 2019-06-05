using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTERY1
{
    public partial class HOMPAGEFORM : Form
    {
        public HOMPAGEFORM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            INVENTERY1.MDIParent1 ho = new INVENTERY1.MDIParent1();
            ho.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTEMERFORM CST = new CUSTEMERFORM();
            CST.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTEMERFORM CST = new CUSTEMERFORM();
            CST.Show();
        }
    }
}
