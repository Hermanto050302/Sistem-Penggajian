namespace penggajian
{
    partial class Golongan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.penggajianDataSet = new penggajian.penggajianDataSet();
            this.golonganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.golonganTableAdapter = new penggajian.penggajianDataSetTableAdapters.golonganTableAdapter();
            this.dataGolongan = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.penggajianDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golonganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGolongan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Golongan";
            // 
            // penggajianDataSet
            // 
            this.penggajianDataSet.DataSetName = "penggajianDataSet";
            this.penggajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // golonganBindingSource
            // 
            this.golonganBindingSource.DataMember = "golongan";
            this.golonganBindingSource.DataSource = this.penggajianDataSet;
            // 
            // golonganTableAdapter
            // 
            this.golonganTableAdapter.ClearBeforeFill = true;
            // 
            // dataGolongan
            // 
            this.dataGolongan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGolongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGolongan.Location = new System.Drawing.Point(17, 95);
            this.dataGolongan.Name = "dataGolongan";
            this.dataGolongan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGolongan.Size = new System.Drawing.Size(563, 150);
            this.dataGolongan.TabIndex = 1;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(17, 59);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(99, 30);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "Tambah Data";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(17, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(122, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(505, 66);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(17, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 43);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Kembali ke Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Golongan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 394);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGolongan);
            this.Controls.Add(this.label1);
            this.Name = "Golongan";
            this.Text = "Golongan";
            this.Load += new System.EventHandler(this.Golongan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.penggajianDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golonganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGolongan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private penggajianDataSet penggajianDataSet;
        private System.Windows.Forms.BindingSource golonganBindingSource;
        private penggajianDataSetTableAdapters.golonganTableAdapter golonganTableAdapter;
        private System.Windows.Forms.DataGridView dataGolongan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
    }
}