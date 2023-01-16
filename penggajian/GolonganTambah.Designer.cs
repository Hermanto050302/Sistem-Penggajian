namespace penggajian
{
    partial class GolonganTambah
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHonor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(277, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHonor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 79);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Tambah";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(58, 19);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(247, 20);
            this.txtNama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Honor";
            // 
            // txtHonor
            // 
            this.txtHonor.Location = new System.Drawing.Point(58, 45);
            this.txtHonor.Name = "txtHonor";
            this.txtHonor.Size = new System.Drawing.Size(132, 20);
            this.txtHonor.TabIndex = 6;
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
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Green;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(196, 158);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tambah Data Golongan";
            // 
            // GolonganTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Name = "GolonganTambah";
            this.Text = "Tambah Data Golongan";
            this.Load += new System.EventHandler(this.GolonganTambah_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHonor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
    }
}