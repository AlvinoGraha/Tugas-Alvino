![{E4567380-DAE5-42B5-BA19-40A6390F8EDE}](https://github.com/user-attachments/assets/42655729-b96b-4309-8038-2318ba039dd7)
📦 Aplikasi Manajemen Stok Obat (Windows Forms)
Aplikasi desktop sederhana berbasis Windows Forms (.NET Framework) untuk mencatat, menampilkan, memperbarui, dan menghapus data obat dalam basis data SQL Server.

🛠️ Fitur Utama
Tambah Data Obat
Menyimpan informasi obat seperti nama, dosis, kode obat, dan jumlah stok.

Tampilkan Data
Menampilkan seluruh data obat dari database ke dalam DataGridView.

Update Data Obat
Memperbarui informasi obat berdasarkan KodeObat.

Hapus Data Obat
Menghapus data obat berdasarkan KodeObat.

🧱 Struktur Database
Nama database: StokObatDB
Nama tabel: Obat

Kolom:

NamaObat (nvarchar)

DosisObat (nvarchar)

KodeObat (nvarchar, primary key/unique)

Stok (int)

🚀 Cara Menjalankan
Pastikan Anda memiliki SQL Server dan telah membuat database StokObatDB dengan tabel Obat.

Buka project di Visual Studio.

Pastikan string koneksi sesuai dengan konfigurasi SQL Server Anda:

csharp
Salin
Edit
SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=StokObatDB;TrustServerCertificate=True;Integrated Security=True;");
Jalankan program dan gunakan antarmuka form untuk memasukkan data.

🖥️ Tampilan Aplikasi
Form aplikasi terdiri dari:

4 TextBox untuk input: NamaObat, DosisObat, KodeObat, dan Stok

1 DataGridView untuk menampilkan data

4 Button untuk aksi: Simpan, Tampilkan, Update, dan Hapus

🧑‍💻 Pengembang
Dibuat menggunakan:

Bahasa: C#

Framework: .NET Framework (Windows Forms)

Database: SQL Server

Jika Anda ingin, saya bisa bantu langsung membuat file README.md-nya juga. Mau?
