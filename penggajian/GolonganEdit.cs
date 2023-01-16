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

namespace penggajian
{
    public partial class GolonganEdit : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        private int id;

        public GolonganEdit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void GolonganEdit_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();

            string ssql = "SELECT * FROM golongan WHERE id="+ id;
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            txtId.Text = reader["id"].ToString();
            txtNama.Text = reader["nama"].ToString();
            txtHonor.Text = reader["honor"].ToString();

            reader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            int id = int.Parse(txtId.Text.ToString());
            string nama = txtNama.Text.ToString();
            float honor = float.Parse(txtHonor.Text.ToString());

            string ssql = "UPDATE golongan SET nama='" + nama + "', honor=" + honor + " WHERE id=" + id;
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();

            this.Close();
            MessageBox.Show("Data berhasil diupdate! \n silahkan tekan tombol refresh untuk melihat pembaruan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
