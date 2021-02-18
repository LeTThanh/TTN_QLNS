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
    public partial class frmLogin : Form
    {
        #region Variables
        public static string ConnectionString = "Data Source = localhost,1433; Initial Catalog = QLNS; User ID = sa; Password = admin123 ";
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void Login_Click(object sender, EventArgs e)
        {
           
                lblError.Text = "";
                //kiểm tra xem textbox tài khoản mật khẩu đã nhập hay chưa
                if (txtTenTKhoan.Text != null && txtTenTKhoan.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin tên tài khoản", "Thông báo");
                    txtTenTKhoan.Focus();
                    return;
                }
                if (txtMatKhau.Text != null && txtMatKhau.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin tên mật khẩu", "Thông báo");
                    txtMatKhau.Focus();
                    return;
                }

                // kiểm tra thông tin tài khoản so sánh với thông tin trong bảng TaiKhoan(trong dữliệu)
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string TenTKhoan = txtTenTKhoan.Text.Trim();
                string MatKhau = txtMatKhau.Text.Trim();
                string query = "SELECT * FROM TaiKhoan WHERE TenTK = '" + TenTKhoan + "' AND MatKhau = '" + MatKhau + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    frmMain _frmMain = new frmMain();
                    _frmMain.Show();
                    this.Hide();
                }
                else
                {
                    //khong tim thay
                    lblError.Text = "Thông tin tài khoản hoặc mật khẩu chưa chính xác.";
                }
            
            
            
          
        }

    }
}
