namespace penggajian
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnGolongan = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.btnAbsensi = new System.Windows.Forms.Button();
            this.btnGaji = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLprAbsensi = new System.Windows.Forms.Button();
            this.BtnLprGaji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistem Penggajian\r\nKaryawan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGolongan
            // 
            this.btnGolongan.Location = new System.Drawing.Point(67, 124);
            this.btnGolongan.Name = "btnGolongan";
            this.btnGolongan.Size = new System.Drawing.Size(252, 37);
            this.btnGolongan.TabIndex = 1;
            this.btnGolongan.Text = "Data Golongan";
            this.btnGolongan.UseVisualStyleBackColor = true;
            this.btnGolongan.Click += new System.EventHandler(this.btnGolongan_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.Location = new System.Drawing.Point(67, 167);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(252, 37);
            this.btnKaryawan.TabIndex = 2;
            this.btnKaryawan.Text = "Data Karyawan";
            this.btnKaryawan.UseVisualStyleBackColor = true;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // btnAbsensi
            // 
            this.btnAbsensi.Location = new System.Drawing.Point(67, 210);
            this.btnAbsensi.Name = "btnAbsensi";
            this.btnAbsensi.Size = new System.Drawing.Size(252, 37);
            this.btnAbsensi.TabIndex = 3;
            this.btnAbsensi.Text = "Absensi";
            this.btnAbsensi.UseVisualStyleBackColor = true;
            this.btnAbsensi.Click += new System.EventHandler(this.btnAbsensi_Click);
            // 
            // btnGaji
            // 
            this.btnGaji.Location = new System.Drawing.Point(67, 253);
            this.btnGaji.Name = "btnGaji";
            this.btnGaji.Size = new System.Drawing.Size(252, 37);
            this.btnGaji.TabIndex = 4;
            this.btnGaji.Text = "Gaji";
            this.btnGaji.UseVisualStyleBackColor = true;
            this.btnGaji.Click += new System.EventHandler(this.btnGaji_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Laporan";
            // 
            // BtnLprAbsensi
            // 
            this.BtnLprAbsensi.Location = new System.Drawing.Point(67, 336);
            this.BtnLprAbsensi.Name = "BtnLprAbsensi";
            this.BtnLprAbsensi.Size = new System.Drawing.Size(118, 30);
            this.BtnLprAbsensi.TabIndex = 6;
            this.BtnLprAbsensi.Text = "Absensi";
            this.BtnLprAbsensi.UseVisualStyleBackColor = true;
            this.BtnLprAbsensi.Click += new System.EventHandler(this.BtnLprAbsensi_Click);
            // 
            // BtnLprGaji
            // 
            this.BtnLprGaji.Location = new System.Drawing.Point(201, 336);
            this.BtnLprGaji.Name = "BtnLprGaji";
            this.BtnLprGaji.Size = new System.Drawing.Size(118, 30);
            this.BtnLprGaji.TabIndex = 7;
            this.BtnLprGaji.Text = "Gaji";
            this.BtnLprGaji.UseVisualStyleBackColor = true;
            this.BtnLprGaji.Click += new System.EventHandler(this.BtnLprGaji_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 425);
            this.Controls.Add(this.BtnLprGaji);
            this.Controls.Add(this.BtnLprAbsensi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGaji);
            this.Controls.Add(this.btnAbsensi);
            this.Controls.Add(this.btnKaryawan);
            this.Controls.Add(this.btnGolongan);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGolongan;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.Button btnAbsensi;
        private System.Windows.Forms.Button btnGaji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLprAbsensi;
        private System.Windows.Forms.Button BtnLprGaji;
    }
}