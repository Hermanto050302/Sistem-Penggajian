namespace penggajian
{
    partial class Absen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNama = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataAbsen = new System.Windows.Forms.DataGridView();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtBulan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAbsen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Absensi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbNama);
            this.groupBox1.Location = new System.Drawing.Point(17, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Absen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Hadir",
            "Tidak Hadir"});
            this.cmbStatus.Location = new System.Drawing.Point(97, 58);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(184, 21);
            this.cmbStatus.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Karyawan";
            // 
            // cmbNama
            // 
            this.cmbNama.FormattingEnabled = true;
            this.cmbNama.Location = new System.Drawing.Point(97, 31);
            this.cmbNama.Name = "cmbNama";
            this.cmbNama.Size = new System.Drawing.Size(184, 21);
            this.cmbNama.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(229, 167);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataAbsen
            // 
            this.dataAbsen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAbsen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAbsen.Location = new System.Drawing.Point(351, 68);
            this.dataAbsen.Name = "dataAbsen";
            this.dataAbsen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAbsen.Size = new System.Drawing.Size(377, 163);
            this.dataAbsen.TabIndex = 9;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(560, 36);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 10;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtBulan
            // 
            this.txtBulan.Location = new System.Drawing.Point(388, 38);
            this.txtBulan.Name = "txtBulan";
            this.txtBulan.Size = new System.Drawing.Size(27, 20);
            this.txtBulan.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bulan";
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(478, 38);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(66, 20);
            this.txtTahun.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tahun";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(351, 237);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(653, 237);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(432, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(17, 237);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 43);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Kembali ke Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Absen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 292);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBulan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dataAbsen);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Absen";
            this.Text = "Absen";
            this.Load += new System.EventHandler(this.Absen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAbsen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNama;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataAbsen;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtBulan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}