using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormThemTK : Form
    {
        public FormThemTK()
        {
            InitializeComponent();
            LoadCB(cbMaNV);
        }

        void LoadCB(ComboBox cb)
        {
            string query = "Select MaNV from NHANVIEN";
            cb.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cb.ValueMember = "MaNV";
            cb.DisplayMember = "MaNV";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            status.ForeColor = Color.Red;
            if(txbUsername.Text == ""|| txbPass.Text == ""|| txbPassRe.Text == "")
            {
                status.Text = "Mời bạn nhập đủ thông tin tài khoản!";
            }
            else
            {
                if (txbPass.Text != txbPassRe.Text)
                {
                    status.Text = "Mật khẩu không trùng khớp!";
                }
                else if (txbPass.Text == txbPassRe.Text)
                {
                    //string query = string.Format("Select MaNV from DANGNHAP where MaNV = N'{0}'", cbMaNV.SelectedValue.ToString());
                    //if (DataProvider.Instance.ExecuteScalar(query) == null)
                    //{
                        status.Text = "";
                        string query1 = string.Format("insert into dbo.DANGNHAP(TenDN,MatKhau,MaNV) values(N'{0}',N'{1}','{2}')", txbUsername.Text, txbPass.Text, cbMaNV.SelectedValue.ToString());
                        if (DataProvider.Instance.ExecuteNonQuery(query1) > 0)
                        {
                            MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập trùng với tên đăng nhập đã có!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    //}
                    //else
                    //{
                    //    status.Text = "Mã nhân viên trùng với mã nhân viên đã có tài khoản!!";
                    //}
                    
                }
            }
        }
    }
}
