using MongoDB.Bson;
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
using static System.Windows.Forms.DataFormats;


namespace manajement_pasien
   
{
    
    public partial class frmRegister : Form
    {
        private IMongoCollection<BsonDocument> _userCollection;

        public frmRegister()
        {
            InitializeComponent();
            InitializeMongo();
        }

        private void InitializeMongo()
        {
        
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien"); 
            _userCollection = database.GetCollection<BsonDocument>("users"); 
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {

            string username = textUsername.Text;
            string password = textPassword.Text;
            string confirmPassword = textComPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak cocok!");
                return;
            }

            // Cek apakah username sudah ada
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);
            var existingUser = _userCollection.Find(filter).FirstOrDefault();

            // jika sudah username
            if (existingUser != null)
            {
                MessageBox.Show("Username sudah terdaftar!");
                return;
            }

            // Hash password sebelum menyimpannya ke database
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Simpan pengguna baru ke database
            var newUser = new BsonDocument
            {
                { "username", username },
                { "password", hashedPassword } // Untuk keamanan, gunakan hashing password
            };

            //Tidak boleh kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password harus diisi!");
                return;
            }

            _userCollection.InsertOne(newUser);
            MessageBox.Show("Registrasi berhasil!");

            // Kembali ke form login
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void LoginLink_Click(object sender, EventArgs e)
        {

            FormLogin formBaru = new FormLogin();

            // Menampilkan form login
            formBaru.Show();

            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // menutup membuka password
            if (checkBoxShowPass.Checked)
            {
                textPassword.Font = new Font(textPassword.Font.FontFamily, 16);
                textPassword.PasswordChar = '\0';
                textComPassword.Font = new Font(textPassword.Font.FontFamily, 16);
                textComPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
                textPassword.Font = new Font(textPassword.Font.FontFamily, 10);
                textComPassword.Font = new Font(textPassword.Font.FontFamily, 10);
                textComPassword.PasswordChar = '*';

            }
        }

        private void clearRegis_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textComPassword.Clear();
            textUsername.Focus();

        }
    }
}
