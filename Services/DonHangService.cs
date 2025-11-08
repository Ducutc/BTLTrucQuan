using Microsoft.Data.SqlClient;
using CoffeeHouseABC.Database;
using CoffeeHouseABC.Models;

namespace CoffeeHouseABC.Services
{
    public class DonHangService
    {
        public static int TaoDonHang(int maKH, decimal tongTien, string trangThai)
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "INSERT INTO DONHANG (MaKH, TongTien, TrangThai) OUTPUT INSERTED.MaHD VALUES (@MaKH, @TongTien, @TrangThai)";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@TongTien", tongTien);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                object? result = cmd.ExecuteScalar();
                return result != null ? (int)result : -1;
            }
            catch
            {
                return -1;
            }
        }

        public static bool ThemChiTietDonHang(int maHD, int maSP, int soLuong, decimal donGiaBan)
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "INSERT INTO CHITIETDONHANG (MaHD, MaSP, SoLuong, DonGiaBan) VALUES (@MaHD, @MaSP, @SoLuong, @DonGiaBan)";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@DonGiaBan", donGiaBan);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        public static List<DonHang> GetDonHangByKhachHang(int maKH)
        {
            List<DonHang> danhSach = new();
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "SELECT * FROM DONHANG WHERE MaKH = @MaKH ORDER BY NgayLap DESC";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(new DonHang
                    {
                        MaHD = (int)reader["MaHD"],
                        MaKH = (int)reader["MaKH"],
                        TongTien = (decimal)reader["TongTien"],
                        TrangThai = reader["TrangThai"]?.ToString() ?? string.Empty,
                        NgayLap = (DateTime)reader["NgayLap"]
                    });
                }
            }
            catch
            {
                return danhSach;
            }
            return danhSach;
        }
    }
}