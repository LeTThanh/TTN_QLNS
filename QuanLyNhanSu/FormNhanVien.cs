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
using System.Text.RegularExpressions;
namespace QuanLyNhanSu
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        string manv;
        string ns;
        public static void InfoMessageHandler(object mySender, SqlInfoMessageEventArgs myEvent)
        {
            MessageBox.Show(myEvent.Message);
        }
        string constr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyNhanSu1;Integrated Security=True";

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            load();
            //using ()
        }

        void load()
        {
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select manv as N'Mã nhân viên', hoten as N'Họ và tên', bangcap as N'Bằng cấp', gioitinh as N'Giới tính', ngaysinh N'Ngày sinh', diachi as N'Địa chỉ', mapb as N'Mã phòng ban', cmtnd as N'Số CCCD', sdt as N'Số điện thoại', dantoc as N'Dân tộc', tongiao as N'Tôn giáo' from nhanvien", sqlcon);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                DataGridView1.DataSource = dataTable;
                sqlcon.Close();
            }
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhân viên có mã "+ guna2TextBox_manv.Text, "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("execute xoaNV N'" + guna2TextBox_manv.Text + "'", sqlcon);
                    sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                    command.ExecuteNonQuery();
                    sqlcon.Close();
                }
                load();
            }
    }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.DataGridView1.Rows[e.RowIndex];
                guna2TextBox_manv.Text = row.Cells[0].Value.ToString();
                manv = guna2TextBox_manv.Text;
                guna2TextBox_hoten.Text= row.Cells[1].Value.ToString();
                guna2TextBox_bangcap.Text= row.Cells[2].Value.ToString();
                guna2TextBox_gioitinh.Text= row.Cells[3].Value.ToString();
                ns = Convert.ToString(row.Cells[4].Value);
                if (ns == "")
                {
                    guna2DateTimePicker_ns.Visible = false;
                    guna2DateTimePicker_ns.Enabled = false;
                }

                else
                {
                    guna2DateTimePicker_ns.Visible = true;
                    guna2DateTimePicker_ns.Enabled = true;
                    guna2DateTimePicker_ns.Value = Convert.ToDateTime(row.Cells[4].Value);
                }
                guna2TextBox_diachi.Text= row.Cells[5].Value.ToString();
                guna2TextBox_mapb.Text= row.Cells[6].Value.ToString();
                guna2TextBox_cccd.Text= row.Cells[7].Value.ToString();
                guna2TextBox_sdt.Text= row.Cells[8].Value.ToString();
                guna2TextBox_dantoc.Text= row.Cells[9].Value.ToString();
                guna2TextBox_tongiao.Text= row.Cells[10].Value.ToString();
            }    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            comboBox1_Index();
            if (check() == true)
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("execute Capnhatthongtin '" + guna2TextBox_manv.Text + "', N'" + guna2TextBox_hoten.Text + "', N'" + guna2TextBox_bangcap.Text + "', N'" + guna2TextBox_gioitinh.Text + "', '" + guna2DateTimePicker_ns.Value.ToString() + "', N'" + guna2TextBox_diachi.Text + "', '" + guna2TextBox_mapb.Text + "', '" + guna2TextBox_cccd.Text + "', '" + guna2TextBox_sdt.Text + "', N'" + guna2TextBox_dantoc.Text + "', N'" + guna2TextBox_tongiao.Text + "','" + manv + "'", sqlcon);
                    sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                    command.ExecuteNonQuery();
                    sqlcon.Close();
                }
                load();
            }
        }

        bool check()
        {
            if (guna2TextBox_bangcap.Text == "" || guna2TextBox_cccd.Text == "" || guna2TextBox_dantoc.Text == "" || guna2TextBox_diachi.Text == "" || guna2TextBox_gioitinh.Text == "" || guna2TextBox_hoten.Text == "" || guna2TextBox_manv.Text == "" || guna2TextBox_mapb.Text == "" || guna2TextBox_sdt.Text == "" || guna2TextBox_tongiao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ các trường thông tin", "Cảnh báo");
                
            }
            else
             {
                 if (Regex.IsMatch(guna2TextBox_sdt.Text, "\\d") == false || guna2TextBox_sdt.Text.Length < 10)
                 {
                     MessageBox.Show("Số điện thoại phải là chuỗi số có 10 số và không chứa kí tự nào ngoài 0->9", "Cảnh báo");
                 }
                 else if(Regex.IsMatch(guna2TextBox_cccd.Text, "\\d") == false && (guna2TextBox_cccd.ToString().Length != 10 || guna2TextBox_cccd.ToString().Length != 12))
                 {
                     MessageBox.Show("Số CCCD phải là chuỗi số có 10 số hoặc 12 số và không chứa kí tự nào ngoài 0->9 "+ guna2TextBox_cccd.Text.Length, "Cảnh báo");
                 }
                 else if (Regex.IsMatch(guna2TextBox_hoten.Text, "\\D") == false)
                 {
                     MessageBox.Show("Tên phải chứa kí tự nào trong khoảng a->z hoặc A->Z", "Cảnh báo");
                 }
                 else if (Regex.IsMatch(guna2TextBox_bangcap.Text, "\\D") == false)
                {
                     MessageBox.Show("Bằng cấp phải chứa kí tự trong khoảng a->z hoặc A->Z", "Cảnh báo");
                 }
                 else if (Regex.IsMatch(guna2TextBox_dantoc.Text, "\\D") == false)
                {
                     MessageBox.Show("Dân tộc phải chứa kí tự trong khoảng a->z hoặc A->Z", "Cảnh báo");
                 }
                 else if (Regex.IsMatch(guna2TextBox_gioitinh.Text, "\\D") == false)
                {
                     MessageBox.Show("Giới tính phải chứa kí tự trong khoảng a->z hoặc A->Z", "Cảnh báo");
                 }
                 else if (Regex.IsMatch(guna2TextBox_tongiao.Text, "\\D") == false)
                {
                     MessageBox.Show("Tôn giáo phải chứa kí tự trong khoảng a->z hoặc A->Z", "Cảnh báo");
                 }
                 else
                 {
                     return true;
                 }    
             }
            
            return false;
        }    
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            comboBox1_Index();
            if(check() == true)
            {    
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("execute themNV '" + guna2TextBox_manv.Text + "', N'"+guna2TextBox_hoten.Text+ "', N'"+ guna2TextBox_bangcap.Text+ "', N'"+guna2TextBox_gioitinh.Text+ "', '"+guna2DateTimePicker_ns.Value.ToString()+ "', N'"+guna2TextBox_diachi.Text+ "', '"+guna2TextBox_mapb.Text+ "', '"+guna2TextBox_cccd.Text+ "', '"+guna2TextBox_sdt.Text+ "', N'"+guna2TextBox_dantoc.Text+ "', N'"+guna2TextBox_tongiao.Text+"'", sqlcon);
                sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                command.ExecuteNonQuery();
                sqlcon.Close();
            }
            load();
        }
    }


        private void comboBox1_Index()
        {
            guna2TextBox_mapb.Items.Clear();
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("select mapb from phongban ", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    guna2TextBox_mapb.Items.Add(reader["mapb"].ToString());
                    guna2TextBox_mapb.DisplayMember = (reader["mapb"].ToString());
                    guna2TextBox_mapb.ValueMember = (reader["mapb"].ToString());
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ma, ten;
            ma = ten = "";
            if(guna2RadioButton_ma.Checked==true && guna2RadioButton_ten.Checked==false)
            {
                ma=guna2TextBox_timkiem.Text;
                ten = "";
            }
            else if (guna2RadioButton_ma.Checked == false && guna2RadioButton_ten.Checked == true)
            {
                ten =guna2TextBox_timkiem.Text;
                ma = "";
            }
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("exec timkiemnv '"+ ma +"','"+ ten +"'", sqlcon);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                DataGridView1.DataSource = dataTable;
                sqlcon.Close();
            }
        }
    }
    


}
