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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penggajian
{
    public partial class Gaji : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

        public Gaji()
        {
            InitializeComponent();
        }

        private void generate_data_gaji(int id_karyawan=0)
        {
            string ssqlKaryawan = "SELECT gaji.*, " +
                "karyawan.nama AS nama_karyawan, " +
                "golongan.nama AS nama_golongan " +
                "FROM gaji " +
                "INNER JOIN karyawan " +
                "ON gaji.id_karyawan = karyawan.id " +
                "INNER JOIN golongan " +
                "ON karyawan.id_golongan = golongan.id " +
                "WHERE gaji.id_karyawan = " +id_karyawan;

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

            Console.WriteLine(ssqlKaryawan);
            cmd = new SqlCommand(ssqlKaryawan, conn);
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
            Console.WriteLine(reader);

            reader.Close();
        }

        private void Gaji_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);

            conn.Open();

            cmbKaryawan.Items.Clear();
            cmbKaryawan.ValueMember = "Value";
            cmbKaryawan.DisplayMember = "Text";

            string ssql = "SELECT * FROM karyawan";
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmbKaryawan.Items.Add(new { Value = reader["id"].ToString(), Text = reader["nama"].ToString() });
                }
            }

            reader.Close();
        }

        private void cmbKaryawan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idKaryawan = int.Parse(Regex.Match(cmbKaryawan.SelectedItem.ToString(), @"\d+").Value);

            string ssqlKaryawan = "SELECT karyawan.*, golongan.nama as nama_golongan, golongan.honor as honor FROM karyawan " +
                "INNER JOIN golongan " +
                "ON karyawan.id_golongan = golongan.id " +
                "WHERE karyawan.id = " + idKaryawan;

            cmd = new SqlCommand(ssqlKaryawan, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            txtGolongan.Text = reader["nama_golongan"].ToString();
            txtHonor.Text= string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", reader["honor"]);
            txtHonorNumber.Text = reader["honor"].ToString();
            reader.Close();

            generate_data_gaji(idKaryawan);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int idKaryawan = int.Parse(Regex.Match(cmbKaryawan.SelectedItem.ToString(), @"\d+").Value);
            int bulan = int.Parse(cmbBulan.SelectedItem.ToString());
            int tahun = int.Parse(txtTahun.Text.ToString());

            string sqlcek = "SELECT * FROM gaji " +
                "WHERE id_karyawan = " + idKaryawan + 
                " AND bulan = " + bulan + 
                " AND tahun =" + tahun;

            cmd = new SqlCommand(sqlcek, conn);
            reader = cmd.ExecuteReader();

            var statusGaji = reader.HasRows;
            if (statusGaji)
            {
                MessageBox.Show("Gaji bulan ini sudah dicetak, untuk mencetak ulang silahkan hapus terlebih dahulu history bulan ini",
                    "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reader.Close();
            }
            else
            {
                reader.Close();
                string sqlAbsensi = "SELECT COUNT(*) FROM absensi " +
                    "WHERE id_karyawan ="+idKaryawan+
                    " AND MONTH(tanggal) ="+bulan+
                    " AND YEAR(tanggal) ="+tahun+
                    " AND status = 'Hadir'";

                cmd = new SqlCommand(sqlAbsensi, conn);
                reader = cmd.ExecuteReader();
                int kehadiran;
                if (reader.Read())
                {
                     kehadiran = reader.GetInt32(0);
                }
                else
                {
                     kehadiran = 0;
                }

                reader.Close();


                float honor = float.Parse(txtHonorNumber.Text.ToString());
                float totalGaji = honor* float.Parse(kehadiran.ToString());

                string message = "Rincian total kehadiran: " + kehadiran + " hari. Total honor yang diterima: " + string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", totalGaji) + ".";
                MessageBox.Show(message);
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string sqlInsert = "INSERT INTO gaji (id_karyawan, bulan, tahun, total, kehadiran, honor) " +
                        "VALUES (" + idKaryawan + ", '" + bulan + "', '" + tahun + "', " + totalGaji + ", "+kehadiran+", "+honor+")";
                    cmd = new SqlCommand(sqlInsert, conn);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("Data berhasil disimpan.");

                    this.Close();
                    Gaji gaji = new Gaji();
                    gaji.Show();
                }
                else
                {
                    MessageBox.Show("Data tidak disimpan.");
                }
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dataGaji.SelectedRows.Count > 0)
            {

                PrintDocument printDocument = new PrintDocument();
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("A5", 595, 842);
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.PrinterSettings = printDialog.PrinterSettings;
                }
                printDocument.Print();
            }
            
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            string nama = dataGaji.SelectedRows[0].Cells[1].Value.ToString();
            string golongan = dataGaji.SelectedRows[0].Cells[2].Value.ToString();
            string bulan = dataGaji.SelectedRows[0].Cells[3].Value.ToString();
            string tahun = dataGaji.SelectedRows[0].Cells[4].Value.ToString();
            string kehadiran = dataGaji.SelectedRows[0].Cells[5].Value.ToString();
            string honor = dataGaji.SelectedRows[0].Cells[6].Value.ToString();
            honor = string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", honor);
            string gaji = dataGaji.SelectedRows[0].Cells[7].Value.ToString();
            gaji = string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", gaji);
            string tanggal = DateTime.Now.ToString("dd/MM/yyyy");

            e.Graphics.DrawString("Slip Gaji", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(250, 50));
            e.Graphics.DrawString("Nama             : " + nama, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("Golongan/Jabatan : " + golongan, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 130));
            e.Graphics.DrawString("Bulan            : " + bulan, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 160));
            e.Graphics.DrawString("Tahun            : " + tahun, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 190));
            e.Graphics.DrawString("Kehadiran        : " + kehadiran +" Hari", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 220));
            e.Graphics.DrawString("Honor/Hari       : " + honor, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Gaji             : " + gaji, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 280));
            e.Graphics.DrawString("Dicetak pada " + tanggal, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 310));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dataGaji.SelectedRows[0].Cells[0].Value.ToString());
                string ssql = "DELETE FROM gaji WHERE id=" + id;
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                reader.Close();

                this.Close();
                Gaji gaji = new Gaji();
                gaji.Show();
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Gaji gaji = new Gaji();
            gaji.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
