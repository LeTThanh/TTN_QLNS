using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormThongTinTK : Form
    {
        public DataTable dt;
        public FormThongTinTK()
        {
            InitializeComponent();
            loadCbPB(cbMapb);
        }
        public DataTable loadThongtin(string manv)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr.str))
            {
                con.Open();
                string query = "select * from NHANVIEN where MaNV = '" + manv + "'";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                con.Close();
                try { adapter.Fill(data); }
                catch{ }
            }
            return data;
        }

        private void FormThongTinTK_Load(object sender, EventArgs e)
        {
            DataTable data = loadThongtin(Program.manvlogin);
            txbManv.Text = data.Rows[0]["MaNV"].ToString();
            txbTennv.Text = data.Rows[0]["HoTen"].ToString();
            txbDiachi.Text = data.Rows[0]["DiaChi"].ToString();
            txbCccd.Text = data.Rows[0]["CMTND"].ToString();
            txbSdt.Text = data.Rows[0]["SDT"].ToString();
            dtpNgaysinh.Value = (DateTime)data.Rows[0]["NgaySinh"];
            cbGioitinh.Text = data.Rows[0]["GioiTinh"].ToString();
            txbDantoc.Text = data.Rows[0]["DanToc"].ToString();
            cbBangcap.Text = data.Rows[0]["BangCap"].ToString();
            cbMapb.Text = data.Rows[0]["MaPB"].ToString();
            txbManv.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string query = string.Format("update NHANVIEN set HoTen = N'{0}',BangCap = N'{1}',GioiTinh = N'{2}',NgaySinh = '{3}',DiaChi = N'{4}',MaPB = N'{5}',CMTND = '{6}',SDT = '{7}',DanToc = N'{8}',TonGiao = N'{9}' where MaNV = N'{10}' ",txbTennv.Text,cbBangcap.Text,cbGioitinh.Text,dtpNgaysinh.Value.ToString(),txbDiachi.Text,cbMapb.SelectedValue.ToString(),txbCccd.Text,txbSdt.Text,txbDantoc.Text,txbTongiao.Text,txbManv.Text);
                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    FormThongTinTK_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        void loadCbPB(ComboBox cb)
        {
            string query = "Select * from PHONGBAN";
            cb.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cb.ValueMember = "MaPB";
            cb.DisplayMember = "MaPB";
        }

        bool check()
        {
            if (cbBangcap.Text == "" || txbCccd.Text == "" || txbDantoc.Text == "" || txbDiachi.Text == "" || cbGioitinh.Text == "" || txbTennv.Text == "" || txbManv.Text == "" || cbMapb.Text == "" || txbSdt.Text == "" || txbTongiao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ các trường thông tin", "Cảnh báo");

            }
            else
            {
                if (Regex.IsMatch(txbSdt.Text, "\\d") == false || txbSdt.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại phải là chuỗi số có 10 số và không chứa kí tự nào ngoài 0->9", "Cảnh báo");
                }
                else if (Regex.IsMatch(txbCccd.Text, "\\d") == false /*&& (txbCccd.ToString().Length != 10 || txbCccd.ToString().Length != 12)*/)
                {
                    MessageBox.Show("Số CCCD phải là chuỗi số có 10 số hoặc 12 số và không chứa kí tự nào ngoài 0->9 " + txbCccd.Text.Length, "Cảnh báo");
                }
                else if (Regex.IsMatch(txbTennv.Text, "\\D") == false)
                {
                    MessageBox.Show("Tên phải chứa kí tự nào trong khoảng a->z hoặc A->Z", "Cảnh báo");
                }
                else if (Regex.IsMatch(cbBangcap.Text, "\\D") == false)
                {
                    MessageBox.Show("Bằng cấp phải chứa kí tự trong khoảng a->z hoặc A->Z", "Cảnh báo");
                }
                else if (Regex.IsMatch(txbDantoc.Text, "\\D") == false)
                {
                    MessageBox.Show("Dân tộc phải chứa kí tự trong khoảng a->z hoặc A->Z", "Cảnh báo");
                }
                else if (Regex.IsMatch(cbGioitinh.Text, "\\D") == false)
                {
                    MessageBox.Show("Giới tính phải chứa kí tự trong khoảng a->z hoặc A->Z", "Cảnh báo");
                }
                else if (Regex.IsMatch(txbTongiao.Text, "\\D") == false)
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
    }
}
