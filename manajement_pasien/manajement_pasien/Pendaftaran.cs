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
            InitializeMongo();

            
        }

        private void InitializeMongo()
        {
            // Buat koneksi ke database MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien");
            _userCollection = database.GetCollection<Pasien>("Pasien");
        }
        private string EvaluateTekananDarah(double sistolik, double diastolik)
        {

            // Tekanan Darah Normal: Sistolik < 120 dan Diastolik < 80
            if (sistolik < 120 && diastolik < 80)
            {
                return "Normal";
            }
            // Elevated (Prahipertensi): Sistolik 120-129 dan Diastolik < 80
            else if (sistolik >= 120 && sistolik < 130 && diastolik < 80)
            {
                return "Elevated (Prahipertensi)";
            }
            // Hipertensi Tahap 1: Sistolik 130-139 atau Diastolik 80-89
            else if ((sistolik >= 130 && sistolik < 140) || (diastolik >= 80 && diastolik < 90))
            {
                return "Hipertensi Tahap 1";
            }
            // Hipertensi Tahap 2: Sistolik 140-180 atau Diastolik 90-120
            else if ((sistolik >= 140 && sistolik <= 180) || (diastolik >= 90 && diastolik <= 120))
            {
                return "Hipertensi Tahap 2";
            }
            // Krisis Hipertensi: Sistolik > 180 atau Diastolik > 120
            else if (sistolik > 180 || diastolik > 120)
            {
                return "Krisis Hipertensi";
            }
            else
            {
                return "Tidak Terdefinisi";
            }
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

         
            if (!double.TryParse(txtSistolik.Text, out double sistolik))
            {
                MessageBox.Show("Input tekanan sistolik tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtDiastolik.Text, out double diastolik))
            {
                MessageBox.Show("Input tekanan diastolik tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Evaluasi keterangan tekanan darah 
            string keteranganTekanan = EvaluateTekananDarah(sistolik, diastolik);

          
            txtKesehatan.Text = keteranganTekanan;

            // Hitung nomor antrian berdasarkan pasien yang terdaftar hari ini
            var today = DateTime.Today;
            var filter = Builders<Pasien>.Filter.And(
                Builders<Pasien>.Filter.Gte(p => p.Tanggal, today),
                Builders<Pasien>.Filter.Lt(p => p.Tanggal, today.AddDays(1))
            );
            Tanggal.Value = DateTime.Now;
            var queueCount = _userCollection.CountDocuments(filter);
            var nomorAntrian = (int)queueCount + 1;
            

            var pasien = new Pasien
            {
                Tanggal = Tanggal.Value,
                Nama = txtNama.Text,
                JenisKelamin = cmbJenisKelamin.SelectedItem?.ToString(),
                Umur = int.TryParse(txtUmur.Text, out int umur) ? umur : 0,
                AlamatKontak = txtAlamat.Text,
                Keluhan = txtKeluhan.Text,
                Status = "Menunggu",
                NomorAntrian = nomorAntrian,
                Sistolik = sistolik,
                Diastolik = diastolik,
                KeteranganTekananDarah = keteranganTekanan
            };

            _userCollection.InsertOne(pasien);
            MessageBox.Show($"Data pasien berhasil disimpan!\nNomor Antrian: {nomorAntrian}\nKeterangan Tekanan Darah: {keteranganTekanan}",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            JadwalKonsul formJadwalKonsul = new JadwalKonsul();
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
            Tanggal.Value = DateTime.Now;
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

            [BsonElement("Tanggal")]
            public DateTime Tanggal { get; set; }

            [BsonElement("Status")]
            public string? Status { get; set; }


            [BsonElement("Sistolik")]
            public double Sistolik { get; set; }

            [BsonElement("Diastolik")]
            public double Diastolik { get; set; }

            
            [BsonElement("KeteranganTekananDarah")]
            public string? KeteranganTekananDarah { get; set; }
            [BsonElement("NomorAntrian")]
            public int NomorAntrian { get; set; }


        }

    }
}


 