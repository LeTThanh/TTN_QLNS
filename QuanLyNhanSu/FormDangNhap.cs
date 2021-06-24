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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Login(txbUsername.Text, txbPass.Text))
            {
                string query = string.Format("Select MaNV from DANGNHAP where TenDN = N'{0}'",txbUsername.Text);
                Program.manvlogin = DataProvider.Instance.ExecuteScalar(query).ToString();
                Program.usernamelogin = txbUsername.Text;
                FormMain f = new FormMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
                txbPass.Clear();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Login(string username, string password)
        {
            username = txbUsername.Text;
            password = txbPass.Text;
            string query = string.Format("Select * from DANGNHAP where TenDN = N'{0}' and MatKhau = N'{1}'",username,password);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
