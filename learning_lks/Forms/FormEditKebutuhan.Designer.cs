namespace learning_lks.Forms
{
    partial class FormEditKebutuhan
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
            this.inCatatan = new System.Windows.Forms.TextBox();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.inSatuan = new System.Windows.Forms.TextBox();
            this.inJumlah = new System.Windows.Forms.TextBox();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblBahan = new System.Windows.Forms.Label();
            this.lblTanggalKebutuhan = new System.Windows.Forms.Label();
            this.inDate = new System.Windows.Forms.DateTimePicker();
            this.inBahan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inCatatan
            // 
            this.inCatatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inCatatan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCatatan.Location = new System.Drawing.Point(37, 368);
            this.inCatatan.Multiline = true;
            this.inCatatan.Name = "inCatatan";
            this.inCatatan.Size = new System.Drawing.Size(605, 68);
            this.inCatatan.TabIndex = 33;
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatatan.Location = new System.Drawing.Point(33, 342);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(72, 23);
            this.lblCatatan.TabIndex = 32;
            this.lblCatatan.Text = "Catatan";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(497, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 46);
            this.button2.TabIndex = 31;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSimpan.Location = new System.Drawing.Point(326, 453);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(165, 46);
            this.btnSimpan.TabIndex = 30;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // inSatuan
            // 
            this.inSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inSatuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inSatuan.Location = new System.Drawing.Point(37, 292);
            this.inSatuan.Multiline = true;
            this.inSatuan.Name = "inSatuan";
            this.inSatuan.Size = new System.Drawing.Size(605, 36);
            this.inSatuan.TabIndex = 29;
            // 
            // inJumlah
            // 
            this.inJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inJumlah.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inJumlah.Location = new System.Drawing.Point(37, 217);
            this.inJumlah.Multiline = true;
            this.inJumlah.Name = "inJumlah";
            this.inJumlah.Size = new System.Drawing.Size(605, 34);
            this.inJumlah.TabIndex = 28;
            // 
            // lblSatuan
            // 
            this.lblSatuan.AutoSize = true;
            this.lblSatuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatuan.Location = new System.Drawing.Point(33, 266);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(65, 23);
            this.lblSatuan.TabIndex = 25;
            this.lblSatuan.Text = "Satuan";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(33, 191);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(68, 23);
            this.lblJumlah.TabIndex = 24;
            this.lblJumlah.Text = "Jumlah";
            // 
            // lblBahan
            // 
            this.lblBahan.AutoSize = true;
            this.lblBahan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBahan.Location = new System.Drawing.Point(33, 111);
            this.lblBahan.Name = "lblBahan";
            this.lblBahan.Size = new System.Drawing.Size(59, 23);
            this.lblBahan.TabIndex = 23;
            this.lblBahan.Text = "Bahan";
            // 
            // lblTanggalKebutuhan
            // 
            this.lblTanggalKebutuhan.AutoSize = true;
            this.lblTanggalKebutuhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalKebutuhan.Location = new System.Drawing.Point(33, 33);
            this.lblTanggalKebutuhan.Name = "lblTanggalKebutuhan";
            this.lblTanggalKebutuhan.Size = new System.Drawing.Size(166, 23);
            this.lblTanggalKebutuhan.TabIndex = 22;
            this.lblTanggalKebutuhan.Text = "Tanggal Kebutuhan";
            // 
            // inDate
            // 
            this.inDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDate.Location = new System.Drawing.Point(37, 65);
            this.inDate.Name = "inDate";
            this.inDate.Size = new System.Drawing.Size(603, 30);
            this.inDate.TabIndex = 34;
            // 
            // inBahan
            // 
            this.inBahan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inBahan.FormattingEnabled = true;
            this.inBahan.Location = new System.Drawing.Point(37, 137);
            this.inBahan.Name = "inBahan";
            this.inBahan.Size = new System.Drawing.Size(600, 36);
            this.inBahan.TabIndex = 35;
            // 
            // FormEditKebutuhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 520);
            this.Controls.Add(this.inBahan);
            this.Controls.Add(this.inDate);
            this.Controls.Add(this.inCatatan);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.inSatuan);
            this.Controls.Add(this.inJumlah);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblBahan);
            this.Controls.Add(this.lblTanggalKebutuhan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditKebutuhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditKebutuhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inCatatan;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox inSatuan;
        private System.Windows.Forms.TextBox inJumlah;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblBahan;
        private System.Windows.Forms.Label lblTanggalKebutuhan;
        private System.Windows.Forms.DateTimePicker inDate;
        private System.Windows.Forms.ComboBox inBahan;
    }
}