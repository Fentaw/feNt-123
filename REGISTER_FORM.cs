using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace INVENTERY1
{
    public partial class REGISTER_FORM : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=YAREGAL\SQLEXPRESS;Initial Catalog=IMSP;Integrated Security=True");
        public REGISTER_FORM()
        {
            InitializeComponent();
        }

        private void butn_new_click(object sender, EventArgs e)
        {
            
            createnew();
        }
        void createnew()
        {
            textBox1.Clear();
            textBox2.Clear();
            conection con=new conection();
            SqlDataAdapter sad = new SqlDataAdapter("stor",con.activesqlcon());
            sad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sad.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
        }

        private void butn_updat_click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            //cmd.CommandText=
        }

        private void butn_save_click(object sender, EventArgs e)
        {
            string M_id = textBox1.Text;
            string M_name = textBox2.Text;
            int quantity = Convert.ToInt32(textBox3.Text);
            double price = Convert.ToDouble(textBox4.Text);
            string catagory = textBox5.Text;
            string query = "insert into registertable(id,materialname,qauntity,price)values('" +textBox1.Text + "','" +textBox2.Text + "','" +textBox3.Text + "','" +textBox4.Text+ "')";
            SqlCommand cmd = new SqlCommand(query,sqlcon);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("seccssess fully insert");
            sqlcon.Close();
        }

        private void butn_delete_click(object sender, EventArgs e)
        {

        }

        private void REGISTER_FORM_Load(object sender, EventArgs e)
        {

        }

        private void butn_view_click(object sender, EventArgs e)
        {
            
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            INVENTERY1.MDIParent1 id = new MDIParent1();
            id.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BUTN_VIEW_Click_1(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = " select * from registertable";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sda.SelectCommand.ExecuteNonQuery();
            sqlcon.Close();
            //SqlDataAdapter sda = new SqlDataAdapter(@"select * from registertable", sqlcon);
            //DataTable dt = new DataTable();
            //SqlCommand cmd = new SqlCommand();
            //sda.Fill(dt);
            //dataGridView1.Rows.Clear();
            //foreach (DataRow items in dt.Rows)
            //{
            //    int n = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
            //    dataGridView1.Rows[n].Cells[1].Value = items["id"].ToString();
            //    dataGridView1.Rows[n].Cells[2].Value = items["matrialname"].ToString();
            //    dataGridView1.Rows[n].Cells[3].Value = items["qauntity"].ToString();
            //    dataGridView1.Rows[n].Cells[4].Value = items["price"].ToString();
            //    //dataGridView1.Rows[n].Cells[5].Value = items["image"].ToString();
            //}
        }

        private void SEARCH_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from registertable where matrialname='" + textBox3.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           // dataGridView1.Rows.Clear();
            foreach (DataRow items in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = items["id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = items["matrialname"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = items["qauntity"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = items["price"].ToString();
                //dataGridView1.Rows[n].Cells[5].Value = items["image"].ToString();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            INVENTERY1.MDIParent1 MD = new MDIParent1();
            MD.Show();
        }

        private void butn_save_Click_1(object sender, EventArgs e)
        {
            string M_id = textBox1.Text;
            string M_name = textBox2.Text;
            int quantity = Convert.ToInt32(textBox3.Text);
            double price = Convert.ToDouble(textBox4.Text);
            string catagory = textBox5.Text;
            sqlcon.Open();
            string query = "insert into registertable(id,materialname,qauntity,price)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            //cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("seccssess fully insert");
            sqlcon.Close();
        }
        }
    }

 