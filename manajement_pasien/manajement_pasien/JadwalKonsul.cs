using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace manajement_pasien
{
    public partial class JadwalKonsul : Form
    {
        private IMongoCollection<BsonDocument> _userCollection;
        private ObjectId selectedId; // Untuk menyimpan ID pasien yang dipilih

        public JadwalKonsul()
        {
            InitializeComponent();

            // Koneksi ke MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien");
            _userCollection = database.GetCollection<BsonDocument>("Pasien");

            // Menambahkan pilihan pada ComboBox Status
            CmbStatus.Items.Add("Sedang Di Periksa");
            CmbStatus.Items.Add("Menunggu");
            CmbStatus.Items.Add("Selesai");

            CmbGender.Items.Add("Laki-laki");
            CmbGender.Items.Add("Perempuan");


            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var pasienList = _userCollection.Find(_ => true).ToList();

                // Bersihkan ListView sebelum diisi ulang
                listView1.Items.Clear();
                listView1.View = View.Details;

                // Tambahkan header kolom jika belum ada
                if (listView1.Columns.Count == 0)
                {
                    listView1.Columns.Add("ID", 50);
                    listView1.Columns.Add("Nama", 150);
                    listView1.Columns.Add("Umur", 50);
                    listView1.Columns.Add("Jenis Kelamin", 100);
                    listView1.Columns.Add("Alamat", 200);
                    listView1.Columns.Add("Keluhan", 200);
                    listView1.Columns.Add("Jam", 150);
                    listView1.Columns.Add("Dokter", 150);
                    listView1.Columns.Add("Tanggal", 120);
                    listView1.Columns.Add("Status", 100);
                }

                foreach (var pasien in pasienList)
                {
                    try
                    {
                        ListViewItem item = new ListViewItem(pasien["_id"].ToString());
                        item.SubItems.Add(pasien.GetValue("Nama", "").ToString());
                        item.SubItems.Add(pasien.GetValue("Umur", "").ToString());

                      
                        string jenisKelamin = pasien.GetValue("JenisKelamin", "").ToString();
                        if (!string.Equals(jenisKelamin, "Laki-laki", StringComparison.OrdinalIgnoreCase) &&
                            !string.Equals(jenisKelamin, "Perempuan", StringComparison.OrdinalIgnoreCase))
                        {
                            jenisKelamin = "Tidak diketahui";
                        }
                        item.SubItems.Add(jenisKelamin);

                        // Alamat
                        string alamat = pasien.Contains("AlamatKontak")
                                            ? pasien.GetValue("AlamatKontak", "").ToString()
                                            : "Alamat tidak tersedia";
                        item.SubItems.Add(alamat);
                        item.SubItems.Add(pasien.GetValue("Keluhan", "").ToString());

                        // Validasi dan format Jam Konsultasi
                        string jamKonsultasiStr = pasien.GetValue("JamKonsultasi", "").ToString();
                        DateTime jamKonsultasi;
                        if (DateTime.TryParse(jamKonsultasiStr, out jamKonsultasi))
                        {
                            jamKonsultasiStr = jamKonsultasi.ToString("HH:mm");
                        }
                        else
                        {
                            jamKonsultasiStr = "00:00";
                        }
                        item.SubItems.Add(jamKonsultasiStr);

                        item.SubItems.Add(pasien.GetValue("Dokter", "").ToString());
                        item.SubItems.Add(pasien.Contains("Tanggal")
                                            ? pasien["Tanggal"].ToUniversalTime().ToString("yyyy-MM-dd")
                                            : DateTime.Now.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(pasien.GetValue("Status", "").ToString());

                        listView1.Items.Add(item);
                    }
                    catch (Exception innerEx)
                    {
                
                        MessageBox.Show($"Terjadi kesalahan saat memproses data pasien dengan ID {pasien["_id"]}: {innerEx.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengambil data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedId = ObjectId.Parse(selectedItem.SubItems[0].Text); 
                txtEditNama.Text = selectedItem.SubItems[1].Text;
                txtUmur.Text = selectedItem.SubItems[2].Text;
                CmbGender.SelectedItem = selectedItem.SubItems[3].Text;
                txtAlamat.Text = selectedItem.SubItems[4].Text; 
                txtKeluhan.Text = selectedItem.SubItems[5].Text;
                txtJam.Text = selectedItem.SubItems[6].Text;
                CmbDokter.SelectedItem = selectedItem.SubItems[7].Text;
                Tanggal.Value = DateTime.Parse(selectedItem.SubItems[8].Text);
                CmbStatus.SelectedItem = selectedItem.SubItems[9].Text;
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (selectedId == ObjectId.Empty)
            {
                MessageBox.Show("Silakan pilih data yang ingin diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", selectedId);
                var update = Builders<BsonDocument>.Update
                    .Set("Nama", txtEditNama.Text)
                    .Set("Umur", txtUmur.Text)
                    .Set("JenisKelamin", CmbGender.SelectedItem?.ToString())
                    .Set("Alamat", txtAlamat.Text) 
                    .Set("Keluhan", txtKeluhan.Text)
                    .Set("JamKonsultasi", txtJam.Text)
                    .Set("Dokter", CmbDokter.SelectedItem?.ToString())
                    .Set("Tanggal", Tanggal.Value)
                    .Set("Status", CmbStatus.SelectedItem?.ToString());

                _userCollection.UpdateOne(filter, update);

                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengupdate data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == ObjectId.Empty)
            {
                MessageBox.Show("Silakan pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var filter = Builders<BsonDocument>.Filter.Eq("_id", selectedId);
                    _userCollection.DeleteOne(filter);

                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat menghapus data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            Dashboard formDashboard = new Dashboard();
            formDashboard.Show();
            this.Hide();
        }

        private void BtnDaftar_Click(object sender, EventArgs e)
        {
            InputPasien formInputPasien = new InputPasien();
            formInputPasien.Show();
            this.Hide();
        }

       
        private void ClearFields()
        {
            txtEditNama.Clear();
            txtUmur.Clear();
            CmbGender.SelectedIndex = -1;
            txtAlamat.Clear();
            txtKeluhan.Clear();
            txtJam.Clear();
            CmbDokter.SelectedIndex = -1;
            Tanggal.Value = DateTime.Now;
            CmbStatus.SelectedIndex = -1;
            selectedId = ObjectId.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard formDashboard = new Dashboard();

            // Menampilkan form login
            formDashboard.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pendaftaran formPendaftaran = new Pendaftaran();

            // Menampilkan form Pendaftaran
            formPendaftaran.Show();
            this.Hide();

        }
    }
}
