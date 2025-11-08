using Microsoft.Data.SqlClient;

namespace CoffeeHouseABC.Database
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = "Data Source=g1BSsQ;Initial Catalog=CoffeeHouseABC;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}