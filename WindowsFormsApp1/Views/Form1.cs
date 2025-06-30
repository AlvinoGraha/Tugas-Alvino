using System.Windows.Forms;
using System;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly ObatController _controller = new ObatController();

        public Form1()
        {
            InitializeComponent();
        }
        private Obat AmbilDataDariForm()
        {
            return new Obat
            {
                NamaObat = textBox1.Text,
                DosisObat = textBox2.Text,
                KodeObat = textBox3.Text,
                Stok = int.Parse(textBox4.Text)
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _controller.TambahObat(AmbilDataDariForm());
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _controller.AmbilSemuaObat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.UbahObat(AmbilDataDariForm());
            MessageBox.Show("Data berhasil diupdate!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _controller.HapusObat(textBox3.Text);
            MessageBox.Show("Data berhasil dihapus!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = textBox5.Text.Trim();
            dataGridView1.DataSource = _controller.CariObat(keyword);
        }
    }
}
