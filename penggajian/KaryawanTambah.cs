using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace penggajian
{
    public partial class KaryawanTambah : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public KaryawanTambah()
        {
            InitializeComponent();
        }

        private void KaryawanTambah_Load(object sender, EventArgs e)
        {
            cmbGolongan.Items.Clear();
            cmbGolongan.ValueMember = "Value";
            cmbGolongan.DisplayMember = "Text";
            

            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();

            string ssql = "SELECT * FROM golongan";
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmbGolongan.Items.Add(new { Value = reader["id"].ToString(), Text = reader["nama"].ToString() });
                }
            }

            reader.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Nama atau Email tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtNoHP.Text, out double result))
            {
                MessageBox.Show("Input harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbGolongan.SelectedItem == null)
            {
                MessageBox.Show("Silahkan pilih item dari combo box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nama = txtNama.Text.ToString(), email = txtEmail.Text.ToString(), noHp = txtNoHP.Text.ToString();
            int idGolongan = int.Parse(Regex.Match(cmbGolongan.SelectedItem.ToString(), @"\d+").Value);

            string ssql = "INSERT INTO karyawan (id_golongan, nama, no_hp, email) VALUES (" + idGolongan + ",'" + nama + "', '" + noHp + "', '" + email + "')";
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();

            this.Close();
            MessageBox.Show("Data berhasil ditambahkan! \n silahkan tekan tombol refresh untuk melihat pembaruan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
