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
    public partial class CUSTEMERFORM : Form
    {
        public CUSTEMERFORM()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CUSTEMERFORM_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("REGISTRETION SUCCSESS FULLLY");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
