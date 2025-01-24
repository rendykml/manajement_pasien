namespace manajement_pasien
{
    partial class Dashboard
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
            label1 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 61, 61);
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(308, 35);
            label1.TabIndex = 0;
            label1.Text = "Tampilan Dashboard";
            label1.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(61, 61, 61);
            panel5.Enabled = false;
            panel5.Location = new Point(12, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(819, 10);
            panel5.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 61, 61);
            label2.Location = new Point(704, 32);
            label2.Name = "label2";
            label2.Size = new Size(83, 35);
            label2.TabIndex = 4;
            label2.Text = "User\r\n";
            label2.Click += label2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(61, 61, 61);
            panel6.Enabled = false;
            panel6.ForeColor = Color.FromArgb(61, 61, 61);
            panel6.Location = new Point(12, 506);
            panel6.Name = "panel6";
            panel6.Size = new Size(819, 10);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(61, 61, 61);
            panel7.Enabled = false;
            panel7.Location = new Point(13, 19);
            panel7.Name = "panel7";
            panel7.Size = new Size(818, 10);
            panel7.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(87, 142, 126);
            button1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(245, 236, 213);
            button1.Location = new Point(34, 108);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(363, 166);
            button1.TabIndex = 5;
            button1.Text = "Pendaftaran";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseCaptureChanged += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(87, 142, 126);
            button2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(245, 236, 213);
            button2.Location = new Point(34, 306);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(363, 166);
            button2.TabIndex = 6;
            button2.Text = "Grafik";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(87, 142, 126);
            button3.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(245, 236, 213);
            button3.Location = new Point(446, 306);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(363, 166);
            button3.TabIndex = 7;
            button3.Text = "Cetak Laporan";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(87, 142, 126);
            button4.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(245, 236, 213);
            button4.Location = new Point(447, 108);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(363, 166);
            button4.TabIndex = 8;
            button4.Text = "Jadwal Konsul";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(659, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 35);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(245, 236, 213);
            button5.Location = new Point(621, 525);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(166, 59);
            button5.TabIndex = 10;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 250, 236);
            ClientSize = new Size(843, 596);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel5;
        private Label label2;
        private Panel panel6;
        private Panel panel7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button5;
    }
}