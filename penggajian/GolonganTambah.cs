using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace penggajian
{
    public partial class GolonganTambah : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public GolonganTambah()
        {
            InitializeComponent();
        }

        private void GolonganTambah_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtHonor.Text, out float result))
            {
                MessageBox.Show("Honor harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string nama = txtNama.Text.ToString();
            float honor = float.Parse(txtHonor.Text.ToString());

            string ssql = "INSERT INTO golongan (nama, honor) VALUES ('" + nama + "', " + honor + ")";
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
