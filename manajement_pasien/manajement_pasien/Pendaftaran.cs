using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manajement_pasien
{

    public partial class Pendaftaran : Form
    {
        private IMongoCollection<Pasien> _userCollection;
        public Pendaftaran()
        {
            InitializeComponent();

            // Buat koneksi ke database MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien");
            _userCollection = database.GetCollection<Pasien>("Pasien");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard formDashboard = new Dashboard();

            // Menampilkan form login
            formDashboard.Show();

            this.Hide();
        }   

        private void btnSimpan_Click(object sender, EventArgs e)
        {
        
            var pasien = new Pasien
            {
                Nama = txtNama.Text,
                JenisKelamin = cmbJenisKelamin.SelectedItem?.ToString(),
                Umur = int.TryParse(txtUmur.Text, out int umur) ? umur : 0,
                AlamatKontak = txtAlamat.Text,
                Keluhan = txtKeluhan.Text,
                JamKonsultasi = txtJam.Text,
                Dokter = cmbDokter.SelectedItem?.ToString(),
                Tanggal = Tanggal.Value,
                Status = "Menunggu"
            };

            _userCollection.InsertOne(pasien);
            MessageBox.Show("Data pasien berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            JadwalKonsul formJadwalKonsul = new JadwalKonsul();

            // Menampilkan form login
            formJadwalKonsul.Show();
            this.Hide();
            ClearFields();
        }
        private void ClearFields()
        {
            txtNama.Clear();
            cmbJenisKelamin.SelectedIndex = -1;
            txtUmur.Clear();
            txtAlamat.Clear();
            txtKeluhan.Clear();
            txtJam.Clear();
            cmbDokter.SelectedIndex = -1;
            Tanggal.Value = DateTime.Now;
        }
    }

        public class Pasien
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string? Id { get; set; }

            [BsonElement("Nama")]
            public required string Nama { get; set; }

            [BsonElement("JenisKelamin")]
            public required string JenisKelamin { get; set; }

            [BsonElement("Umur")]
            public required int Umur { get; set; }

            [BsonElement("AlamatKontak")]
            public required string AlamatKontak { get; set; }

            [BsonElement("Keluhan")]
            public required string Keluhan { get; set; }

            [BsonElement("JamKonsultasi")]
            public required string JamKonsultasi { get; set; }

            [BsonElement("Dokter")]
            public required string Dokter { get; set; }

            [BsonElement("Tanggal")]
            public DateTime Tanggal { get; set; }

            [BsonElement("Status")]
            public string? Status { get; set; }
         }

    }


 