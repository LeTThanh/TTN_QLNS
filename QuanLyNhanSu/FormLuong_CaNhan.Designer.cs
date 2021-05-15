
namespace QuanLyNhanSu
{
    partial class FormLuong_CaNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gtb_SearchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.gb_Search = new Guna.UI2.WinForms.Guna2Button();
            this.rb_TheoTen = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_TheoMa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gtb_GhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtb_NgayTangCa = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gtb_TongLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gtb_LuongThuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtb_LuongCB = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtb_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtb_MaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Info = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gb_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gtb_SearchInput);
            this.panel1.Controls.Add(this.gb_Search);
            this.panel1.Controls.Add(this.rb_TheoTen);
            this.panel1.Controls.Add(this.rb_TheoMa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(606, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 161);
            this.panel1.TabIndex = 27;
            // 
            // gtb_SearchInput
            // 
            this.gtb_SearchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_SearchInput.DefaultText = "";
            this.gtb_SearchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_SearchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_SearchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_SearchInput.DisabledState.Parent = this.gtb_SearchInput;
            this.gtb_SearchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_SearchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_SearchInput.FocusedState.Parent = this.gtb_SearchInput;
            this.gtb_SearchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_SearchInput.HoverState.Parent = this.gtb_SearchInput;
            this.gtb_SearchInput.Location = new System.Drawing.Point(107, 22);
            this.gtb_SearchInput.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.gtb_SearchInput.Name = "gtb_SearchInput";
            this.gtb_SearchInput.PasswordChar = '\0';
            this.gtb_SearchInput.PlaceholderText = "";
            this.gtb_SearchInput.SelectedText = "";
            this.gtb_SearchInput.ShadowDecoration.Parent = this.gtb_SearchInput;
            this.gtb_SearchInput.Size = new System.Drawing.Size(172, 25);
            this.gtb_SearchInput.TabIndex = 14;
            // 
            // gb_Search
            // 
            this.gb_Search.CheckedState.Parent = this.gb_Search;
            this.gb_Search.CustomImages.Parent = this.gb_Search;
            this.gb_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_Search.ForeColor = System.Drawing.Color.White;
            this.gb_Search.HoverState.Parent = this.gb_Search;
            this.gb_Search.Location = new System.Drawing.Point(107, 111);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.ShadowDecoration.Parent = this.gb_Search;
            this.gb_Search.Size = new System.Drawing.Size(132, 35);
            this.gb_Search.TabIndex = 13;
            this.gb_Search.Text = "Tìm kiếm ";
            this.gb_Search.Click += new System.EventHandler(this.gb_Search_Click);
            // 
            // rb_TheoTen
            // 
            this.rb_TheoTen.AutoSize = true;
            this.rb_TheoTen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_TheoTen.CheckedState.BorderThickness = 0;
            this.rb_TheoTen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_TheoTen.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_TheoTen.CheckedState.InnerOffset = -4;
            this.rb_TheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TheoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.rb_TheoTen.Location = new System.Drawing.Point(179, 68);
            this.rb_TheoTen.Name = "rb_TheoTen";
            this.rb_TheoTen.Size = new System.Drawing.Size(84, 22);
            this.rb_TheoTen.TabIndex = 12;
            this.rb_TheoTen.Text = "Theo tên";
            this.rb_TheoTen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_TheoTen.UncheckedState.BorderThickness = 2;
            this.rb_TheoTen.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_TheoTen.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rb_TheoMa
            // 
            this.rb_TheoMa.AutoSize = true;
            this.rb_TheoMa.Checked = true;
            this.rb_TheoMa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_TheoMa.CheckedState.BorderThickness = 0;
            this.rb_TheoMa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_TheoMa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_TheoMa.CheckedState.InnerOffset = -4;
            this.rb_TheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TheoMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.rb_TheoMa.Location = new System.Drawing.Point(66, 68);
            this.rb_TheoMa.Name = "rb_TheoMa";
            this.rb_TheoMa.Size = new System.Drawing.Size(85, 22);
            this.rb_TheoMa.TabIndex = 11;
            this.rb_TheoMa.TabStop = true;
            this.rb_TheoMa.Text = "Theo mã";
            this.rb_TheoMa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_TheoMa.UncheckedState.BorderThickness = 2;
            this.rb_TheoMa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_TheoMa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm kiếm :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb_Edit);
            this.groupBox1.Controls.Add(this.gtb_GhiChu);
            this.groupBox1.Controls.Add(this.gtb_NgayTangCa);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.gtb_TongLuong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.gtb_LuongThuong);
            this.groupBox1.Controls.Add(this.gtb_LuongCB);
            this.groupBox1.Controls.Add(this.gtb_HoTen);
            this.groupBox1.Controls.Add(this.gtb_MaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 160);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lương theo cá nhân";
            // 
            // gtb_GhiChu
            // 
            this.gtb_GhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_GhiChu.DefaultText = "";
            this.gtb_GhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_GhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_GhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_GhiChu.DisabledState.Parent = this.gtb_GhiChu;
            this.gtb_GhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_GhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_GhiChu.FocusedState.Parent = this.gtb_GhiChu;
            this.gtb_GhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_GhiChu.HoverState.Parent = this.gtb_GhiChu;
            this.gtb_GhiChu.Location = new System.Drawing.Point(134, 120);
            this.gtb_GhiChu.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.gtb_GhiChu.Name = "gtb_GhiChu";
            this.gtb_GhiChu.PasswordChar = '\0';
            this.gtb_GhiChu.PlaceholderText = "";
            this.gtb_GhiChu.SelectedText = "";
            this.gtb_GhiChu.ShadowDecoration.Parent = this.gtb_GhiChu;
            this.gtb_GhiChu.Size = new System.Drawing.Size(150, 25);
            this.gtb_GhiChu.TabIndex = 37;
            // 
            // gtb_NgayTangCa
            // 
            this.gtb_NgayTangCa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_NgayTangCa.DefaultText = "";
            this.gtb_NgayTangCa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_NgayTangCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_NgayTangCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_NgayTangCa.DisabledState.Parent = this.gtb_NgayTangCa;
            this.gtb_NgayTangCa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_NgayTangCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_NgayTangCa.FocusedState.Parent = this.gtb_NgayTangCa;
            this.gtb_NgayTangCa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_NgayTangCa.HoverState.Parent = this.gtb_NgayTangCa;
            this.gtb_NgayTangCa.Location = new System.Drawing.Point(436, 82);
            this.gtb_NgayTangCa.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.gtb_NgayTangCa.Name = "gtb_NgayTangCa";
            this.gtb_NgayTangCa.PasswordChar = '\0';
            this.gtb_NgayTangCa.PlaceholderText = "";
            this.gtb_NgayTangCa.SelectedText = "";
            this.gtb_NgayTangCa.ShadowDecoration.Parent = this.gtb_NgayTangCa;
            this.gtb_NgayTangCa.Size = new System.Drawing.Size(150, 25);
            this.gtb_NgayTangCa.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label12.Location = new System.Drawing.Point(322, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Số ngày tăng ca:";
            // 
            // gtb_TongLuong
            // 
            this.gtb_TongLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_TongLuong.DefaultText = "";
            this.gtb_TongLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_TongLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_TongLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_TongLuong.DisabledState.Parent = this.gtb_TongLuong;
            this.gtb_TongLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_TongLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_TongLuong.FocusedState.Parent = this.gtb_TongLuong;
            this.gtb_TongLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_TongLuong.HoverState.Parent = this.gtb_TongLuong;
            this.gtb_TongLuong.Location = new System.Drawing.Point(436, 12);
            this.gtb_TongLuong.Margin = new System.Windows.Forms.Padding(5);
            this.gtb_TongLuong.Name = "gtb_TongLuong";
            this.gtb_TongLuong.PasswordChar = '\0';
            this.gtb_TongLuong.PlaceholderText = "";
            this.gtb_TongLuong.SelectedText = "";
            this.gtb_TongLuong.ShadowDecoration.Parent = this.gtb_TongLuong;
            this.gtb_TongLuong.Size = new System.Drawing.Size(150, 25);
            this.gtb_TongLuong.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label11.Location = new System.Drawing.Point(322, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tổng lương:";
            // 
            // gtb_LuongThuong
            // 
            this.gtb_LuongThuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_LuongThuong.DefaultText = "";
            this.gtb_LuongThuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_LuongThuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_LuongThuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_LuongThuong.DisabledState.Parent = this.gtb_LuongThuong;
            this.gtb_LuongThuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_LuongThuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_LuongThuong.FocusedState.Parent = this.gtb_LuongThuong;
            this.gtb_LuongThuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_LuongThuong.HoverState.Parent = this.gtb_LuongThuong;
            this.gtb_LuongThuong.Location = new System.Drawing.Point(134, 82);
            this.gtb_LuongThuong.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gtb_LuongThuong.Name = "gtb_LuongThuong";
            this.gtb_LuongThuong.PasswordChar = '\0';
            this.gtb_LuongThuong.PlaceholderText = "";
            this.gtb_LuongThuong.SelectedText = "";
            this.gtb_LuongThuong.ShadowDecoration.Parent = this.gtb_LuongThuong;
            this.gtb_LuongThuong.Size = new System.Drawing.Size(150, 25);
            this.gtb_LuongThuong.TabIndex = 8;
            // 
            // gtb_LuongCB
            // 
            this.gtb_LuongCB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_LuongCB.DefaultText = "";
            this.gtb_LuongCB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_LuongCB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_LuongCB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_LuongCB.DisabledState.Parent = this.gtb_LuongCB;
            this.gtb_LuongCB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_LuongCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_LuongCB.FocusedState.Parent = this.gtb_LuongCB;
            this.gtb_LuongCB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_LuongCB.HoverState.Parent = this.gtb_LuongCB;
            this.gtb_LuongCB.Location = new System.Drawing.Point(436, 46);
            this.gtb_LuongCB.Margin = new System.Windows.Forms.Padding(5);
            this.gtb_LuongCB.Name = "gtb_LuongCB";
            this.gtb_LuongCB.PasswordChar = '\0';
            this.gtb_LuongCB.PlaceholderText = "";
            this.gtb_LuongCB.SelectedText = "";
            this.gtb_LuongCB.ShadowDecoration.Parent = this.gtb_LuongCB;
            this.gtb_LuongCB.Size = new System.Drawing.Size(150, 25);
            this.gtb_LuongCB.TabIndex = 7;
            // 
            // gtb_HoTen
            // 
            this.gtb_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_HoTen.DefaultText = "";
            this.gtb_HoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_HoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_HoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_HoTen.DisabledState.Parent = this.gtb_HoTen;
            this.gtb_HoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_HoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_HoTen.FocusedState.Parent = this.gtb_HoTen;
            this.gtb_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_HoTen.HoverState.Parent = this.gtb_HoTen;
            this.gtb_HoTen.Location = new System.Drawing.Point(134, 46);
            this.gtb_HoTen.Margin = new System.Windows.Forms.Padding(5);
            this.gtb_HoTen.Name = "gtb_HoTen";
            this.gtb_HoTen.PasswordChar = '\0';
            this.gtb_HoTen.PlaceholderText = "";
            this.gtb_HoTen.SelectedText = "";
            this.gtb_HoTen.ShadowDecoration.Parent = this.gtb_HoTen;
            this.gtb_HoTen.Size = new System.Drawing.Size(150, 25);
            this.gtb_HoTen.TabIndex = 6;
            // 
            // gtb_MaNV
            // 
            this.gtb_MaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_MaNV.DefaultText = "";
            this.gtb_MaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtb_MaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtb_MaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_MaNV.DisabledState.Parent = this.gtb_MaNV;
            this.gtb_MaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtb_MaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_MaNV.FocusedState.Parent = this.gtb_MaNV;
            this.gtb_MaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtb_MaNV.HoverState.Parent = this.gtb_MaNV;
            this.gtb_MaNV.Location = new System.Drawing.Point(134, 12);
            this.gtb_MaNV.Margin = new System.Windows.Forms.Padding(4);
            this.gtb_MaNV.Name = "gtb_MaNV";
            this.gtb_MaNV.PasswordChar = '\0';
            this.gtb_MaNV.PlaceholderText = "";
            this.gtb_MaNV.SelectedText = "";
            this.gtb_MaNV.ShadowDecoration.Parent = this.gtb_MaNV;
            this.gtb_MaNV.Size = new System.Drawing.Size(150, 25);
            this.gtb_MaNV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(19, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương thưởng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(322, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương cơ bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // dgv_Info
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_Info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Info.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Info.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Info.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Info.EnableHeadersVisualStyles = false;
            this.dgv_Info.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Info.Location = new System.Drawing.Point(6, 178);
            this.dgv_Info.Name = "dgv_Info";
            this.dgv_Info.RowHeadersVisible = false;
            this.dgv_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Info.Size = new System.Drawing.Size(927, 330);
            this.dgv_Info.TabIndex = 25;
            this.dgv_Info.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Info.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Info.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Info.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Info.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Info.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Info.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_Info.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Info.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Info.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Info.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Info.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Info.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Info.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_Info.ThemeStyle.ReadOnly = false;
            this.dgv_Info.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Info.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Info.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Info.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Info.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Info.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Info.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Info_CellClick);
            // 
            // gb_Edit
            // 
            this.gb_Edit.CheckedState.Parent = this.gb_Edit;
            this.gb_Edit.CustomImages.Parent = this.gb_Edit;
            this.gb_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_Edit.ForeColor = System.Drawing.Color.White;
            this.gb_Edit.HoverState.Parent = this.gb_Edit;
            this.gb_Edit.Location = new System.Drawing.Point(362, 119);
            this.gb_Edit.Name = "gb_Edit";
            this.gb_Edit.ShadowDecoration.Parent = this.gb_Edit;
            this.gb_Edit.Size = new System.Drawing.Size(170, 35);
            this.gb_Edit.TabIndex = 28;
            this.gb_Edit.Text = "Sửa";
            this.gb_Edit.Click += new System.EventHandler(this.gb_Edit_Click);
            // 
            // FormLuong_CaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Info);
            this.Name = "FormLuong_CaNhan";
            this.Text = "Lương Cá Nhân";
            this.Load += new System.EventHandler(this.FormLuong_CaNhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox gtb_SearchInput;
        private Guna.UI2.WinForms.Guna2Button gb_Search;
        private Guna.UI2.WinForms.Guna2RadioButton rb_TheoTen;
        private Guna.UI2.WinForms.Guna2RadioButton rb_TheoMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox gtb_NgayTangCa;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox gtb_TongLuong;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox gtb_LuongThuong;
        private Guna.UI2.WinForms.Guna2TextBox gtb_LuongCB;
        private Guna.UI2.WinForms.Guna2TextBox gtb_HoTen;
        private Guna.UI2.WinForms.Guna2TextBox gtb_MaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Info;
        private Guna.UI2.WinForms.Guna2TextBox gtb_GhiChu;
        private Guna.UI2.WinForms.Guna2Button gb_Edit;
    }
}