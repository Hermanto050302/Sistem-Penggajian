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
    public partial class KaryawanEdit : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        private int id;

        public KaryawanEdit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void KaryawanEdit_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();

            string ssql = "SELECT * FROM karyawan WHERE id=" + id;
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            txtId.Text = reader["id"].ToString();
            txtGolongan.Text = reader["id_golongan"].ToString();
            txtNama.Text = reader["nama"].ToString();
            txtNoHP.Text = reader["no_hp"].ToString();
            txtEmail.Text = reader["email"].ToString();
            
            reader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || 
                string.IsNullOrEmpty(txtGolongan.Text) ||
                string.IsNullOrEmpty(txtNoHP.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Input tidak boleh ada yang kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(txtId.Text.ToString()), id_golongan = int.Parse(txtGolongan.Text.ToString());
            string nama = txtNama.Text.ToString(), email = txtEmail.Text.ToString(), noHp = txtNoHP.Text.ToString();

            string ssql = "UPDATE karyawan SET nama='" + nama + "', id_golongan=" + id_golongan + " ,no_hp='" + noHp + "' ,email='" + email + "' WHERE id=" + id;
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
