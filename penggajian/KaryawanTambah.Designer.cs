namespace penggajian
{
    partial class KaryawanTambah
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGolongan = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNoHP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGolongan);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 162);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Tambah";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(77, 72);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(228, 20);
            this.txtNoHP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "No HP";
            // 
            // cmbGolongan
            // 
            this.cmbGolongan.FormattingEnabled = true;
            this.cmbGolongan.Location = new System.Drawing.Point(77, 45);
            this.cmbGolongan.Name = "cmbGolongan";
            this.cmbGolongan.Size = new System.Drawing.Size(228, 21);
            this.cmbGolongan.TabIndex = 8;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(77, 19);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(228, 20);
            this.txtNama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Golongan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tambah Data Karyawan";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(277, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Green;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(196, 237);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // KaryawanTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Name = "KaryawanTambah";
            this.Text = "KaryawanTambah";
            this.Load += new System.EventHandler(this.KaryawanTambah_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGolongan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSimpan;
    }
}