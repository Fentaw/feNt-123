using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace INVENTERY1
{
    public class conection
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=YAREGAL\SQLEXPRESS;Initial Catalog=IMSP;Integrated Security=True");
        public SqlConnection activesqlcon()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            return sqlcon;
        }
    }
}
