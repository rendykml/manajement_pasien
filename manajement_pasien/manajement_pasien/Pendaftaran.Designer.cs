namespace manajement_pasien
{
    partial class Pendaftaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pendaftaran));
            panel1 = new Panel();
            Tanggal = new DateTimePicker();
            label7 = new Label();
            txtKesehatan = new TextBox();
            txtDiastolik = new TextBox();
            txtSistolik = new TextBox();
            btnSimpan = new Button();
            label2 = new Label();
            cmbJenisKelamin = new ComboBox();
            label5 = new Label();
            txtAlamat = new TextBox();
            labelinput = new Label();
            txtKeluhan = new TextBox();
            label4 = new Label();
            txtNama = new TextBox();
            label6 = new Label();
            txtUmur = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnKembali = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(87, 142, 126);
            panel1.Controls.Add(Tanggal);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtKesehatan);
            panel1.Controls.Add(txtDiastolik);
            panel1.Controls.Add(txtSistolik);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbJenisKelamin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(labelinput);
            panel1.Controls.Add(txtKeluhan);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtUmur);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 496);
            panel1.TabIndex = 0;
            // 
            // Tanggal
            // 
            Tanggal.Location = new Point(24, 464);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(10, 27);
            Tanggal.TabIndex = 28;
            Tanggal.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 250, 236);
            label7.Location = new Point(23, 318);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 27;
            label7.Text = "Tekanan darah";
            // 
            // txtKesehatan
            // 
            txtKesehatan.Location = new Point(3, 466);
            txtKesehatan.Name = "txtKesehatan";
            txtKesehatan.Size = new Size(15, 27);
            txtKesehatan.TabIndex = 26;
            txtKesehatan.Visible = false;
            // 
            // txtDiastolik
            // 
            txtDiastolik.Location = new Point(182, 344);
            txtDiastolik.Name = "txtDiastolik";
            txtDiastolik.PlaceholderText = "Diastolik";
            txtDiastolik.Size = new Size(145, 27);
            txtDiastolik.TabIndex = 25;
            // 
            // txtSistolik
            // 
            txtSistolik.Location = new Point(23, 344);
            txtSistolik.Name = "txtSistolik";
            txtSistolik.PlaceholderText = "Sistolik";
            txtSistolik.Size = new Size(144, 27);
            txtSistolik.TabIndex = 24;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(104, 393);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(121, 41);
            btnSimpan.TabIndex = 23;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-353, -235);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Nama";
            // 
            // cmbJenisKelamin
            // 
            cmbJenisKelamin.FormattingEnabled = true;
            cmbJenisKelamin.Items.AddRange(new object[] { "Laki-laki", "Perempuan" });
            cmbJenisKelamin.Location = new Point(23, 115);
            cmbJenisKelamin.Margin = new Padding(3, 4, 3, 4);
            cmbJenisKelamin.Name = "cmbJenisKelamin";
            cmbJenisKelamin.Size = new Size(305, 28);
            cmbJenisKelamin.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 250, 236);
            label5.Location = new Point(23, 204);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 14;
            label5.Text = "Alamat/Kontak";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(23, 228);
            txtAlamat.Margin = new Padding(3, 4, 3, 4);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(305, 27);
            txtAlamat.TabIndex = 13;
            // 
            // labelinput
            // 
            labelinput.AutoSize = true;
            labelinput.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelinput.Location = new Point(121, 5);
            labelinput.Name = "labelinput";
            labelinput.Size = new Size(104, 23);
            labelinput.TabIndex = 0;
            labelinput.Text = "Input Pasien";
            // 
            // txtKeluhan
            // 
            txtKeluhan.Location = new Point(23, 285);
            txtKeluhan.Margin = new Padding(3, 4, 3, 4);
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.Size = new Size(305, 27);
            txtKeluhan.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 250, 236);
            label4.Location = new Point(23, 147);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 12;
            label4.Text = "Umur";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(23, 59);
            txtNama.Margin = new Padding(3, 4, 3, 4);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(305, 27);
            txtNama.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 250, 236);
            label6.Location = new Point(23, 261);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 16;
            label6.Text = "Keluhan";
            // 
            // txtUmur
            // 
            txtUmur.Location = new Point(23, 171);
            txtUmur.Margin = new Padding(3, 4, 3, 4);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(305, 27);
            txtUmur.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 250, 236);
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 250, 236);
            label3.Location = new Point(23, 91);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 10;
            label3.Text = "Jenis Kelamin";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(673, 5);
            btnKembali.Margin = new Padding(3, 4, 3, 4);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(121, 41);
            btnKembali.TabIndex = 24;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // Pendaftaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 61);
            ClientSize = new Size(800, 528);
            Controls.Add(btnKembali);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pendaftaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pendaftaran";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelinput;
        private TextBox txtNama;
        private Label label6;
        private TextBox txtKeluhan;
        private Label label5;
        private TextBox txtAlamat;
        private Label label4;
        private TextBox txtUmur;
        private Label label3;
        private Label label2;
        private ComboBox cmbJenisKelamin;
        private Button btnSimpan;
        protected internal Label label1;
        private Button btnKembali;
        private TextBox txtDiastolik;
        private TextBox txtSistolik;
        private Label label7;
        private TextBox txtKesehatan;
        private DateTimePicker Tanggal;
    }
}