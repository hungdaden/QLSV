﻿namespace QuanLySinhVien_GUI
{
    partial class frmquanlydiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquanlydiem));
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.txtDiemKT = new System.Windows.Forms.TextBox();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.txtDiemCC = new System.Windows.Forms.TextBox();
            this.lblDiemGK = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblDiemKT = new System.Windows.Forms.Label();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblDiemCC = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.cbbMaMH = new System.Windows.Forms.ComboBox();
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.cbbMaHK = new System.Windows.Forms.ComboBox();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(304, 229);
            this.cbbMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(186, 28);
            this.cbbMaSV.TabIndex = 51;
            this.cbbMaSV.SelectedIndexChanged += new System.EventHandler(this.cbbMaSV_SelectedIndexChanged);
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(220, 565);
            this.txtDiemThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(88, 26);
            this.txtDiemThi.TabIndex = 48;
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.Location = new System.Drawing.Point(530, 565);
            this.txtDiemGK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(88, 26);
            this.txtDiemGK.TabIndex = 47;
            // 
            // txtDiemKT
            // 
            this.txtDiemKT.Location = new System.Drawing.Point(530, 448);
            this.txtDiemKT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemKT.Name = "txtDiemKT";
            this.txtDiemKT.Size = new System.Drawing.Size(88, 26);
            this.txtDiemKT.TabIndex = 49;
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Location = new System.Drawing.Point(44, 569);
            this.lblDiemThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(71, 20);
            this.lblDiemThi.TabIndex = 41;
            this.lblDiemThi.Text = "Điểm Thi";
            // 
            // txtDiemCC
            // 
            this.txtDiemCC.Location = new System.Drawing.Point(220, 448);
            this.txtDiemCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiemCC.Name = "txtDiemCC";
            this.txtDiemCC.Size = new System.Drawing.Size(88, 26);
            this.txtDiemCC.TabIndex = 50;
            // 
            // lblDiemGK
            // 
            this.lblDiemGK.AutoSize = true;
            this.lblDiemGK.Location = new System.Drawing.Point(352, 569);
            this.lblDiemGK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemGK.Name = "lblDiemGK";
            this.lblDiemGK.Size = new System.Drawing.Size(95, 20);
            this.lblDiemGK.TabIndex = 42;
            this.lblDiemGK.Text = "Điểm giữa kì";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(128, 374);
            this.lblMaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(115, 20);
            this.lblMaGV.TabIndex = 44;
            this.lblMaGV.Text = "Tên Giảng viên";
            // 
            // lblDiemKT
            // 
            this.lblDiemKT.AutoSize = true;
            this.lblDiemKT.Location = new System.Drawing.Point(352, 452);
            this.lblDiemKT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemKT.Name = "lblDiemKT";
            this.lblDiemKT.Size = new System.Drawing.Size(106, 20);
            this.lblDiemKT.TabIndex = 40;
            this.lblDiemKT.Text = "Điểm kiểm tra";
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(138, 302);
            this.lblMaMH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(104, 20);
            this.lblMaMH.TabIndex = 45;
            this.lblMaMH.Text = "Tên Môn Học";
            // 
            // lblDiemCC
            // 
            this.lblDiemCC.AutoSize = true;
            this.lblDiemCC.Location = new System.Drawing.Point(44, 452);
            this.lblDiemCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemCC.Name = "lblDiemCC";
            this.lblDiemCC.Size = new System.Drawing.Size(131, 20);
            this.lblDiemCC.TabIndex = 43;
            this.lblDiemCC.Text = "Điểm chuyên cần";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(136, 229);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(108, 20);
            this.lblMaSV.TabIndex = 46;
            this.lblMaSV.Text = "Tên Sinh Viên";
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Location = new System.Drawing.Point(202, 634);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 46);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "      Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(493, 634);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 46);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(645, 57);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.Size = new System.Drawing.Size(1246, 623);
            this.dgvKetQua.TabIndex = 37;
            this.dgvKetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellClick);
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(184, 152);
            this.lblMaHK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(59, 20);
            this.lblMaHK.TabIndex = 36;
            this.lblMaHK.Text = "Học Kỳ";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(100, 46);
            this.lblTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(457, 47);
            this.lblTittle.TabIndex = 35;
            this.lblTittle.Text = "Chức Năng Quản Lý Điểm";
            // 
            // cbbMaMH
            // 
            this.cbbMaMH.FormattingEnabled = true;
            this.cbbMaMH.Location = new System.Drawing.Point(304, 297);
            this.cbbMaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMaMH.Name = "cbbMaMH";
            this.cbbMaMH.Size = new System.Drawing.Size(186, 28);
            this.cbbMaMH.TabIndex = 51;
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(304, 369);
            this.cbbMaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(186, 28);
            this.cbbMaGV.TabIndex = 51;
            // 
            // cbbMaHK
            // 
            this.cbbMaHK.FormattingEnabled = true;
            this.cbbMaHK.Location = new System.Drawing.Point(304, 152);
            this.cbbMaHK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMaHK.Name = "cbbMaHK";
            this.cbbMaHK.Size = new System.Drawing.Size(186, 28);
            this.cbbMaHK.TabIndex = 51;
            this.cbbMaHK.SelectedIndexChanged += new System.EventHandler(this.cbbMaSV_SelectedIndexChanged);
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Location = new System.Drawing.Point(640, 712);
            this.lblTongSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(0, 20);
            this.lblTongSo.TabIndex = 36;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(341, 634);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 46);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmquanlydiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1910, 749);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbbMaGV);
            this.Controls.Add(this.cbbMaMH);
            this.Controls.Add(this.cbbMaHK);
            this.Controls.Add(this.cbbMaSV);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.txtDiemGK);
            this.Controls.Add(this.txtDiemKT);
            this.Controls.Add(this.lblDiemThi);
            this.Controls.Add(this.txtDiemCC);
            this.Controls.Add(this.lblDiemGK);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblDiemKT);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.lblDiemCC);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.lblTittle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmquanlydiem";
            this.Text = "QUẢN LÝ ĐIỂM";
            this.Load += new System.EventHandler(this.quanlydiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiemGK;
        private System.Windows.Forms.TextBox txtDiemKT;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.TextBox txtDiemCC;
        private System.Windows.Forms.Label lblDiemGK;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblDiemKT;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblDiemCC;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.ComboBox cbbMaMH;
        private System.Windows.Forms.ComboBox cbbMaGV;
        private System.Windows.Forms.ComboBox cbbMaHK;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Button btnXoa;
    }
}