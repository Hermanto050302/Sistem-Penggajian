using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penggajian
{
    public partial class LaporanGaji : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public LaporanGaji()
        {
            InitializeComponent();
        }

        private void generate_data_gaji(string ssql)
        {
            dataGaji.Rows.Clear();
            dataGaji.Columns.Clear();

            dataGaji.Columns.Add("ID", "ID");
            dataGaji.Columns.Add("Nama", "Nama");
            dataGaji.Columns.Add("Golongan", "Golongan");
            dataGaji.Columns.Add("Bulan", "Bulan");
            dataGaji.Columns.Add("Tahun", "Tahun");
            dataGaji.Columns.Add("Kehadiran", "Kehadiran");
            dataGaji.Columns.Add("Honor/Hari", "Honor/Hari");
            dataGaji.Columns.Add("Total", "Total");

            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read())
                {
                    int n = dataGaji.Rows.Add();
                    dataGaji.Rows[n].Cells[0].Value = reader["id"].ToString();
                    dataGaji.Rows[n].Cells[1].Value = reader["nama_karyawan"].ToString();
                    dataGaji.Rows[n].Cells[2].Value = reader["nama_golongan"].ToString();
                    dataGaji.Rows[n].Cells[3].Value = reader["bulan"].ToString();
                    dataGaji.Rows[n].Cells[4].Value = reader["tahun"].ToString();
                    dataGaji.Rows[n].Cells[5].Value = reader["kehadiran"].ToString();
                    dataGaji.Rows[n].Cells[6].Value = string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", reader["honor"]);
                    dataGaji.Rows[n].Cells[7].Value = string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", reader["total"]);
                }
            }

            reader.Close();
        }

        private void LaporanGaji_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string bulan = cmbBulan.SelectedItem.ToString(), tahun = txtTahun.Text.ToString();

            string ssql = "SELECT gaji.*, " +
                "karyawan.nama AS nama_karyawan, " +
                "golongan.nama AS nama_golongan " +
                "FROM gaji " +
                "INNER JOIN karyawan " +
                "ON gaji.id_karyawan = karyawan.id " +
                "INNER JOIN golongan " +
                "ON karyawan.id_golongan = golongan.id " +
                "WHERE gaji.bulan = 1 " +
                "AND gaji.tahun = 2023";

            generate_data_gaji(ssql);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dataGaji.Width, dataGaji.Height);
            dataGaji.DrawToBitmap(bm, new Rectangle(0, 0, dataGaji.Width, dataGaji.Height));
            e.Graphics.DrawString("Laporan Data Gaji", new Font("Arial", 14, FontStyle.Bold),
        Brushes.Black, new PointF(250, 20));
            e.Graphics.DrawImage(bm, 0, 50);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
