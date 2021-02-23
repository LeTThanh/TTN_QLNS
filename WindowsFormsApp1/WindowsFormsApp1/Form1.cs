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
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Data Source = localhost\SQLEXPRESS;Initial Catalog = QLNS; Integrated Security = True
        public Form1()
        {
            InitializeComponent();
        }

        dataconnection dc;
        SqlDataAdapter da;
        public nhanvienDAL()
        {
            dc = new dataconnection();
        }
        public DataTable GetData()
        {
            string searchmanv = "execute TK_manv '" + textBox_searchbox+"'";
            SqlConnection connectionstring = new dc.Ge
        }
        //SqlConnection 

    }
}
