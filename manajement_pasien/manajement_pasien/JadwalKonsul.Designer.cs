namespace manajement_pasien
{
    partial class JadwalKonsul
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            labelStatus = new Label();
            CmbStatus = new ComboBox();
            BtnHapus = new Button();
            BtnSimpan = new Button();
            Tanggal = new DateTimePicker();
            labelEditDokter = new Label();
            CmbDokter = new ComboBox();
            labelEditJenisKelamin = new Label();
            CmbGender = new ComboBox();
            txtJam = new TextBox();
            labelEditJam = new Label();
            txtKeluhan = new TextBox();
            labelEditKeluhan = new Label();
            txtAlamat = new TextBox();
            labelEditAlamat = new Label();
            txtUmur = new TextBox();
            labelEditUmur = new Label();
            txtEditNama = new TextBox();
            labelEditNama = new Label();
            label1 = new Label();
            listView1 = new ListView();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(389, 330);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(287, 330);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 3;
            button2.Text = "Daftar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Controls.Add(labelStatus);
            panel2.Controls.Add(CmbStatus);
            panel2.Controls.Add(BtnHapus);
            panel2.Controls.Add(BtnSimpan);
            panel2.Controls.Add(Tanggal);
            panel2.Controls.Add(labelEditDokter);
            panel2.Controls.Add(CmbDokter);
            panel2.Controls.Add(labelEditJenisKelamin);
            panel2.Controls.Add(CmbGender);
            panel2.Controls.Add(txtJam);
            panel2.Controls.Add(labelEditJam);
            panel2.Controls.Add(txtKeluhan);
            panel2.Controls.Add(labelEditKeluhan);
            panel2.Controls.Add(txtAlamat);
            panel2.Controls.Add(labelEditAlamat);
            panel2.Controls.Add(txtUmur);
            panel2.Controls.Add(labelEditUmur);
            panel2.Controls.Add(txtEditNama);
            panel2.Controls.Add(labelEditNama);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(478, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 399);
            panel2.TabIndex = 4;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(61, 312);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 25;
            labelStatus.Text = "Status";
            // 
            // CmbStatus
            // 
            CmbStatus.FormattingEnabled = true;
            CmbStatus.Location = new Point(62, 330);
            CmbStatus.Name = "CmbStatus";
            CmbStatus.Size = new Size(95, 23);
            CmbStatus.TabIndex = 24;
            // 
            // BtnHapus
            // 
            BtnHapus.Location = new Point(115, 361);
            BtnHapus.Margin = new Padding(3, 2, 3, 2);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(95, 25);
            BtnHapus.TabIndex = 23;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = true;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(21, 361);
            BtnSimpan.Margin = new Padding(3, 2, 3, 2);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(91, 25);
            BtnSimpan.TabIndex = 5;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // Tanggal
            // 
            Tanggal.Location = new Point(17, 288);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(193, 23);
            Tanggal.TabIndex = 22;
            // 
            // labelEditDokter
            // 
            labelEditDokter.AutoSize = true;
            labelEditDokter.Location = new Point(115, 241);
            labelEditDokter.Name = "labelEditDokter";
            labelEditDokter.Size = new Size(42, 15);
            labelEditDokter.TabIndex = 16;
            labelEditDokter.Text = "Dokter";
            // 
            // CmbDokter
            // 
            CmbDokter.FormattingEnabled = true;
            CmbDokter.Items.AddRange(new object[] { "Dokter 1", "Dokter 2", "Dokter 3" });
            CmbDokter.Location = new Point(115, 259);
            CmbDokter.Name = "CmbDokter";
            CmbDokter.Size = new Size(95, 23);
            CmbDokter.TabIndex = 15;
            // 
            // labelEditJenisKelamin
            // 
            labelEditJenisKelamin.AutoSize = true;
            labelEditJenisKelamin.Location = new Point(19, 78);
            labelEditJenisKelamin.Name = "labelEditJenisKelamin";
            labelEditJenisKelamin.Size = new Size(78, 15);
            labelEditJenisKelamin.TabIndex = 14;
            labelEditJenisKelamin.Text = "Jenis Kelamin";
            // 
            // CmbGender
            // 
            CmbGender.FormattingEnabled = true;
            CmbGender.Items.AddRange(new object[] { "Laki laki", "Perempuan" });
            CmbGender.Location = new Point(17, 95);
            CmbGender.Name = "CmbGender";
            CmbGender.Size = new Size(193, 23);
            CmbGender.TabIndex = 13;
            // 
            // txtJam
            // 
            txtJam.Location = new Point(17, 259);
            txtJam.Name = "txtJam";
            txtJam.Size = new Size(95, 23);
            txtJam.TabIndex = 12;
            // 
            // labelEditJam
            // 
            labelEditJam.AutoSize = true;
            labelEditJam.Location = new Point(17, 241);
            labelEditJam.Name = "labelEditJam";
            labelEditJam.Size = new Size(67, 15);
            labelEditJam.TabIndex = 11;
            labelEditJam.Text = "Jam Konsul";
            // 
            // txtKeluhan
            // 
            txtKeluhan.Location = new Point(17, 219);
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.Size = new Size(193, 23);
            txtKeluhan.TabIndex = 8;
            // 
            // labelEditKeluhan
            // 
            labelEditKeluhan.AutoSize = true;
            labelEditKeluhan.Location = new Point(17, 201);
            labelEditKeluhan.Name = "labelEditKeluhan";
            labelEditKeluhan.Size = new Size(50, 15);
            labelEditKeluhan.TabIndex = 7;
            labelEditKeluhan.Text = "Keluhan";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(17, 178);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(193, 23);
            txtAlamat.TabIndex = 6;
            // 
            // labelEditAlamat
            // 
            labelEditAlamat.AutoSize = true;
            labelEditAlamat.Location = new Point(17, 160);
            labelEditAlamat.Name = "labelEditAlamat";
            labelEditAlamat.Size = new Size(86, 15);
            labelEditAlamat.TabIndex = 5;
            labelEditAlamat.Text = "Alamat/kontak";
            // 
            // txtUmur
            // 
            txtUmur.Location = new Point(17, 139);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(193, 23);
            txtUmur.TabIndex = 4;
            // 
            // labelEditUmur
            // 
            labelEditUmur.AutoSize = true;
            labelEditUmur.Location = new Point(17, 121);
            labelEditUmur.Name = "labelEditUmur";
            labelEditUmur.Size = new Size(37, 15);
            labelEditUmur.TabIndex = 3;
            labelEditUmur.Text = "Umur";
            // 
            // txtEditNama
            // 
            txtEditNama.Location = new Point(17, 52);
            txtEditNama.Name = "txtEditNama";
            txtEditNama.Size = new Size(193, 23);
            txtEditNama.TabIndex = 2;
            // 
            // labelEditNama
            // 
            labelEditNama.AutoSize = true;
            labelEditNama.Location = new Point(17, 34);
            labelEditNama.Name = "labelEditNama";
            labelEditNama.Size = new Size(39, 15);
            labelEditNama.TabIndex = 1;
            labelEditNama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 10);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Edit Data Pasien";
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 24);
            listView1.Name = "listView1";
            listView1.Size = new Size(434, 286);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // JadwalKonsul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 61);
            ClientSize = new Size(700, 396);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "JadwalKonsul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JadwalKonsul";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel2;
        private TextBox txtEditNama;
        private Label labelEditNama;
        private Label label1;
        private TextBox textBox5;
        private Label label5;
        private TextBox txtKeluhan;
        private Label labelEditKeluhan;
        private Label labelEditAlamat;
        private TextBox txtUmur;
        private Label labelEditUmur;
        private TextBox txtJam;
        private Label labelEditJam;
        private ComboBox CmbDokter;
        private Label labelEditJenisKelamin;
        private ComboBox CmbGender;
        private TextBox txtAlamat;
        private Label labelEditDokter;
        private DateTimePicker Tanggal;
        private Button BtnHapus;
        private Button BtnSimpan;
        private Label labelStatus;
        private ComboBox CmbStatus;
        private ListView listView1;
    }
}