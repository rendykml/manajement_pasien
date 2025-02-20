using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MongoDB.Bson;
using MongoDB.Driver;

namespace manajement_pasien
{
    public partial class Form2 : Form
    {
        private IMongoCollection<BsonDocument> _userCollection;

        public Form2()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien");
            _userCollection = database.GetCollection<BsonDocument>("Pasien");
            LoadChartData();
        }

        private void LoadChartData()
        {
            // Ambil data dari MongoDB
            var filter = Builders<BsonDocument>.Filter.Empty;
            var data = _userCollection.Find(filter).ToList();

            // Map dokumen ke model sementara (tangani jika field "Tanggal" tidak ada)
            var mappedData = data.Select(d =>
            {
                DateTime tanggal = DateTime.MinValue;
                if (d.Contains("Tanggal"))
                {
                    tanggal = d["Tanggal"].AsBsonDateTime.ToLocalTime().Date;
                }

                return new
                {
                    Tanggal = tanggal
                };
            });

            // Hanya ambil data dengan Tanggal valid
            var validData = mappedData.Where(x => x.Tanggal != DateTime.MinValue);

            // Kelompokkan data berdasarkan Tanggal saja
            var groupedData = validData
                .GroupBy(x => x.Tanggal)
                .Select(g => new
                {
                    Tanggal = g.Key,
                    Jumlah = g.Count()
                })
                .OrderBy(d => d.Tanggal)
                .ToList();

            // Konfigurasi chart
            chart1.Series.Clear();

            // Pastikan ada ChartArea
            if (chart1.ChartAreas.Count == 0)
            {
                chart1.ChartAreas.Add(new ChartArea());
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            // Pastikan ada Legend
            if (chart1.Legends.Count == 0)
            {
                chart1.Legends.Add(new Legend());
            }
            chart1.Legends[0].Enabled = true;

            // Buat satu series untuk menampilkan jumlah pasien per tanggal
            Series series = new Series
            {
                Name = "Pasien",
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime
            };

            // Tambahkan data ke series
            foreach (var item in groupedData)
            {
                series.Points.AddXY(item.Tanggal, item.Jumlah);
            }

            // Tambahkan series ke chart
            chart1.Series.Add(series);

            // Set judul chart
            chart1.Titles.Clear();
            var title = chart1.Titles.Add("Jumlah Pasien per Tanggal");
            title.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

            // Lanjutkan konfigurasi chart sama seperti sebelumnya
            // ...
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard formDashboard = new Dashboard();
            formDashboard.Show();
            this.Hide();
        }
    }
}
