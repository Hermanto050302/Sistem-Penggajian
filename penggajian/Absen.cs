using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penggajian
{
    public partial class Absen : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public Absen()
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

        private void Absen_Load(object sender, EventArgs e)
        {
            cmbNama.Items.Clear();
            cmbNama.ValueMember = "Value";
            cmbNama.DisplayMember = "Text";


            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();

            string ssql = "SELECT * FROM karyawan";
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmbNama.Items.Add(new { Value = reader["id"].ToString(), Text = reader["nama"].ToString() });
                }
            }

            reader.Close();

            DateTime date = DateTime.Now;
            string bulan = date.ToString("MM");
            string tahun = date.ToString("yyyy");

            string ssql2 = "SELECT absensi.*, karyawan.nama as nama_karyawan FROM absensi " +
                "INNER JOIN karyawan ON absensi.id_karyawan = karyawan.id " +
                "WHERE MONTH(absensi.tanggal) = " + bulan + "  " +
                "AND YEAR(absensi.tanggal) = " + tahun;
            generate_data_absen(ssql2);
            txtBulan.Text = bulan;
            txtTahun.Text = tahun;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (cmbNama.SelectedItem == null && cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Silahkan pilih item dari combo box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DateTime date = DateTime.Now;
            int idKaryawan = int.Parse(Regex.Match(cmbNama.SelectedItem.ToString(), @"\d+").Value);
            string tanggal = date.ToString("s");
            string status = cmbStatus.SelectedItem.ToString();

            string day = date.ToString("dd");
            string bulan = date.ToString("MM");
            string tahun = date.ToString("yyyy");

            string sqlcek = "SELECT * FROM absensi " +
                "WHERE id_karyawan=" + idKaryawan +
                "AND DAY(tanggal) =" + day +
                "AND MONTH(tanggal) =" + bulan +
                "AND YEAR(tanggal) =" + tahun;
            Console.WriteLine(sqlcek);
            cmd = new SqlCommand(sqlcek, conn);
            reader = cmd.ExecuteReader();

            var hasil = reader.HasRows;
            if (hasil)
            {
                reader.Close();
                MessageBox.Show("Karyawan sudah absen pada hari ini", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reader.Close();




            string ssql = "INSERT INTO absensi (id_karyawan, tanggal, status) " +
                "VALUES (" + idKaryawan + ",'" + tanggal + "', '" + status + "')";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();

            this.Close();
            Absen absen = new Absen();
            absen.Show();
            MessageBox.Show("Data berhasil ditambahkan! \n silahkan tekan tombol refresh untuk melihat pembaruan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("s"));
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (cmbNama.SelectedItem == null)
            {
                MessageBox.Show("Silahkan pilih nama karyawan terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bulan = txtBulan.Text.ToString();
            string tahun = txtTahun.Text.ToString();

            string ssql = "SELECT absensi.*, karyawan.nama as nama_karyawan FROM absensi " +
                "INNER JOIN karyawan ON absensi.id_karyawan = karyawan.id " +
                "WHERE MONTH(absensi.tanggal) = " + bulan + "  " +
                "AND YEAR(absensi.tanggal) = " + tahun;

            generate_data_absen(ssql);
            txtBulan.Text = bulan;
            txtTahun.Text = tahun;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataAbsen.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataAbsen.SelectedRows[0].Cells[0].Value.ToString());
                AbsenEdit edit = new AbsenEdit(id);
                edit.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Absen absen = new Absen();
            absen.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string ssql = "SELECT * FROM absensi " +
                "WHERE id_karyawan=1" +
                "AND DAY(tanggal) = 15" +
                "AND MONTH(tanggal) =1" +
                "AND YEAR(tanggal) =2023";
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            var hasil = reader.HasRows;
            Console.WriteLine(hasil);
            reader.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dataAbsen.SelectedRows[0].Cells[0].Value.ToString());
                string ssql = "DELETE FROM absensi WHERE id=" + id;
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                reader.Close();

                this.Close();
                Absen absen = new Absen();
                absen.Show();
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
