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
    public partial class FormPhongBan : Form
    {
        string connectionString = conStr.str;
        public FormPhongBan()
        {
            InitializeComponent();
            
            load();
        }
        #region ExcuteQuery
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try { adapter.Fill(data); }
                catch { }


                connection.Close();
            }
            return data;
        }
        #endregion
        #region ExcuteNonQuery
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int acceptedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                //thực thi câu query chả về số dòng câu truy vấn thực hiện được
                acceptedRows = -1;
                try
                {
                    acceptedRows = command.ExecuteNonQuery();
                }
                catch { }
                connection.Close();
            }

            return acceptedRows;
        }
        #endregion
        #region load
        void load()
        {
            guna2DataGridView1.DataSource = ExecuteQuery("Select * from phongban");
        }
        #endregion
        #region Event
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            load();
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(TextBoxMaP.Text!="" && TextBoxTenP.Text!="" && TextBoxDiaChi.Text!="" && TextBoxMaTP.Text!="" && TextBoxTenTP.Text!="")
                {
                    string que = "Insert into phongban(MaPB, TenPB, DiaChi, MaTP, TenTP) values ('"+TextBoxMaP.Text+"', N'"+TextBoxTenP.Text+"', N'"+TextBoxDiaChi.Text+"', '"+TextBoxMaTP.Text+"' , N'"+TextBoxTenTP.Text+"' )";
                    int rez = ExecuteNonQuery(que);
                    if(rez > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        load();
                    }    
                    else
                    {
                        MessageBox.Show("Mã đã tồn tại");
                    }    
                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Mã đã tông tại");
            }
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxMaP.DataBindings.Clear();
            TextBoxMaP.DataBindings.Add("text", guna2DataGridView1.DataSource, "mapb");
            TextBoxTenP.DataBindings.Clear();
            TextBoxTenP.DataBindings.Add("text", guna2DataGridView1.DataSource, "tenpb");
            TextBoxDiaChi.DataBindings.Clear();
            TextBoxDiaChi.DataBindings.Add("text", guna2DataGridView1.DataSource, "diachi");
            TextBoxMaTP.DataBindings.Clear();
            TextBoxMaTP.DataBindings.Add("text", guna2DataGridView1.DataSource, "matp");
            TextBoxTenTP.DataBindings.Clear();
            TextBoxTenTP.DataBindings.Add("text", guna2DataGridView1.DataSource, "tentp");
        }

        #endregion

        private void TextBoxMaTP_TextChanged(object sender, EventArgs e)
        {
            TextBoxTenTP.Text = "";
            if (TextBoxMaTP.Text!="")
            {
                DataTable data = ExecuteQuery("Select hoten from nhanvien where manv = '" + TextBoxMaTP.Text + "'");
                foreach (DataRow item in data.Rows)
                {
                    TextBoxTenTP.Text = item["hoten"].ToString();
                }
            }  
           if(TextBoxTenTP.Text=="")
            {
                TextBoxTenTP.Text = "Không tim thấy";
            }    
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if(TextBoxMaP.Text!="")
            {
                if(MessageBox.Show("Bạn có thực sự muốn xóa phong ban có mã "+TextBoxMaP.Text+" không?", "Cảnh báo mất dữ liệu!!", System.Windows.Forms.MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string que1 = "Update NhanVien set mapb = NULL where mapb = '"+TextBoxMaP.Text+"'";
                    string que2 = "Delete PhongBan where MaPB='"+TextBoxMaP.Text+"'";
                    ExecuteNonQuery(que1);
                    int rez = 0;
                    rez = ExecuteNonQuery(que2);
                    if(rez>0)
                    {
                        MessageBox.Show("Xóa thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }    
                }    
            }   else
            {
                MessageBox.Show("Hãy chọn thông tin cần xóa");
            }    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(TextBoxMaP.Text!="")
            {
                string que = "Update PHONGBAN set TenPB=N'"+TextBoxTenP.Text+"', DiaChi=N'"+TextBoxDiaChi.Text+"', MaTP='"+TextBoxMaTP.Text+"', TenTP=N'"+TextBoxTenTP.Text+"' where MaPB='"+TextBoxMaP.Text+"'";
                int rez = 0;
                rez = ExecuteNonQuery(que);
                if(rez > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    load();
                }    
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }    
            }   else
            {
                MessageBox.Show("Chọn thông tin cần sửa");
            }    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                //theo mã
                string que = "Select * from phongban where mapb like '%"+TextBoxTimKiem.Text+"%'";
                guna2DataGridView1.DataSource = ExecuteQuery(que);
            }    
            else
            {
                //theo tên
                string que = "Select * from phongban where tenpb like N'%" + TextBoxTimKiem.Text + "%'";
                guna2DataGridView1.DataSource = ExecuteQuery(que);
            }    
        }
    }
}
