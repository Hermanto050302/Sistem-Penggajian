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
    public partial class AbsenEdit : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        private int id;

        public AbsenEdit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AbsenEdit_Load(object sender, EventArgs e)
        {
            string connstring = Properties.Settings.Default.Connection;
            conn = new SqlConnection(connstring);
            conn.Open();

            string ssql = "SELECT * FROM absensi WHERE id=" + id;
            cmd = new SqlCommand(ssql, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            txtId.Text = reader["id"].ToString();

            reader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Silahkan pilih item dari combo box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(txtId.Text.ToString());
            string status = cmbStatus.SelectedItem.ToString();

            string ssql = "UPDATE absensi SET status='" + status + "' WHERE id=" + id;
            cmd = new SqlCommand(ssql, conn);

            reader = cmd.ExecuteReader();

            this.Close();
            MessageBox.Show("Data berhasil diupdate! \n silahkan tekan tombol refresh untuk melihat pembaruan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
