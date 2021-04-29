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
    public partial class FormMain : Form
    {
        private Form activeForm = new Form();
        public FormMain()
        {
            InitializeComponent();
            customizeDesign();
            panel_Leftside.Visible = false;
        }

        private void customizeDesign()
        {
            panel_LuongSubmenu.Visible = false;
            panel_QuanLySubmenu.Visible = false;
            panel_TaiKhoanSubmenu.Visible = false;
        }
        
        private void hideSubmenu()
        {
            if (panel_QuanLySubmenu.Visible == true)
                panel_QuanLySubmenu.Visible = false;
            if (panel_LuongSubmenu.Visible == true)
                panel_LuongSubmenu.Visible = false;
            if (panel_TaiKhoanSubmenu.Visible == true)
                panel_TaiKhoanSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        
        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            position(btn_QuanLy);
            showSubmenu(panel_QuanLySubmenu);
            label4.Text = "Quản lý";
            
        }
        #region QuanLySubmenu
        private void btn_PhongBan_Click(object sender, EventArgs e)
        {
            openForm(new FormPhongBan());
            hideSubmenu();
            label4.Text = "Quản lý phòng ban";
            
        }

        private void btn_ChucVu_Click(object sender, EventArgs e)
        {
            openForm(new FormChucVu());
            hideSubmenu();
            label4.Text = "Quản lý chức vụ"; ;
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            openForm(new FormNhanVien());
            hideSubmenu();
            label4.Text = "Quản lý nhân viên";
        }

        private void btn_VTCV_Click(object sender, EventArgs e)
        {
            openForm(new FormVTCV());
            hideSubmenu();
            label4.Text = "Quản lý Vị trí công tác";
        }
        #endregion QuanLySubmenu
        private void btn_BangLuong_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_LuongSubmenu);
            position(btn_BangLuong);
            label4.Text = "Bảng lương";
        }
        #region LuongSubmenu
        private void btnBL_CaNhan_Click(object sender, EventArgs e)
        {
            openForm(new FormLuong_CaNhan());
            hideSubmenu();
            label4.Text = "Bảng lương cá nhân";
        }

        private void btnBL_PhongBan_Click(object sender, EventArgs e)
        {
            openForm(new FormLuong_PB());
            hideSubmenu();
            label4.Text = "Bảng lương phòng ban";
            
        }
        #endregion LuongSubmenu
        private void btn_HopDong_Click(object sender, EventArgs e)
        {
            openForm(new FormHopDong());
            position(btn_HopDong);
            label4.Text = "Hợp đồng";
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_TaiKhoanSubmenu);
            position(btn_TaiKhoan);
            label4.Text = "Tài khoản";
        }
        #region TaiKhoanSubmenu
        private void btnTK_DoiMK_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            label4.Text = "Đổi mật khẩu";

        }

        private void btnTK_ThemTK_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            label4.Text = "Thêm tài khoản";
        }

        private void btn_TroGiup_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            label4.Text = "Trợ giúp";
        }
        #endregion TaiKhoanSubmenu
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void position(Button b)
        {
            panel_Leftside.Visible = true;
            panel_Leftside.Location = new Point(0,b.Location.Y);
        }

        private void panel_Logo_Paint(object sender, PaintEventArgs e)
        {
            label4.Text = "Home";
        }

        public void openForm(Form form)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(form);
            panel_Main.Tag = form;
            form.BringToFront();
            form.Show();
            //lbTitleForm.Text = form.Text;
        }

        private void btnCoCauPB_Click_1(object sender, EventArgs e)
        {
            openForm(new FormCoCauPhongBan());
            label4.Text = "Cơ cấu phòng ban";
            position(btnCoCauPB);
        }
    }
}
