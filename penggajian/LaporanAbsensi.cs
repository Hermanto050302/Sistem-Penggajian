using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penggajian
{
    public partial class LaporanAbsensi : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public LaporanAbsensi()
        {
            InitializeComponent();
        }

        private void generate_data_absen(string ssql)
        {
            dataAbsen.Rows.Clear();
            dataAbsen.Columns.Clear();

            dataAbsen.Columns.Add("ID", "ID");
            dataAbsen.Columns.Add("Nama", "Nama");
            dataAbsen.Columns.Add("Tanggal", "Tanggal");
            dataAbsen.Columns.Add("Status", "Status");

            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read())
                {
                    int n = dataAbsen.Rows.Add();
                    dataAbsen.Rows[n].Cells[0].Value = reader["id"].ToString();
                    dataAbsen.Rows[n].Cells[1].Value = reader["nama_karyawan"].ToString();
                    dataAbsen.Rows[n].Cells[2].Value = reader["tanggal"].ToString();
                    dataAbsen.Rows[n].Cells[3].Value = reader["status"].ToString();
                }
            }

            reader.Close();


            
        }

        private void LaporanAbsensi_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string bulan = cmbBulan.SelectedItem.ToString(), tahun = txtTahun.Text.ToString();

            string ssql = "SELECT absensi.*, karyawan.nama as nama_karyawan FROM absensi " +
               "INNER JOIN karyawan ON absensi.id_karyawan = karyawan.id " +
               "WHERE MONTH(absensi.tanggal) = " + bulan + "  " +
               "AND YEAR(absensi.tanggal) = " + tahun;

            generate_data_absen(ssql);
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
            Bitmap bm = new Bitmap(dataAbsen.Width, dataAbsen.Height);
            dataAbsen.DrawToBitmap(bm, new Rectangle(0, 0, dataAbsen.Width, dataAbsen.Height));
            e.Graphics.DrawString("Laporan Data Absensi", new Font("Arial", 14, FontStyle.Bold),
        Brushes.Black, new PointF(250, 20));
            e.Graphics.DrawImage(bm, 0, 50);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
