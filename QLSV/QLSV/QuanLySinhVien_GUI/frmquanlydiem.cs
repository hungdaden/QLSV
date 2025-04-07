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
using DevComponents.DotNetBar;
namespace QuanLySinhVien_GUI
{
    public partial class frmquanlydiem : Office2007Form
    {
        public frmquanlydiem()
        {
            InitializeComponent();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbbMaMH.Text))
                {
                    MessageBox.Show("Vui lòng chọn môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                QuanLySinhVien_BLL.Diem.Nhap_Diem(
                    cbbMaSV.SelectedValue.ToString(),
                    cbbMaMH.SelectedValue.ToString(),
                    float.Parse(txtDiemCC.Text),
                    float.Parse(txtDiemKT.Text),
                    float.Parse(txtDiemGK.Text),
                    float.Parse(txtDiemThi.Text),
                    cbbMaGV.SelectedValue.ToString(),
                    cbbMaHK.SelectedValue.ToString()
                );

                // Refresh dữ liệu
                dgvKetQua.DataSource = QuanLySinhVien_DAL.Data.DS_DIEM();
                dem = dgvKetQua.RowCount;
                lblTongSo.Text = "Tổng Số: " + dem.ToString();

                MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Đã tồn tại điểm"))
                {
                    // Hỏi người dùng có muốn cập nhật điểm không
                    var result = MessageBox.Show("Đã có điểm môn này. Bạn có muốn cập nhật điểm mới không?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Gọi phương thức cập nhật điểm
                        CapNhatDiem();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CapNhatDiem()
        {
            try
            {
                float diemtb = (float)(float.Parse(txtDiemCC.Text) + float.Parse(txtDiemKT.Text) +
                              float.Parse(txtDiemGK.Text) * 3 + float.Parse(txtDiemThi.Text) * 5) / 10;

                using (SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE DIEM SET " +
                        "DiemCC = @diemcc, " +
                        "DiemKT = @diemkt, " +
                        "DiemGK = @diemgk, " +
                        "DiemThi = @diemthi, " +
                        "DiemTB = @diemtb, " +
                        "MaGV = @magv, " +
                        "MaHK = @mahk " +
                        "WHERE MaSV = @masv AND MaMH = @mamh",
                        con);

                    cmd.Parameters.AddWithValue("@masv", cbbMaSV.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@mamh", cbbMaMH.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@diemcc", float.Parse(txtDiemCC.Text));
                    cmd.Parameters.AddWithValue("@diemkt", float.Parse(txtDiemKT.Text));
                    cmd.Parameters.AddWithValue("@diemgk", float.Parse(txtDiemGK.Text));
                    cmd.Parameters.AddWithValue("@diemthi", float.Parse(txtDiemThi.Text));
                    cmd.Parameters.AddWithValue("@diemtb", diemtb);
                    cmd.Parameters.AddWithValue("@magv", cbbMaGV.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@mahk", cbbMaHK.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                }

                // Refresh dữ liệu
                dgvKetQua.DataSource = QuanLySinhVien_DAL.Data.DS_DIEM();
                MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int dem = 0;
        private void quanlydiem_Load(object sender, EventArgs e)
        {
            cbbMaHK.DataSource = QuanLySinhVien_DAL.Data.DS_HOCKY();
            cbbMaHK.DisplayMember = "MaHK";
            cbbMaHK.ValueMember = "MaHK";

            cbbMaGV.DataSource = QuanLySinhVien_DAL.Data.DS_GIANGVIEN();
            cbbMaGV.DisplayMember = "MaGV";
            cbbMaGV.ValueMember = "MaGV";

            cbbMaMH.DataSource = QuanLySinhVien_DAL.Data.DS_MONHOC();
            cbbMaMH.DisplayMember = "MaMH";
            cbbMaMH.ValueMember = "MaMH";

            cbbMaSV.DataSource = QuanLySinhVien_DAL.Data.DS_SINHVIEN1();
            cbbMaSV.DisplayMember = "MaSV";
            cbbMaSV.ValueMember = "MaSV";

            dgvKetQua.DataSource = QuanLySinhVien_DAL.Data.DS_DIEM();
            dem = dgvKetQua.RowCount;
            lblTongSo.Text = "Tổng Số: " + dem.ToString();
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;

            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        int row;
        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            cbbMaHK.Text = dgvKetQua.Rows[row].Cells[8].Value.ToString();
            cbbMaSV.Text = dgvKetQua.Rows[row].Cells[0].Value.ToString();
            cbbMaMH.Text = dgvKetQua.Rows[row].Cells[1].Value.ToString();
            cbbMaGV.Text = dgvKetQua.Rows[row].Cells[7].Value.ToString();
            txtDiemCC.Text = dgvKetQua.Rows[row].Cells[2].Value.ToString();
            txtDiemKT.Text = dgvKetQua.Rows[row].Cells[3].Value.ToString();
            txtDiemGK.Text = dgvKetQua.Rows[row].Cells[4].Value.ToString();
            txtDiemThi.Text = dgvKetQua.Rows[row].Cells[5].Value.ToString();
            
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            cbbMaHK.Text = dgvKetQua.Rows[row].Cells[8].Value.ToString();
            cbbMaSV.Text = dgvKetQua.Rows[row].Cells[0].Value.ToString();
            cbbMaMH.Text = dgvKetQua.Rows[row].Cells[1].Value.ToString();
            cbbMaGV.Text = dgvKetQua.Rows[row].Cells[7].Value.ToString();
            txtDiemCC.Text = dgvKetQua.Rows[row].Cells[2].Value.ToString();
            txtDiemKT.Text = dgvKetQua.Rows[row].Cells[3].Value.ToString();
            txtDiemGK.Text = dgvKetQua.Rows[row].Cells[4].Value.ToString();
            txtDiemThi.Text = dgvKetQua.Rows[row].Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.DialogResult rs;

                if (cbbMaSV.SelectedItem == "")
                {
                    MessageBox.Show("Vui lòng chọn Sinh Viên cần xóa", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    rs = MessageBox.Show("Bạn chắc chắn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == System.Windows.Forms.DialogResult.Yes)
                    {
                        //hàm xóa dữ liệu
                        QuanLySinhVien_BLL.Diem.Xoa_Diem(cbbMaSV.SelectedValue.ToString()); 
                        MessageBox.Show("Xóa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvKetQua.DataSource = QuanLySinhVien_DAL.Data.DS_DIEM();
                        dem = dgvKetQua.RowCount;
                        lblTongSo.Text = "Tổng Số: " + dem.ToString();
                    }
                }


            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
