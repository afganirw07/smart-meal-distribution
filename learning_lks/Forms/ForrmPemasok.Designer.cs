namespace learning_lks.Forms
{
    partial class ForrmPemasok
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
            this.inDate = new System.Windows.Forms.DateTimePicker();
            this.inSatuan = new System.Windows.Forms.TextBox();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.inPesan = new System.Windows.Forms.TextBox();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblPemasok = new System.Windows.Forms.Label();
            this.lblTanggalPesanan = new System.Windows.Forms.Label();
            this.inCatatan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inBahanBaku = new System.Windows.Forms.ComboBox();
            this.inStatus = new System.Windows.Forms.ComboBox();
            this.inPemasok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inDate
            // 
            this.inDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDate.Location = new System.Drawing.Point(36, 59);
            this.inDate.Name = "inDate";
            this.inDate.Size = new System.Drawing.Size(603, 30);
            this.inDate.TabIndex = 46;
            // 
            // inSatuan
            // 
            this.inSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inSatuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inSatuan.Location = new System.Drawing.Point(36, 362);
            this.inSatuan.Multiline = true;
            this.inSatuan.Name = "inSatuan";
            this.inSatuan.Size = new System.Drawing.Size(605, 36);
            this.inSatuan.TabIndex = 45;
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatatan.Location = new System.Drawing.Point(32, 336);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(65, 23);
            this.lblCatatan.TabIndex = 44;
            this.lblCatatan.Text = "Satuan";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBatal.Location = new System.Drawing.Point(476, 582);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(165, 46);
            this.btnBatal.TabIndex = 43;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(305, 582);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(165, 46);
            this.btnSimpan.TabIndex = 42;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // inPesan
            // 
            this.inPesan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inPesan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPesan.Location = new System.Drawing.Point(36, 286);
            this.inPesan.Multiline = true;
            this.inPesan.Name = "inPesan";
            this.inPesan.Size = new System.Drawing.Size(605, 36);
            this.inPesan.TabIndex = 41;
            // 
            // lblSatuan
            // 
            this.lblSatuan.AutoSize = true;
            this.lblSatuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatuan.Location = new System.Drawing.Point(32, 260);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(117, 23);
            this.lblSatuan.TabIndex = 39;
            this.lblSatuan.Text = "Jumlah Pesan";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(32, 185);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(104, 23);
            this.lblJumlah.TabIndex = 38;
            this.lblJumlah.Text = "Bahan Baku";
            // 
            // lblPemasok
            // 
            this.lblPemasok.AutoSize = true;
            this.lblPemasok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPemasok.Location = new System.Drawing.Point(32, 105);
            this.lblPemasok.Name = "lblPemasok";
            this.lblPemasok.Size = new System.Drawing.Size(132, 23);
            this.lblPemasok.TabIndex = 37;
            this.lblPemasok.Text = "Nama Pemasok";
            // 
            // lblTanggalPesanan
            // 
            this.lblTanggalPesanan.AutoSize = true;
            this.lblTanggalPesanan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPesanan.Location = new System.Drawing.Point(32, 27);
            this.lblTanggalPesanan.Name = "lblTanggalPesanan";
            this.lblTanggalPesanan.Size = new System.Drawing.Size(142, 23);
            this.lblTanggalPesanan.TabIndex = 36;
            this.lblTanggalPesanan.Text = "Tanggal Pesanan";
            // 
            // inCatatan
            // 
            this.inCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inCatatan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCatatan.Location = new System.Drawing.Point(36, 509);
            this.inCatatan.Multiline = true;
            this.inCatatan.Name = "inCatatan";
            this.inCatatan.Size = new System.Drawing.Size(605, 54);
            this.inCatatan.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Catatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Status";
            // 
            // inBahanBaku
            // 
            this.inBahanBaku.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBahanBaku.FormattingEnabled = true;
            this.inBahanBaku.Location = new System.Drawing.Point(36, 211);
            this.inBahanBaku.Name = "inBahanBaku";
            this.inBahanBaku.Size = new System.Drawing.Size(601, 39);
            this.inBahanBaku.TabIndex = 53;
            // 
            // inStatus
            // 
            this.inStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStatus.FormattingEnabled = true;
            this.inStatus.Location = new System.Drawing.Point(36, 433);
            this.inStatus.Name = "inStatus";
            this.inStatus.Size = new System.Drawing.Size(601, 33);
            this.inStatus.TabIndex = 54;
            // 
            // inPemasok
            // 
            this.inPemasok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inPemasok.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPemasok.Location = new System.Drawing.Point(34, 131);
            this.inPemasok.Multiline = true;
            this.inPemasok.Name = "inPemasok";
            this.inPemasok.Size = new System.Drawing.Size(605, 36);
            this.inPemasok.TabIndex = 55;
            // 
            // ForrmPemasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 640);
            this.Controls.Add(this.inPemasok);
            this.Controls.Add(this.inStatus);
            this.Controls.Add(this.inBahanBaku);
            this.Controls.Add(this.inCatatan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inDate);
            this.Controls.Add(this.inSatuan);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.inPesan);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblPemasok);
            this.Controls.Add(this.lblTanggalPesanan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForrmPemasok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForrmPemasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker inDate;
        private System.Windows.Forms.TextBox inSatuan;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox inPesan;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblPemasok;
        private System.Windows.Forms.Label lblTanggalPesanan;
        private System.Windows.Forms.TextBox inCatatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inBahanBaku;
        private System.Windows.Forms.ComboBox inStatus;
        private System.Windows.Forms.TextBox inPemasok;
    }
}