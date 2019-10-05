using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagementSystem
{
    public class Connection
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=LMS;Integrated Security=True");

        public SqlConnection activecon()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect;
        }
       
    }
}
