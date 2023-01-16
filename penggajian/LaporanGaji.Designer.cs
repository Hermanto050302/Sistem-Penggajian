namespace penggajian
{
    partial class LaporanGaji
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBulan = new System.Windows.Forms.ComboBox();
            this.Bulan = new System.Windows.Forms.Label();
            this.dataGaji = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGaji)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(712, 88);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(144, 90);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(120, 20);
            this.txtTahun.TabIndex = 22;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(270, 87);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 21;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tahun";
            // 
            // cmbBulan
            // 
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
            this.cmbBulan.Location = new System.Drawing.Point(16, 89);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.Size = new System.Drawing.Size(121, 21);
            this.cmbBulan.TabIndex = 19;
            // 
            // Bulan
            // 
            this.Bulan.AutoSize = true;
            this.Bulan.Location = new System.Drawing.Point(14, 73);
            this.Bulan.Name = "Bulan";
            this.Bulan.Size = new System.Drawing.Size(34, 13);
            this.Bulan.TabIndex = 18;
            this.Bulan.Text = "Bulan";
            // 
            // dataGaji
            // 
            this.dataGaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGaji.Location = new System.Drawing.Point(12, 115);
            this.dataGaji.Name = "dataGaji";
            this.dataGaji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGaji.Size = new System.Drawing.Size(775, 248);
            this.dataGaji.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Laporan Gaji";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 369);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 43);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Kembali ke Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LaporanGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBulan);
            this.Controls.Add(this.Bulan);
            this.Controls.Add(this.dataGaji);
            this.Controls.Add(this.label1);
            this.Name = "LaporanGaji";
            this.Text = "LaporanGaji";
            this.Load += new System.EventHandler(this.LaporanGaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBulan;
        private System.Windows.Forms.Label Bulan;
        private System.Windows.Forms.DataGridView dataGaji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}