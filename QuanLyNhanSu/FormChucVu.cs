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

namespace QuanLyNhanSu
{

    public partial class FormChucVu : Form
    {
        string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True";
        public FormChucVu()
        {
            InitializeComponent();
            LoadInformation();
        }
        

        private void ClearDL()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            
        }


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




        private void LoadInformation()
        {
            string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "select * from CHUCVU";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridchucvu.DataSource = data;



        }
        private void ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridchucvu.CurrentRow.Index;
            txtMaCV.Text = dataGridchucvu.Rows[i].Cells[0].Value.ToString();
            txtTenCV.Text = dataGridchucvu.Rows[i].Cells[1].Value.ToString();
           

            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text != "")
            {
                if (txtTenCV.Text != "")
                {


                    string macv = txtMaCV.Text;

                    string tencv = txtTenCV.Text;

                    string query = "Insert into CHUCVU values(  N'" + macv.ToString() + "',N'" + tencv.ToString() + "' )";
                    int i = -1;
                    i = ExecuteNonQuery(query);
                    if (i != -1)
                    {
                        MessageBox.Show("Đã Thêm Thành Công!");

                        LoadInformation();

                        ClearDL();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công!");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên chức vụ");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã chức vụ");
            }
        }      



              


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text != "")
            {
                if (txtTenCV.Text != "")
                {


                    string macv = txtMaCV.Text;

                    string tencv = txtTenCV.Text;

                    string query = "update  CHUCVU set MaCV=  N'" + macv.ToString() + "', TenCV =  N'" + tencv.ToString() + "' where MaCV=  N'" + macv.ToString() + "' ";
                    int i = -1;
                    i = ExecuteNonQuery(query);
                    if (i != -1)
                    {
                        MessageBox.Show("Đã Sửa Thành Công!");

                        LoadInformation();

                        ClearDL();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không Thành Công!");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên chức vụ");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã chức vụ");
            }
        }





        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMaCV.Text != "")
                {



                    string macv = txtMaCV.Text;

                    string tencv = txtTenCV.Text;

                    string query = "exec XoaCV @maCV = N'" + macv + " '";
                    int i = -1;
                    i = ExecuteNonQuery(query);
                    if (i != -1 && i ==1)
                    {
                        MessageBox.Show("Đã Xóa Thành Công!");

                        LoadInformation();

                        ClearDL();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công!");
                    }




                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã chức vụ");
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadInformation();
        }

        
        private void guna2Button1_Click(object sender, EventArgs e)// nút tìm kiếm
        {
            if (radiobtn_theoma.Checked == true)
            {
                
                
                if (txtTimKiem.Text != "")
                {
                    
                    string que = "Select * from CHUCVU where macv like N'%" + txtTimKiem.Text + "%'";
                    dataGridchucvu.DataSource = ExecuteQuery(que);
                    radiobtn_theoma.Checked = false;
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập thông tin tìm kiếm");
                    LoadInformation();
                }    
            } 
            if(radiobtn_theoten.Checked==true)
            {
                if (txtTimKiem.Text != "")
                {

                    string que = "Select * from CHUCVU where tencv like N'%" + txtTimKiem.Text + "%'";
                    dataGridchucvu.DataSource = ExecuteQuery(que);
                    radiobtn_theoten.Checked = false;
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập thông tin tìm kiếm");
                    LoadInformation();
                }
            }    
            
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
