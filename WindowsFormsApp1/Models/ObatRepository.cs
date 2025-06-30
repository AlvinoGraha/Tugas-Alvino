using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Models
{
    public class ObatRepository
    {
        private readonly DatabaseConnection _db = new DatabaseConnection();

        public void Insert(Obat obat)
        {
            using (SqlConnection con = _db.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Obat (NamaObat, DosisObat, KodeObat, Stok) VALUES (@NamaObat, @DosisObat, @KodeObat, @Stok)", con);
                cmd.Parameters.AddWithValue("@NamaObat", obat.NamaObat);
                cmd.Parameters.AddWithValue("@DosisObat", obat.DosisObat);
                cmd.Parameters.AddWithValue("@KodeObat", obat.KodeObat);
                cmd.Parameters.AddWithValue("@Stok", obat.Stok);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAll()
        {
            using (SqlConnection con = _db.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Obat", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public void Update(Obat obat)
        {
            using (SqlConnection con = _db.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Obat SET NamaObat=@NamaObat, DosisObat=@DosisObat, Stok=@Stok WHERE KodeObat=@KodeObat", con);
                cmd.Parameters.AddWithValue("@NamaObat", obat.NamaObat);
                cmd.Parameters.AddWithValue("@DosisObat", obat.DosisObat);
                cmd.Parameters.AddWithValue("@KodeObat", obat.KodeObat);
                cmd.Parameters.AddWithValue("@Stok", obat.Stok);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string kodeObat)
        {
            using (SqlConnection con = _db.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Obat WHERE KodeObat=@KodeObat", con);
                cmd.Parameters.AddWithValue("@KodeObat", kodeObat);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable Search(string keyword)
        {
            using (SqlConnection con = _db.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Obat WHERE NamaObat LIKE @Keyword OR KodeObat LIKE @Keyword", con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
    }
}

