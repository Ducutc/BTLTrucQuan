using Microsoft.Data.SqlClient;
using CoffeeHouseABC.Database;
using CoffeeHouseABC.Models;

namespace CoffeeHouseABC.Services
{
    public class KhachHangService
    {
        public static KhachHang? Login(string tenTaiKhoan, string matKhau)
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "SELECT * FROM KHACHHANG WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new KhachHang
                    {
                        MaKH = (int)reader["MaKH"],
                        TenTaiKhoan = reader["TenTaiKhoan"]?.ToString() ?? string.Empty,
                        MatKhau = reader["MatKhau"]?.ToString() ?? string.Empty,
                        VaiTro = reader["VaiTro"]?.ToString() ?? string.Empty,
                        NgayTao = (DateTime)reader["NgayTao"]
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            return null;
        }

        public static bool DangKy(string tenTaiKhoan, string matKhau, string vaiTro = "Khách hàng")
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "INSERT INTO KHACHHANG (TenTaiKhoan, MatKhau, VaiTro) VALUES (@TenTaiKhoan, @MatKhau, @VaiTro)";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@VaiTro", vaiTro);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool DoiMatKhau(int maKH, string matKhauMoi)
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "UPDATE KHACHHANG SET MatKhau = @MatKhau WHERE MaKH = @MaKH";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MatKhau", matKhauMoi);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        public static KhachHang? GetKhachHangById(int maKH)
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "SELECT * FROM KHACHHANG WHERE MaKH = @MaKH";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new KhachHang
                    {
                        MaKH = (int)reader["MaKH"],
                        TenTaiKhoan = reader["TenTaiKhoan"]?.ToString() ?? string.Empty,
                        MatKhau = reader["MatKhau"]?.ToString() ?? string.Empty,
                        VaiTro = reader["VaiTro"]?.ToString() ?? string.Empty,
                        NgayTao = (DateTime)reader["NgayTao"]
                    };
                }
            }
            catch
            {
                return null;
            }
            return null;
        }
    }
}