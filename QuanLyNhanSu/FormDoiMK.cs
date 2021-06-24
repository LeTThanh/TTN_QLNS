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
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
            txbUsername.Text = Program.usernamelogin;
            txbUsername.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            status.ForeColor = Color.Red;
            if (Login(txbUsername.Text, txbPassOld.Text) == false)
            {
                status.Text = "Sai mật khẩu!!";
                return;
            }
            if (txbPassNew.Text == "" || txbPassNewre.Text == "")
            {
                status.Text = "Bạn chưa nhập mật khẩu mới ";
                return;
            }
            else if (txbPassNew.Text != txbPassNewre.Text)
            {
                status.Text = "Mật khẩu nhập lại không trùng khớp !!";
                return;
            }
            else if (txbPassNew.Text == txbPassNewre.Text)
            {
                status.Text = "";
                string query = string.Format("update dbo.DANGNHAP set MatKhau = N'{0}' where TenDN = N'{1}'",txbPassNew.Text,txbUsername.Text);
                if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public bool Login(string username, string password)
        {
            username = txbUsername.Text;
            password = txbPassOld.Text;
            string query = string.Format("Select * from DANGNHAP where TenDN = N'{0}' and MatKhau = N'{1}'", username, password);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
