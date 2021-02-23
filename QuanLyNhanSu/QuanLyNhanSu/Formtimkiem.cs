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

namespace QuanLyNhanSu
{
    public partial class Formtimkiem : Form
    {
        public Formtimkiem()
        {
            InitializeComponent();
        }

        string sqlquery_timkiem()
        {
            if (radioButton_chucvu.Checked == true)
            {
                return "SELECT * FROM NHANVIEN WHERE MANV ='"+textBox_timkiem.Text+"'";
            }
            else if(radioButton_manv.Checked==true)
            {
                return "SELECT * FROM NHANVIEN WHERE MANV ='" + textBox_timkiem.Text + "'";
            }
            else if(radioButton_mapb.Checked==true)
            {
                return "SELECT * FROM NHANVIEN WHERE MAPB ='" + textBox_timkiem.Text + "'";
            }
            else if(radioButton_Tennv.Checked==true)
            { return "SELECT * FROM NHANVIEN WHERE TENNV LIKE % '" + textBox_timkiem.Text + "'"; }    
            else
                return "lolo";
        DataSet GetData()
        {
            DataSet data = new DataSet();
            using(SqlConnection connection = new SqlConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                connection.Close();

            }    
        }
        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_timkiem.DataSource = GetData();
        }
    }
}
