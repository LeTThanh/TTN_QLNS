
namespace QuanLyNhanSu
{
    partial class Formtimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formtimkiem));
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            this.dataGridView_timkiem = new System.Windows.Forms.DataGridView();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Tennv = new System.Windows.Forms.RadioButton();
            this.radioButton_tenpb = new System.Windows.Forms.RadioButton();
            this.radioButton_chucvu = new System.Windows.Forms.RadioButton();
            this.radioButton_mapb = new System.Windows.Forms.RadioButton();
            this.radioButton_manv = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timkiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_timkiem
            // 
            this.textBox_timkiem.Location = new System.Drawing.Point(13, 13);
            this.textBox_timkiem.Multiline = true;
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.Size = new System.Drawing.Size(303, 109);
            this.textBox_timkiem.TabIndex = 0;
            // 
            // dataGridView_timkiem
            // 
            this.dataGridView_timkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_timkiem.Location = new System.Drawing.Point(13, 280);
            this.dataGridView_timkiem.Name = "dataGridView_timkiem";
            this.dataGridView_timkiem.RowHeadersWidth = 51;
            this.dataGridView_timkiem.RowTemplate.Height = 24;
            this.dataGridView_timkiem.Size = new System.Drawing.Size(982, 292);
            this.dataGridView_timkiem.TabIndex = 1;
            // 
            // button_timkiem
            // 
            this.button_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("button_timkiem.Image")));
            this.button_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_timkiem.Location = new System.Drawing.Point(13, 158);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(158, 50);
            this.button_timkiem.TabIndex = 2;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton_manv);
            this.panel1.Controls.Add(this.radioButton_mapb);
            this.panel1.Controls.Add(this.radioButton_chucvu);
            this.panel1.Controls.Add(this.radioButton_tenpb);
            this.panel1.Controls.Add(this.radioButton_Tennv);
            this.panel1.Location = new System.Drawing.Point(575, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 179);
            this.panel1.TabIndex = 4;
            // 
            // radioButton_Tennv
            // 
            this.radioButton_Tennv.AutoSize = true;
            this.radioButton_Tennv.Location = new System.Drawing.Point(39, 28);
            this.radioButton_Tennv.Name = "radioButton_Tennv";
            this.radioButton_Tennv.Size = new System.Drawing.Size(122, 21);
            this.radioButton_Tennv.TabIndex = 0;
            this.radioButton_Tennv.TabStop = true;
            this.radioButton_Tennv.Text = "Tên Nhân viên";
            this.radioButton_Tennv.UseVisualStyleBackColor = true;
            // 
            // radioButton_tenpb
            // 
            this.radioButton_tenpb.AutoSize = true;
            this.radioButton_tenpb.Location = new System.Drawing.Point(215, 77);
            this.radioButton_tenpb.Name = "radioButton_tenpb";
            this.radioButton_tenpb.Size = new System.Drawing.Size(126, 21);
            this.radioButton_tenpb.TabIndex = 1;
            this.radioButton_tenpb.TabStop = true;
            this.radioButton_tenpb.Text = "Tên phòng ban";
            this.radioButton_tenpb.UseVisualStyleBackColor = true;
            // 
            // radioButton_chucvu
            // 
            this.radioButton_chucvu.AutoSize = true;
            this.radioButton_chucvu.Location = new System.Drawing.Point(215, 135);
            this.radioButton_chucvu.Name = "radioButton_chucvu";
            this.radioButton_chucvu.Size = new System.Drawing.Size(80, 21);
            this.radioButton_chucvu.TabIndex = 2;
            this.radioButton_chucvu.TabStop = true;
            this.radioButton_chucvu.Text = "Chức vụ";
            this.radioButton_chucvu.UseVisualStyleBackColor = true;
            // 
            // radioButton_mapb
            // 
            this.radioButton_mapb.AutoSize = true;
            this.radioButton_mapb.Location = new System.Drawing.Point(39, 135);
            this.radioButton_mapb.Name = "radioButton_mapb";
            this.radioButton_mapb.Size = new System.Drawing.Size(120, 21);
            this.radioButton_mapb.TabIndex = 3;
            this.radioButton_mapb.TabStop = true;
            this.radioButton_mapb.Text = "Mã phòng ban";
            this.radioButton_mapb.UseVisualStyleBackColor = true;
            // 
            // radioButton_manv
            // 
            this.radioButton_manv.AutoSize = true;
            this.radioButton_manv.Location = new System.Drawing.Point(39, 77);
            this.radioButton_manv.Name = "radioButton_manv";
            this.radioButton_manv.Size = new System.Drawing.Size(116, 21);
            this.radioButton_manv.TabIndex = 4;
            this.radioButton_manv.TabStop = true;
            this.radioButton_manv.Text = "Mã Nhân viên";
            this.radioButton_manv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // Formtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1007, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.dataGridView_timkiem);
            this.Controls.Add(this.textBox_timkiem);
            this.Name = "Formtimkiem";
            this.Text = "Formtimkiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timkiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_timkiem;
        private System.Windows.Forms.DataGridView dataGridView_timkiem;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_manv;
        private System.Windows.Forms.RadioButton radioButton_mapb;
        private System.Windows.Forms.RadioButton radioButton_chucvu;
        private System.Windows.Forms.RadioButton radioButton_tenpb;
        private System.Windows.Forms.RadioButton radioButton_Tennv;
        private System.Windows.Forms.Label label1;
    }
}