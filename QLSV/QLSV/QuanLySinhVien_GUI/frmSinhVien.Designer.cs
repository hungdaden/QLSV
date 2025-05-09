﻿namespace QuanLySinhVien_GUI
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.lblMaLop = new System.Windows.Forms.Label();
            this.blNgaySinh = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongso = new System.Windows.Forms.Label();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(1376, 418);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(36, 20);
            this.lblMaLop.TabIndex = 59;
            this.lblMaLop.Text = "Lớp";
            // 
            // blNgaySinh
            // 
            this.blNgaySinh.AutoSize = true;
            this.blNgaySinh.Location = new System.Drawing.Point(1329, 345);
            this.blNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blNgaySinh.Name = "blNgaySinh";
            this.blNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.blNgaySinh.TabIndex = 60;
            this.blNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(1348, 200);
            this.lblTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(62, 20);
            this.lblTenSV.TabIndex = 61;
            this.lblTenSV.Text = "Tên SV";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(1354, 63);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(57, 20);
            this.lblMaSV.TabIndex = 62;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(136, 9);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(362, 47);
            this.lblTittle.TabIndex = 63;
            this.lblTittle.Text = "Danh Mục Sinh Viên";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(26, 80);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.Size = new System.Drawing.Size(1278, 477);
            this.dgvSinhVien.TabIndex = 58;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(1473, 340);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(254, 26);
            this.dtpNgaySinh.TabIndex = 57;
            this.dtpNgaySinh.Value = new System.DateTime(1995, 1, 1, 22, 3, 0, 0);
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DisplayMember = "MaLop";
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(1473, 414);
            this.cmbMaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(254, 28);
            this.cmbMaLop.TabIndex = 56;
            this.cmbMaLop.ValueMember = "MaLop";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(1473, 195);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(254, 26);
            this.txtTenSV.TabIndex = 54;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(1473, 58);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(254, 26);
            this.txtMaSV.TabIndex = 55;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(1773, 551);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 46);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(1332, 551);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 46);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(1622, 551);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 46);
            this.btnXoa.TabIndex = 53;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(1473, 551);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 46);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DisplayMember = "MaLop";
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(1473, 485);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(254, 28);
            this.cbbKhoa.TabIndex = 56;
            this.cbbKhoa.ValueMember = "MaLop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1365, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Khoa";
            // 
            // lblTongso
            // 
            this.lblTongso.AutoSize = true;
            this.lblTongso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongso.ForeColor = System.Drawing.Color.Red;
            this.lblTongso.Location = new System.Drawing.Point(21, 574);
            this.lblTongso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongso.Name = "lblTongso";
            this.lblTongso.Size = new System.Drawing.Size(0, 29);
            this.lblTongso.TabIndex = 62;
            // 
            // txtHoSV
            // 
            this.txtHoSV.Location = new System.Drawing.Point(1473, 128);
            this.txtHoSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(254, 26);
            this.txtHoSV.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1356, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Họ SV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Location = new System.Drawing.Point(1332, 249);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(398, 77);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(290, 42);
            this.radNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(54, 24);
            this.radNu.TabIndex = 0;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(141, 42);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(67, 24);
            this.radNam.TabIndex = 0;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1910, 657);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.blNgaySinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.lblTongso);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSinhVien";
            this.Text = "DANH MỤC SINH VIÊN";
            this.Load += new System.EventHandler(this.formsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label blNgaySinh;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongso;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
    }
}