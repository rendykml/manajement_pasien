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
            dataGridViewPasien = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasien).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPasien
            // 
            dataGridViewPasien.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewPasien.BorderStyle = BorderStyle.None;
            dataGridViewPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPasien.Dock = DockStyle.Fill;
            dataGridViewPasien.Location = new Point(0, 0);
            dataGridViewPasien.Name = "dataGridViewPasien";
            dataGridViewPasien.RowHeadersWidth = 51;
            dataGridViewPasien.Size = new Size(734, 395);
            dataGridViewPasien.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewPasien);
            panel1.Location = new Point(49, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 395);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(445, 440);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(328, 440);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Daftar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // JadwalKonsul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 61);
            ClientSize = new Size(835, 481);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "JadwalKonsul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JadwalKonsul";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasien).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPasien;
        private Panel panel1;
        private Button button1;
        private Button button2;
    }
}