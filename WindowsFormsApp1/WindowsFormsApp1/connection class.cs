using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class dataconnection
    {
        public static string connectionstring;
        public dataconnection()
        {
            connectionstring = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = QLNS; Integrated Security = True";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
