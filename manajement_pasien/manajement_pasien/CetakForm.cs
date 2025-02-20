using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;
using MongoDB.Bson;
using MongoDB.Driver;

namespace manajement_pasien
{
    public partial class CetakForm : Form
    {
        private IMongoCollection<BsonDocument> _pasienCollection;
        public CetakForm()
        {
            InitializeComponent();
            InitializeMongo();
            DataDalamGrid();
        }

        private void InitializeMongo()
        {
            // Buat koneksi ke database MongoDB
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("manajement_pasien");
            _pasienCollection = database.GetCollection<BsonDocument>("Pasien");
        }

        private void DataDalamGrid()
        {
            var documents = _pasienCollection.Find(new BsonDocument()).ToList();
            DataTable dataTable = new DataTable();

            if (documents.Count > 0)
            {
                foreach (var element in documents[0].Elements)
                {
                    if (!new[] { "_id", "JamKonsultasi", "status" }.Contains(element.Name))
                    {
                        dataTable.Columns.Add(element.Name);
                    }
                }

                foreach (var doc in documents)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (var element in doc.Elements)
                    {
                        if (!new[] { "_id", "JamKonsultasi", "status" }.Contains(element.Name))
                        {
                            row[element.Name] = element.Value;
                        }
                    }
                    dataTable.Rows.Add(row);
                }
            }
            dataGridView1.DataSource = dataTable;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            var documents = _pasienCollection.Find(new BsonDocument()).ToList();
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Save an Exported PDF File"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Table table = new Table(dataGridView1.Columns.Count);
                        Document document = new Document(pdf);

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                        }


                        // Tambahkan data dari DataGridView
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellValue = cell.Value?.ToString() ?? "";

                                    // Coba parsing nilai cell sebagai DateTime
                                    if (DateTime.TryParse(cellValue, out DateTime dateValue))
                                    {
                                        // Format nilai DateTime jika parsing berhasil
                                        cellValue = dateValue.ToString("yyyy-MM-dd HH:mm");
                                    }

                                    // Tambahkan cell yang sudah diformat ke tabel PDF
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                                }
                            }
                        }

                        document.Add(table);
                    }
                }
                MessageBox.Show("Data berhasil di simpan");
            }

        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            // Menampilkan form login
            dashboard.Show();

            this.Hide();
        }

        private void CetakForm_Load(object sender, EventArgs e)
        {

        }
    }
}
