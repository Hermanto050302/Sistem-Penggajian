using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penggajian
{
    public partial class Karyawan : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public Karyawan()
        {
            InitializeComponent();
        }

        private void Karyawan_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);

            dataKaryawan.Rows.Clear();
            dataKaryawan.Columns.Clear();

            dataKaryawan.Columns.Add("ID", "ID");
            dataKaryawan.Columns.Add("Golongan", "Golongan");
            dataKaryawan.Columns.Add("Nama", "Nama");
            dataKaryawan.Columns.Add("NoHP", "No HP");
            dataKaryawan.Columns.Add("Email", "Email");

            conn.Open();

            string ssql = "SELECT karyawan.*, golongan.nama as nama_golongan FROM karyawan INNER JOIN golongan ON karyawan.id_golongan = golongan.id";
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read())
                {
                    int n = dataKaryawan.Rows.Add();
                    dataKaryawan.Rows[n].Cells[0].Value = reader["id"].ToString();
                    dataKaryawan.Rows[n].Cells[1].Value = reader["nama_golongan"].ToString();
                    dataKaryawan.Rows[n].Cells[2].Value = reader["nama"].ToString();
                    dataKaryawan.Rows[n].Cells[3].Value = reader["no_hp"].ToString();
                    dataKaryawan.Rows[n].Cells[4].Value = reader["email"].ToString();
                }
            }

            reader.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            KaryawanTambah tambah = new KaryawanTambah();
            tambah.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataKaryawan.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataKaryawan.SelectedRows[0].Cells[0].Value.ToString());
                KaryawanEdit edit = new KaryawanEdit(id);
                edit.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Karyawan karyawan = new Karyawan();
            karyawan.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dataKaryawan.SelectedRows[0].Cells[0].Value.ToString());
                string ssql = "DELETE FROM karyawan WHERE id=" + id;
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                reader.Close();

                this.Close();
                Karyawan karyawan = new Karyawan();
                karyawan.Show();
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
