namespace manajement_pasien
{
    partial class CetakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CetakForm));
            DashboardBTN = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Export = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DashboardBTN
            // 
            DashboardBTN.Location = new Point(408, 353);
            DashboardBTN.Name = "DashboardBTN";
            DashboardBTN.Size = new Size(94, 29);
            DashboardBTN.TabIndex = 2;
            DashboardBTN.Text = "Kembali";
            DashboardBTN.UseVisualStyleBackColor = true;
            DashboardBTN.Click += DashboardBTN_Click;
            // 
            // chart1
            // 
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 0;
            // 
            // Export
            // 
            Export.Location = new Point(286, 353);
            Export.Name = "Export";
            Export.Size = new Size(94, 29);
            Export.TabIndex = 1;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            Export.Click += Export_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 307);
            dataGridView1.TabIndex = 3;
            // 
            // CetakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(dataGridView1);
            Controls.Add(DashboardBTN);
            Controls.Add(Export);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CetakForm";
            Text = "CetakForm";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button DashboardBTN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button Export;
        private DataGridView dataGridView1;
    }
}