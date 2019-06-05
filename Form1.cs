using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTERY1
{
    public partial class LOGINFORM : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=YAREGAL\SQLEXPRESS;Initial Catalog=IMSP;Integrated Security=True");
        private int attempt = 1;
        public LOGINFORM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if (USERNTB.Text != string.Empty || PASSWTB.Text != string.Empty)
            {

          
                SqlDataAdapter sda = new SqlDataAdapter(@"Select count(*) from LOGIN where USERNAME='" + USERNTB.Text + "'and PASSWORD='" + PASSWTB.Text + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    HOMPAGEFORM HO = new HOMPAGEFORM();
                    HO.Show();
                }
                else
                {
                    MessageBox.Show("ERROR PLSE TRIAGAIN");
                }
            }
            else
            {
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                if (USERNTB.Text == string.Empty) label4.Text = "username can not be empty";
                if (PASSWTB.Text == string.Empty) label5.Text = "password can not be empty";
            }

        }
        //    if (USERNTB.Text != string.Empty || PASSWTB.Text != string.Empty) {
        //        SqlConnection sqlconn;
        //        SqlCommand sqlcmd;
        //        SqlDataReader data;
        //        string connectionString, sqlInput, sqlOutput;

        //        connectionString = @"Data Source=YAREGAL\SQLEXPRESS;Initial Catalog=IMSP;Integrated Security=true";
        //        sqlconn = new SqlConnection(connectionString);
        //        sqlconn.Open();
        //        //MessageBox.Show("connection seccess");

        //        sqlInput = @"SELECT USERNAME, PASSWORD FROM LOGIN WHERE USERNAME = " + USERNTB.Text + " AND PASSWORD = " + PASSWTB.Text;
        //        sqlcmd = new SqlCommand(sqlInput, sqlconn);
        //        try { 
        //            data = sqlcmd.ExecuteReader();
        //            while (data.Read())
        //                MessageBox.Show(data.GetValue(0).ToString() + data.GetValue(1).ToString());
        //            if (/*(data.GetValue(0).ToString() == string.Empty || data.GetValue(1).ToString() == string.Empty) || */attempt == 3)
        //                throw new Exception();
        //            else { /*MessageBox.Show(data.GetValue(0).ToString() + data.GetValue(1).ToString()); */MessageBox.Show("LOGIN SUCCESS"); }
        //        }catch(SqlException _) {MessageBox.Show("user not found " + attempt.ToString() /* + _.Message.ToString()*/); if (attempt == 3) Application.Exit();attempt++;}
        //    }
        //    else {
        //        label4.ForeColor = Color.Red;
        //        label5.ForeColor = Color.Red;
        //        if (USERNTB.Text == string.Empty) label4.Text = "username can not be empty";
        //        if (PASSWTB.Text == string.Empty) label5.Text = "password can not be empty";
        //    }

        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                PASSWTB.PasswordChar = '\0';
            else PASSWTB.PasswordChar = '.';
        }
    }
}
