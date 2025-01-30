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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            // Menampilkan form login
            formLogin.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pendaftaran formDaftar = new Pendaftaran();

            // Menampilkan form login
            formDaftar.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JadwalKonsul formJadwalKonsul = new JadwalKonsul();

            // Menampilkan form login
            formJadwalKonsul.Show();

            this.Hide();
        }
    }
}
