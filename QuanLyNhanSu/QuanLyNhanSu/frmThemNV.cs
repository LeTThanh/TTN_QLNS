﻿using System;
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
    public partial class frmThemNV : Form
    {
        SqlConnection con = new SqlConnection(ConnectionClass.cs);
        public frmThemNV()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string id = textbox_MaNV.Text;
            string name = textbox_HoTen.Text;
            string dantoc = textbox_DanToc.Text;
            string gioiTinh = textbox_GioiTinh.Text;
            string sdt = textbox_SDT.Text;
            string queQuan = textbox_QueQuan.Text;
            DateTime ngaySinh = Convert.ToDateTime(textbox_NgaySinh.Text);
            string maTDHV = textbox_MaTDHV.Text;
            string maPB = textbox_MaPhongBan.Text;
            int bacLuong = Int32.Parse(textbox_BacLuong.Text);
            string maChucVu = textbox_MaChucVu.Text;
            string tenTK = textbox_TenTK.Text;
            try
            {
                string queryStr = "INSERT INTO NhanVien(MaNV, HoTen, DanToc, GioiTinh, SDT, QueQuan, NgaySinh, MaTDHV, MaPB, BacLuong, MaChucVu, TenTK)"
                                + "VALUES(" + id
                                + ",'" + name
                                + "','" + dantoc
                                + "','" + gioiTinh
                                + "'," + sdt
                                + ",'" + queQuan
                                + "','" + ngaySinh
                                + "'," + maTDHV
                                + "," + maPB
                                + "," + bacLuong
                                + "," + maChucVu
                                + ",'" + tenTK + "')";
                SqlCommand cmd = new SqlCommand(queryStr, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            con.Open();
            if (con.State == ConnectionState.Open) MessageBox.Show("Kết nối thành công!");
            else MessageBox.Show("Không thể kết nối tới Database");
        }
    }
}
