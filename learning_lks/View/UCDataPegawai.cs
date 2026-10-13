using learning_lks.Forms;
using learning_lks.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning_lks.View
{
    public partial class UCDataPegawai : UserControl
    {
        public UCDataPegawai()
        {
            InitializeComponent();
            LoadDataEmployes();
        }

        private void LoadDataEmployes(string search = "")
        {
            try
            {
            string sql = @"Select EmployeeId AS [Id Pegawai], EmployeeName AS [Nama Pegawai], Position As Jabatan, Phone As [Nomer Telepon], Address AS Alamat from Employees WHERE EmployeeName LIKE @Search OR Position LIKE @Search;";
                var dt = Database.Query(sql, Database.P("@Search", "%" + search + "%"));
            dgvEmployes.DataSource = dt;

            } catch(Exception ex)
            {
                MessageBox.Show(
                    "Terjadi Kesalahan Saat Memuat Data :" + ex,
                    "Terjadi Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataEmployes(btnSearch.Text.Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployes.CurrentRow == null)
            {
                MessageBox.Show(
                    "Silakan pilih terlebih dahulu data yang ingin di hapus!",
                    "Terjadi Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                    );
                return;
            }

            if (MessageBox.Show(
                "Yakin ingin menghapus data pegawai yang ingin di pilih?",
                "Silakan Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) != DialogResult.Yes)
                return;

            try
            {
                Database.Execute("DELETE FROM Employees WHERE EmployeeId=@i", Database.P("@i", Convert.ToInt32(dgvEmployes.CurrentRow.Cells[0].Value)));
                LoadDataEmployes();
                MessageBox.Show("Data karyawan berhasil di hapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data karyawan" + ex,
                    "Gagal Menghapus",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvEmployes.CurrentRow == null)
            {
                MessageBox.Show(
                                  "Silakan pilih terlebih dahulu data yang ingin di diubah!",
                                  "Terjadi Kesalahan",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Asterisk
                                  );
                return;
            }

            using (var f = new FormEditEmployes(Convert.ToInt32(dgvEmployes.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) { LoadDataEmployes(); }

        }

        private void btnNambah_Click(object sender, EventArgs e)
        {
            using (var f = new FormEditEmployes())
                if (f.ShowDialog() == DialogResult.OK) { LoadDataEmployes(); }
        }
    }
}
