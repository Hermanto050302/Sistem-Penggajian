using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penggajian
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnGolongan_Click(object sender, EventArgs e)
        {
            Golongan golongan = new Golongan();
            golongan.Show();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            Karyawan karyawan = new Karyawan();
            karyawan.Show();
        }

        private void btnAbsensi_Click(object sender, EventArgs e)
        {
            Absen absen = new Absen();
            absen.Show();
        }

        private void btnGaji_Click(object sender, EventArgs e)
        {
            Gaji gaji = new Gaji();
            gaji.Show();
        }

        private void BtnLprAbsensi_Click(object sender, EventArgs e)
        {
            LaporanAbsensi laporan = new LaporanAbsensi();
            laporan.Show();
        }

        private void BtnLprGaji_Click(object sender, EventArgs e)
        {
            LaporanGaji laporan = new LaporanGaji();
            laporan.Show();
        }
    }
}
