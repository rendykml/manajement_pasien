using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MongoDB.Driver;
using MongoDB.Bson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace manajement_pasien
{
    public partial class FormLogin : Form

    {
        private IMongoCollection<BsonDocument> _userCollection;
        public FormLogin()
        {
            InitializeComponent();
            InitializeMongo();
            
        }

        private void InitializeMongo() 
        {
            // Buat koneksi ke database MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien");
            _userCollection = database.GetCollection<BsonDocument>("users");
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tolong Masukan Username dan Password!");
                return;
            }

            // Cari user berdasarkan username
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var user = _userCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                // Ambil password yang sudah di-hash dari database
                string hashedPassword = user["password"].AsString;

                // Verifikasi password
                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                {
                    MessageBox.Show("Login berhasil!");
                    // Lanjutkan ke form dashboard
                    var dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password salah!");
                }
            }
            else
            {
                MessageBox.Show("Username tidak ditemukan!");
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

            frmRegister formBaru = new frmRegister();

            // Mnampilkan form regis
            formBaru.Show();

            this.Hide();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // menutup membuka password
            if (checkBoxShowPass.Checked)
            {
                textPassword.Font = new Font(textPassword.Font.FontFamily, 16);
                textPassword.PasswordChar = '\0'; 
            }
            else
            {
                textPassword.PasswordChar = '*'; 
                textPassword.Font = new Font(textPassword.Font.FontFamily, 10);

            }
        }
        private void clearLogin_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textUsername.Focus(); 
        }
    }
}
