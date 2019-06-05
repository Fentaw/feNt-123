using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTERY1
{
    public partial class CHEGE_PASSWORDfORM : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=YAREGAL\SQLEXPRESS;Initial Catalog=IMSP;Integrated Security=True");
        public CHEGE_PASSWORDfORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PASSWORD CHENGE SECUSSES FULLY");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void butn_back_click(object sender, EventArgs e)
        {
            INVENTERY1.MDIParent1 ID = new MDIParent1() ;
            ID.Show();
        }

        private void butn_save_click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string old_password = txt_oldpassword.Text;
            string new_password = txt_newpassword.Text;
            string confirm_password = txt_confirmpassword.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from LOGIN where USERNAME='" + username + "'and PASSWORD='" + old_password + "'", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                dr.Close();
                con.Close();
                if (count == 1)
                {
                    if (txt_newpassword.Text == txt_confirmpassword.Text)
                    {
                        con.Open();
                        string query = @"update user_login set pass_word='" + txt_newpassword.Text + "' where USERNAME='" + txt_user.Text + "'";
                        SqlCommand cm = new SqlCommand(query, con);
                        cm.Parameters.AddWithValue("USERNAME", txt_user.Text);
                        cm.Parameters.AddWithValue("PASSWORD", txt_newpassword.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Password seccessfully changed!", "change password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Confirmation Error");
                    }
                }
                else
                {
                    MessageBox.Show("user name and password does not much!/nPlease try again", "sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void butn_close_click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}