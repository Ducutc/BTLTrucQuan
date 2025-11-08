using Microsoft.Data.SqlClient;
using CoffeeHouseABC.Database;

namespace CoffeeHouseABC.Services
{
    public class DanhGiaService
    {
        public static bool ThemDanhGia(int maKH, int diemPhucVu, int diemChatLuong, int diemKhongGian, int diemDaDang, string? gopY)
        {
            try
            {
                using SqlConnection conn = DatabaseConnection.GetConnection();
                conn.Open();
                string query = "INSERT INTO DANHGIA (MaKH, DiemPhucVu, DiemChatLuong, DiemKhongGian, DiemDaDang, GopY) VALUES (@MaKH, @DiemPhucVu, @DiemChatLuong, @DiemKhongGian, @DiemDaDang, @GopY)";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@DiemPhucVu", diemPhucVu);
                cmd.Parameters.AddWithValue("@DiemChatLuong", diemChatLuong);
                cmd.Parameters.AddWithValue("@DiemKhongGian", diemKhongGian);
                cmd.Parameters.AddWithValue("@DiemDaDang", diemDaDang);
                cmd.Parameters.AddWithValue("@GopY", string.IsNullOrWhiteSpace(gopY) ? DBNull.Value : gopY);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}