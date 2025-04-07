using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien_BLL
{
    public class Diem
    {
        public static void Nhap_Diem(string masv, string mamh, float diemcc, float diemkt, float diemgk, float diemthi, string magv, string mahk)
        {
            float diemtb = (float)(diemcc + diemkt + diemgk * 3 + diemthi * 5) / 10;

            using (SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon))
            {
                con.Open();

                // Kiểm tra trùng cả MaSV và MaMH (nếu khóa chính gồm cả 2 trường)
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM DIEM WHERE MaSV = @masv AND MaMH = @mamh",
                    con);
                checkCmd.Parameters.AddWithValue("@masv", masv);
                checkCmd.Parameters.AddWithValue("@mamh", mamh);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    throw new Exception("Đã tồn tại điểm cho sinh viên này với môn học này");
                }

                // Thêm mới
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO DIEM (MaSV, MaMH, DiemCC, DiemKT, DiemGK, DiemThi, DiemTB, MaGV, MaHK) " +
                    "VALUES (@masv, @mamh, @diemcc, @diemkt, @diemgk, @diemthi, @diemtb, @magv, @mahk)",
                    con);

                insertCmd.Parameters.AddWithValue("@masv", masv);
                insertCmd.Parameters.AddWithValue("@mamh", mamh);
                insertCmd.Parameters.AddWithValue("@diemcc", diemcc);
                insertCmd.Parameters.AddWithValue("@diemkt", diemkt);
                insertCmd.Parameters.AddWithValue("@diemgk", diemgk);
                insertCmd.Parameters.AddWithValue("@diemthi", diemthi);
                insertCmd.Parameters.AddWithValue("@diemtb", diemtb);
                insertCmd.Parameters.AddWithValue("@magv", magv);
                insertCmd.Parameters.AddWithValue("@mahk", mahk);

                insertCmd.ExecuteNonQuery();
            }
        }

        public static void Xoa_Diem(string masv)
        {
            SqlConnection con = new SqlConnection(QuanLySinhVien_DAL.DB_connect.strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM DIEM WHERE MaSV = @masv", con);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
