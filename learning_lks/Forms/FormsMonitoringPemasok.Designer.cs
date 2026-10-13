namespace learning_lks.Forms
{
    partial class FormsMonitoringPemasok
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
            this.inStatusDst = new System.Windows.Forms.ComboBox();
            this.inCatatan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inDate = new System.Windows.Forms.DateTimePicker();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblPemasok = new System.Windows.Forms.Label();
            this.lblTanggalPesanan = new System.Windows.Forms.Label();
            this.inStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inPorsi = new System.Windows.Forms.TextBox();
            this.inSchool = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inStatusDst
            // 
            this.inStatusDst.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStatusDst.FormattingEnabled = true;
            this.inStatusDst.Location = new System.Drawing.Point(44, 368);
            this.inStatusDst.Name = "inStatusDst";
            this.inStatusDst.Size = new System.Drawing.Size(601, 33);
            this.inStatusDst.TabIndex = 70;
            // 
            // inCatatan
            // 
            this.inCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inCatatan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCatatan.Location = new System.Drawing.Point(46, 447);
            this.inCatatan.Multiline = true;
            this.inCatatan.Name = "inCatatan";
            this.inCatatan.Size = new System.Drawing.Size(605, 54);
            this.inCatatan.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Catatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Status Distribusi";
            // 
            // inDate
            // 
            this.inDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDate.Location = new System.Drawing.Point(46, 52);
            this.inDate.Name = "inDate";
            this.inDate.Size = new System.Drawing.Size(603, 30);
            this.inDate.TabIndex = 65;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBatal.Location = new System.Drawing.Point(486, 534);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(165, 46);
            this.btnBatal.TabIndex = 62;
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
            this.btnSimpan.Location = new System.Drawing.Point(315, 534);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(165, 46);
            this.btnSimpan.TabIndex = 61;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(42, 178);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(48, 23);
            this.lblJumlah.TabIndex = 58;
            this.lblJumlah.Text = "Porsi";
            // 
            // lblPemasok
            // 
            this.lblPemasok.AutoSize = true;
            this.lblPemasok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPemasok.Location = new System.Drawing.Point(42, 98);
            this.lblPemasok.Name = "lblPemasok";
            this.lblPemasok.Size = new System.Drawing.Size(73, 23);
            this.lblPemasok.TabIndex = 57;
            this.lblPemasok.Text = "Sekolah";
            // 
            // lblTanggalPesanan
            // 
            this.lblTanggalPesanan.AutoSize = true;
            this.lblTanggalPesanan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalPesanan.Location = new System.Drawing.Point(42, 20);
            this.lblTanggalPesanan.Name = "lblTanggalPesanan";
            this.lblTanggalPesanan.Size = new System.Drawing.Size(142, 23);
            this.lblTanggalPesanan.TabIndex = 56;
            this.lblTanggalPesanan.Text = "Tanggal Pesanan";
            // 
            // inStatus
            // 
            this.inStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStatus.FormattingEnabled = true;
            this.inStatus.Location = new System.Drawing.Point(44, 284);
            this.inStatus.Name = "inStatus";
            this.inStatus.Size = new System.Drawing.Size(601, 33);
            this.inStatus.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Status";
            // 
            // inPorsi
            // 
            this.inPorsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inPorsi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPorsi.Location = new System.Drawing.Point(44, 204);
            this.inPorsi.Multiline = true;
            this.inPorsi.Name = "inPorsi";
            this.inPorsi.Size = new System.Drawing.Size(605, 36);
            this.inPorsi.TabIndex = 74;
            // 
            // inSchool
            // 
            this.inSchool.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inSchool.FormattingEnabled = true;
            this.inSchool.Location = new System.Drawing.Point(46, 124);
            this.inSchool.Name = "inSchool";
            this.inSchool.Size = new System.Drawing.Size(601, 33);
            this.inSchool.TabIndex = 75;
            // 
            // FormsMonitoringPemasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 597);
            this.Controls.Add(this.inSchool);
            this.Controls.Add(this.inPorsi);
            this.Controls.Add(this.inStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inStatusDst);
            this.Controls.Add(this.inCatatan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inDate);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblPemasok);
            this.Controls.Add(this.lblTanggalPesanan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormsMonitoringPemasok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCMonitoringPemasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox inStatusDst;
        private System.Windows.Forms.TextBox inCatatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inDate;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblPemasok;
        private System.Windows.Forms.Label lblTanggalPesanan;
        private System.Windows.Forms.ComboBox inStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inPorsi;
        private System.Windows.Forms.ComboBox inSchool;
    }
}