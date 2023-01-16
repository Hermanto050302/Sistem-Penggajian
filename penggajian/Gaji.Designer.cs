namespace penggajian
{
    partial class Gaji
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
            this.dataGaji = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHonorNumber = new System.Windows.Forms.TextBox();
            this.txtHonor = new System.Windows.Forms.TextBox();
            this.txtGolongan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKaryawan = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.cmbBulan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGaji)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gaji karyawan";
            // 
            // dataGaji
            // 
            this.dataGaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGaji.Location = new System.Drawing.Point(320, 69);
            this.dataGaji.Name = "dataGaji";
            this.dataGaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGaji.Size = new System.Drawing.Size(797, 248);
            this.dataGaji.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHonorNumber);
            this.groupBox1.Controls.Add(this.txtHonor);
            this.groupBox1.Controls.Add(this.txtGolongan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbKaryawan);
            this.groupBox1.Location = new System.Drawing.Point(17, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 134);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Karyawan";
            // 
            // txtHonorNumber
            // 
            this.txtHonorNumber.Location = new System.Drawing.Point(203, 89);
            this.txtHonorNumber.Name = "txtHonorNumber";
            this.txtHonorNumber.ReadOnly = true;
            this.txtHonorNumber.Size = new System.Drawing.Size(48, 20);
            this.txtHonorNumber.TabIndex = 6;
            this.txtHonorNumber.Visible = false;
            // 
            // txtHonor
            // 
            this.txtHonor.Location = new System.Drawing.Point(97, 89);
            this.txtHonor.Name = "txtHonor";
            this.txtHonor.ReadOnly = true;
            this.txtHonor.Size = new System.Drawing.Size(100, 20);
            this.txtHonor.TabIndex = 5;
            // 
            // txtGolongan
            // 
            this.txtGolongan.Location = new System.Drawing.Point(97, 57);
            this.txtGolongan.Name = "txtGolongan";
            this.txtGolongan.ReadOnly = true;
            this.txtGolongan.Size = new System.Drawing.Size(100, 20);
            this.txtGolongan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Honor Harian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Golongan/\r\nJataban\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Karyawan";
            // 
            // cmbKaryawan
            // 
            this.cmbKaryawan.FormattingEnabled = true;
            this.cmbKaryawan.Location = new System.Drawing.Point(97, 24);
            this.cmbKaryawan.Name = "cmbKaryawan";
            this.cmbKaryawan.Size = new System.Drawing.Size(177, 21);
            this.cmbKaryawan.TabIndex = 0;
            this.cmbKaryawan.SelectedIndexChanged += new System.EventHandler(this.cmbKaryawan_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.txtTahun);
            this.groupBox2.Controls.Add(this.cmbBulan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(17, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Gaji";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 85);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(268, 37);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(177, 27);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(97, 20);
            this.txtTahun.TabIndex = 6;
            // 
            // cmbBulan
            // 
            this.cmbBulan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBulan.FormattingEnabled = true;
            this.cmbBulan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbBulan.Location = new System.Drawing.Point(55, 26);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.Size = new System.Drawing.Size(46, 21);
            this.cmbBulan.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tahun";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bulan";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1042, 323);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(320, 323);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 23);
            this.btnCetak.TabIndex = 9;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(401, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 43);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Kembali ke Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Gaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 420);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGaji);
            this.Controls.Add(this.label1);
            this.Name = "Gaji";
            this.Text = "Gaji";
            this.Load += new System.EventHandler(this.Gaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGaji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGaji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHonor;
        private System.Windows.Forms.TextBox txtGolongan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKaryawan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.ComboBox cmbBulan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtHonorNumber;
    }
}