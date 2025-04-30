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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=StokObatDB;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Obat (NamaObat, DosisObat, KodeObat, Stok) VALUES (@NamaObat, @DosisObat, @KodeObat, @Stok)", con);
            cmd.Parameters.AddWithValue("@NamaObat", textBox1.Text);
            cmd.Parameters.AddWithValue("@DosisObat", textBox2.Text);
            cmd.Parameters.AddWithValue("@KodeObat", textBox3.Text);
            cmd.Parameters.AddWithValue("@Stok", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=StokObatDB;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Obat", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=StokObatDB;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Obat SET NamaObat=@NamaObat, DosisObat=@DosisObat, Stok=@Stok WHERE KodeObat=@KodeObat", con);
            cmd.Parameters.AddWithValue("@NamaObat", textBox1.Text);
            cmd.Parameters.AddWithValue("@DosisObat", textBox2.Text);
            cmd.Parameters.AddWithValue("@KodeObat", textBox3.Text);
            cmd.Parameters.AddWithValue("@Stok", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil diupdate!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=StokObatDB;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Obat WHERE KodeObat=@KodeObat", con);
            cmd.Parameters.AddWithValue("@KodeObat", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil dihapus!");

        }
    }
}
