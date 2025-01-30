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
    public partial class JadwalKonsul : Form
    {
        private IMongoCollection<Pasien> _userCollection;

        public JadwalKonsul()
        {
            InitializeComponent();

            // Koneksi ke MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien");
            _userCollection = database.GetCollection<Pasien>("Pasien");

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Ambil semua data dari koleksi
                var pasienList = _userCollection.Find(_ => true).ToList();

                // Bind data ke DataGridView
                dataGridViewPasien.DataSource = pasienList;
                dataGridViewPasien.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengambil data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            // Menampilkan form login
            formPendaftaran.Show();

            this.Hide();
        }
    }
}
