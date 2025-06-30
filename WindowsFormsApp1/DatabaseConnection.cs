using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class DatabaseConnection
    {
        private readonly string _connectionString = @"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=StokObatDB;TrustServerCertificate=True;Integrated Security=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
