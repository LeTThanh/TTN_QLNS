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
    public partial class FormVTCV : Form
    {
        public string ConStr = "Data Source=localhost;Initial Catalog=QuanLyNhanSu1;Integrated Security=True";
        public FormVTCV()
        {
            InitializeComponent();
            Hienthi();
        }
         void Hienthi()
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MaVT as N'Mã vị trí', TenVT as N'Tên vị trí' FROM VITRICONGVIEC", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dtGridview1.DataSource = table;
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaVT.Text == "" || txtTenVT.Text == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm vị trí công việc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(ConStr))
                    {
                        try
                        {
                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO VITRICONGVIEC(MaVT, TenVT) VALUES (@ma, @ten)", con);
                            cmd.Parameters.AddWithValue("@ma", txtMaVT.Text);
                            cmd.Parameters.AddWithValue("@ten", txtTenVT.Text);
                            SqlDataReader reader = cmd.ExecuteReader();
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dtGridview1.DataSource = table;
                            Hienthi();
                            if (con.State == ConnectionState.Open)
                                con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa vị trí công việc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE VITRICONGVIEC SET TenVT = @ten WHERE MaVT = @ma", con);
                        cmd.Parameters.AddWithValue("@ma", txtMaVT.Text);
                        cmd.Parameters.AddWithValue("@ten", txtTenVT.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dtGridview1.DataSource = table;
                        Hienthi();
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa vị trí công việc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE VITRICONGVIEC WHERE MaVT = @ma", con);
                        cmd.Parameters.AddWithValue("@ma", txtMaVT.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dtGridview1.DataSource = table;
                        Hienthi();
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (RioBtnMa.Checked)
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("exec TK_Vitri_Ma @MaVT = @ma", con);
                        cmd.Parameters.AddWithValue("@ma", txtTK.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dtGridview1.DataSource = table;
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (RioBtnTen.Checked)
            {
                using (SqlConnection con = new SqlConnection(ConStr))
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand cmd = new SqlCommand("exec TK_Vitri_Ten @TenVT = @ten", con);
                        cmd.Parameters.AddWithValue("@ten", txtTK.Text);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Load(reader);
                        dtGridview1.DataSource = table;
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtGridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtGridview1.CurrentRow.Index;
            txtMaVT.Text = dtGridview1.Rows[i].Cells[0].Value.ToString();
            txtTenVT.Text = dtGridview1.Rows[i].Cells[1].Value.ToString();
        }
    }
}
