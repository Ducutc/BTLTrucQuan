using Microsoft.Data.SqlClient;
using CoffeeHouseABC.Database;
using CoffeeHouseABC.Models;

namespace CoffeeHouseABC.Services
{
    public class SanPhamService
    {
        public static List<SanPham> GetAllSanPham()
        {
            List<SanPham> danhSach = new();
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "SELECT * FROM SANPHAM";
                using SqlCommand cmd = new(query, conn);
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(new SanPham
                    {
                        MaSP = (int)reader["MaSP"],
                        TenSP = reader["TenSP"]?.ToString() ?? string.Empty,
                        Gia = (decimal)reader["Gia"],
                        HinhAnh = reader["HinhAnh"]?.ToString() ?? string.Empty,
                        MoTa = reader["MoTa"]?.ToString() ?? string.Empty
                    });
                }
            }
            catch
            {
                return danhSach;
            }
            return danhSach;
        }

        public static SanPham? GetSanPhamById(int maSP)
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "SELECT * FROM SANPHAM WHERE MaSP = @MaSP";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new SanPham
                    {
                        MaSP = (int)reader["MaSP"],
                        TenSP = reader["TenSP"]?.ToString() ?? string.Empty,
                        Gia = (decimal)reader["Gia"],
                        HinhAnh = reader["HinhAnh"]?.ToString() ?? string.Empty,
                        MoTa = reader["MoTa"]?.ToString() ?? string.Empty
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