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
    public partial class FormCoCauPhongBan : Form
    {
        string connectionString = conStr.str;
        public FormCoCauPhongBan()
        {
            InitializeComponent();
            load();
        }
        #region ExcuteQuery
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try { adapter.Fill(data); }
                catch { }


                connection.Close();
            }
            return data;
        }
        #endregion
        #region ExcuteNonQuery
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int acceptedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                //thực thi câu query chả về số dòng câu truy vấn thực hiện được
                acceptedRows = -1;
                try
                {
                    acceptedRows = command.ExecuteNonQuery();
                }
                catch { }
                connection.Close();
            }

            return acceptedRows;
        }
        #endregion
        void load()
        {
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("Tất cả");
            DataTable data = new DataTable();
            data = ExecuteQuery("Select mapb from phongban");
            foreach (DataRow item in data.Rows)
            {
                guna2ComboBox1.Items.Add(item["mapb"].ToString());
            }
            guna2ComboBox1.SelectedIndex = 0;
            string que = "Select pb.tenpb, hoten, TenCV, vt.TenVT, ngaysinh, nv.diachi, gioitinh " +
            "from NHANVIEN nv left " +
            "join PHONGBAN pb on nv.MaPB = pb.MaPB left " +
            " join NHANVIEN_CHUCVU nvc on nvc.MaNV = nv.MaNV left " +
            "join CHUCVU cv on cv.MaCV = nvc.MaCV left " +
            "join NHANVIEN_VITRI nvt on nvt.MaNV = nv.MaNV left " +
            "join VITRICONGVIEC vt on vt.MaVT = nvt.MaVT " +
            "order by pb.TenPB";
            guna2DataGridView1.DataSource = ExecuteQuery(que);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex==0)
            {
                //show all
                string que = "Select pb.tenpb, hoten, TenCV, vt.TenVT, ngaysinh, nv.diachi, gioitinh " +
           "from NHANVIEN nv left " +
           "join PHONGBAN pb on nv.MaPB = pb.MaPB left " +
           " join NHANVIEN_CHUCVU nvc on nvc.MaNV = nv.MaNV left " +
           "join CHUCVU cv on cv.MaCV = nvc.MaCV left " +
           "join NHANVIEN_VITRI nvt on nvt.MaNV = nv.MaNV left " +
           "join VITRICONGVIEC vt on vt.MaVT = nvt.MaVT " +
           "order by pb.TenPB";
                guna2DataGridView1.DataSource = ExecuteQuery(que);
            }    
            else
            {
                //theo mã pb
                string que = "Select pb.tenpb, hoten, TenCV, vt.TenVT, ngaysinh, nv.diachi, gioitinh " +
           "from NHANVIEN nv left " +
           "join PHONGBAN pb on nv.MaPB = pb.MaPB left " +
           " join NHANVIEN_CHUCVU nvc on nvc.MaNV = nv.MaNV left " +
           "join CHUCVU cv on cv.MaCV = nvc.MaCV left " +
           "join NHANVIEN_VITRI nvt on nvt.MaNV = nv.MaNV left " +
           "join VITRICONGVIEC vt on vt.MaVT = nvt.MaVT " +
           "where pb.MaPB='"+guna2ComboBox1.Text+"' "+
           "order by pb.TenPB";
                guna2DataGridView1.DataSource = ExecuteQuery(que);
            }    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                //show all
                string que = "Select pb.tenpb, hoten, TenCV, vt.TenVT, ngaysinh, nv.diachi, gioitinh " +
           "from NHANVIEN nv left " +
           "join PHONGBAN pb on nv.MaPB = pb.MaPB left " +
           " join NHANVIEN_CHUCVU nvc on nvc.MaNV = nv.MaNV left " +
           "join CHUCVU cv on cv.MaCV = nvc.MaCV left " +
           "join NHANVIEN_VITRI nvt on nvt.MaNV = nv.MaNV left " +
           "join VITRICONGVIEC vt on vt.MaVT = nvt.MaVT " +
           "order by pb.TenPB";
                guna2DataGridView1.DataSource = ExecuteQuery(que);
            }
            else
            {
                //theo mã pb
                string que = "Select pb.tenpb, hoten, TenCV, vt.TenVT, ngaysinh, nv.diachi, gioitinh " +
           "from NHANVIEN nv left " +
           "join PHONGBAN pb on nv.MaPB = pb.MaPB left " +
           " join NHANVIEN_CHUCVU nvc on nvc.MaNV = nv.MaNV left " +
           "join CHUCVU cv on cv.MaCV = nvc.MaCV left " +
           "join NHANVIEN_VITRI nvt on nvt.MaNV = nv.MaNV left " +
           "join VITRICONGVIEC vt on vt.MaVT = nvt.MaVT " +
           "where pb.MaPB='" + guna2ComboBox1.Text + "' " +
           "order by pb.TenPB";
                guna2DataGridView1.DataSource = ExecuteQuery(que);
            }
        }
    }
}
