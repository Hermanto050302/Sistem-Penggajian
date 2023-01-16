using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penggajian
{
    public partial class Golongan : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public Golongan()
        {
            InitializeComponent();
        }

        private void Golongan_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);

            dataGolongan.Rows.Clear();
            dataGolongan.Columns.Clear();

            dataGolongan.Columns.Add("ID", "ID");
            dataGolongan.Columns.Add("Nama", "Nama");
            dataGolongan.Columns.Add("Honor", "Honor/hari");

            conn.Open();

            string ssql = "SELECT * FROM golongan";
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                

                while (reader.Read())
                {
                    int n = dataGolongan.Rows.Add();
                    dataGolongan.Rows[n].Cells[0].Value = reader["id"].ToString();
                    dataGolongan.Rows[n].Cells[1].Value = reader["nama"].ToString();
                    dataGolongan.Rows[n].Cells[2].Value = string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", reader["honor"]);
                }
            }

            reader.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGolongan.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGolongan.SelectedRows[0].Cells[0].Value.ToString());
                GolonganEdit edit = new GolonganEdit(id);
                edit.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dataGolongan.SelectedRows[0].Cells[0].Value.ToString());
                string ssql = "DELETE FROM golongan WHERE id=" + id;
                cmd = new SqlCommand(ssql, conn);
                reader = cmd.ExecuteReader();
                reader.Close();

                this.Close();
                Golongan golongan = new Golongan();
                golongan.Show();
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            GolonganTambah tambah = new GolonganTambah();
            tambah.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
            Golongan golongan = new Golongan();
            golongan.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
