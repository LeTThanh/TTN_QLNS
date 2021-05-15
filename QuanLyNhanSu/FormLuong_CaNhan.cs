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
    public partial class FormLuong_CaNhan : Form
    {
        void init_Info()
        {
            using (SqlConnection con = new SqlConnection(conStr.str))
            {
                con.Open();
                string query =  "Select	n.MaNV as 'Mã NV'," +
                                "HoTen as 'Họ Tên'," +
                                "LuongCB as 'Lương Cơ Bản'," +
                                "LuongThuong as 'Lương Thưởng'," +
                                "SoNgayTangCa as 'Ngày Tăng Ca'," +
                                "GhiChu as 'Ghi Chú'," +
                                "(LuongCB + ISNULL(LuongThuong, 0) + (ISNULL(SoNgayTangCa, 0) * 50000)) as 'Tổng Lương'" +
                                "From NHANVIEN n join LUONG l on n.MaNV = l.MaNV";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                dgv_Info.DataSource = table;
            }
        }
        public FormLuong_CaNhan()
        {
            InitializeComponent();
        }

        private void FormLuong_CaNhan_Load(object sender, EventArgs e)
        {
            init_Info();
        }

        private void dgv_Info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gtb_MaNV.Text = dgv_Info.CurrentRow.Cells[0].Value.ToString();
            gtb_HoTen.Text = dgv_Info.CurrentRow.Cells[1].Value.ToString();
            gtb_LuongCB.Text = dgv_Info.CurrentRow.Cells[2].Value.ToString();
            gtb_LuongThuong.Text = dgv_Info.CurrentRow.Cells[3].Value.ToString(); 
            gtb_NgayTangCa.Text = dgv_Info.CurrentRow.Cells[4].Value.ToString();
            gtb_GhiChu.Text = dgv_Info.CurrentRow.Cells[5].Value.ToString();
            gtb_TongLuong.Text = dgv_Info.CurrentRow.Cells[6].Value.ToString();
        }

        private void gb_Search_Click(object sender, EventArgs e)
        {
            if (rb_TheoMa.Checked == true && gtb_SearchInput.Text != "")
            {
                using (SqlConnection con = new SqlConnection(conStr.str))
                {
                    con.Open();
                    string query = "Select	n.MaNV as 'Mã NV'," +
                                    "HoTen as 'Họ Tên'," +
                                    "LuongCB as 'Lương Cơ Bản'," +
                                    "LuongThuong as 'Lương Thưởng'," +
                                    "SoNgayTangCa as 'Ngày Tăng Ca'," +
                                    "GhiChu as 'Ghi Chú'," +
                                    "(LuongCB + ISNULL(LuongThuong, 0) + (ISNULL(SoNgayTangCa, 0) * 50000)) as 'Tổng Lương' " +
                                    "From NHANVIEN n join LUONG l on n.MaNV = l.MaNV " +
                                    "Where n.MaNV like '%' + '" + gtb_SearchInput.Text + "' + '%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_Info.DataSource = table;
                }
            }
            else if (rb_TheoTen.Checked == true && gtb_SearchInput.Text != "")
            {
                using (SqlConnection con = new SqlConnection(conStr.str))
                {
                    con.Open();
                    string query = "Select	n.MaNV as 'Mã NV'," +
                                    "HoTen as 'Họ Tên'," +
                                    "LuongCB as 'Lương Cơ Bản'," +
                                    "LuongThuong as 'Lương Thưởng'," +
                                    "SoNgayTangCa as 'Ngày Tăng Ca'," +
                                    "GhiChu as 'Ghi Chú'," +
                                    "(LuongCB + ISNULL(LuongThuong, 0) + (ISNULL(SoNgayTangCa, 0) * 50000)) as 'Tổng Lương' " +
                                    "From NHANVIEN n join LUONG l on n.MaNV = l.MaNV " +
                                    "Where n.HoTen like '%' + '" + gtb_SearchInput.Text + "' + '%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_Info.DataSource = table;
                }
            }
            else
                MessageBox.Show("Bạn chưa điền thông tin tìm kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gb_Edit_Click(object sender, EventArgs e)
        {
            if (gtb_MaNV.Text != "")
            {
                using (SqlConnection con = new SqlConnection(conStr.str))
                {
                    con.Open();
                    string query = "Update LUONG " +
                                    "Set LuongCB = " + gtb_LuongCB.Text + "," +
                                    "LuongThuong = " + gtb_LuongThuong.Text + "," +
                                    "SoNgayTangCa = " + gtb_NgayTangCa.Text + "," +
                                    "GhiChu = '" + gtb_GhiChu.Text + "' " +
                                    "Where MaNV = '" + gtb_MaNV.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    init_Info();
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn cá nhân để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
