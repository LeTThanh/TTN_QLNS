using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{

    public partial class FormHopDong : Form
    {
        string manv;
        string tenhd;
        DateTime ngayki;
        DateTime ngayketthuc;
        string mahd;
        public FormHopDong()
        {
            InitializeComponent();
            load();
        }
        string ConnectionString = @"Data Source=LAPTOP-9PE5ABV1\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True";
        DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                catch { }

                connection.Close();
            }
            return data;
        }
        // trả về 1 data table  gọi trong phương thức xem, lấy dữ liệu qua câu truy vấn
        int ExecuteNonQuery(string query, object[] parameter = null)
        {

            int acceptedRows = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] temp = query.Split(' ');
                        List<string> listPara = new List<string>();
                        foreach (string item in temp)
                        {
                            if (item[0] == '@')
                                listPara.Add(item);
                        }
                        for (int i = 0; i < parameter.Length; i++)
                        {
                            command.Parameters.AddWithValue(listPara[i], parameter[i]);
                        }
                    }
                    //thực thi câu query chả về số dòng câu truy vấn thực hiện được
                    acceptedRows = -1;

                    acceptedRows = command.ExecuteNonQuery();
                }
                catch { MessageBox.Show("Lỗi Dữ Liệu"); }
                connection.Close();
            }

            return acceptedRows;
        }
        // trả về kiểu int, gọi trong phương thức thêm và xoá, kiểu int là số dòng  thực thi thay dổi database
        public void load()
        {
            string que = "Select * from HDLD";
            guna2DataGridView1.DataSource = ExecuteQuery(que);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                guna2TextBox1.Text = row.Cells["MaNV"].Value.ToString();
                guna2TextBox4.Text = row.Cells["MaHD"].Value.ToString();
                guna2TextBox5.Text = row.Cells["TenHD"].Value.ToString();
                guna2DateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgayKiHopDong"].Value);
                guna2DateTimePicker2.Value = Convert.ToDateTime(row.Cells["NgayKetThucKiHopDong"].Value);
            }
        }
        public void x()
        {
            manv = guna2TextBox1.Text;
            tenhd = guna2TextBox5.Text;
            mahd = guna2TextBox4.Text;
            ngayki = guna2DateTimePicker1.Value;
            ngayketthuc = guna2DateTimePicker2.Value;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //thêm
            x();
            string que = @"Insert into HDLD (MaNV, MaHD, TenHD, NgayKiHopDong, NgayKetThucKiHopDong) values( N'"
                + manv + "', N'" + mahd + "', N'"+ tenhd + "', '" + ngayki.ToString("MM/dd/yyyy") + "', '" + ngayketthuc.ToString("MM/dd/yyyy") + "')";
            int i = -1;
            i = ExecuteNonQuery(que);
            if (i != -1)
            {
                MessageBox.Show("Thêm Thành Công");
                load();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //sửa
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //xóa
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //gia hạn
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //tìm kiếm
        }
    }
}
