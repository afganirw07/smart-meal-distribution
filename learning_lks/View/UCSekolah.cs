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
    public partial class UCSekolah : UserControl
    {
        public UCSekolah()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string search = "")
        {
            try
            {
                string sql = @"Select SchoolId AS [ID Sekolah], SchoolName AS [Nama Sekolah], Address AS [Alamat], PICName AS [Kepala Sekolah], PICPhone AS [Nomer Telepon], StudentCount AS [Jumlah Murid] from Schools WHERE SchoolName LIKE @search";
                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvSekolah.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show(
                   "Gagal Mengload Data:" + ex,
                   "Terjadi Kesalahan",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                   );
            }
        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(btnSearch.Text.Trim());
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            if (dgvSekolah.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di hapus", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (MessageBox.Show(
               "Yakin ingin menghapus data sekolah yang ingin di pilih?",
               "Silakan Konfirmasi",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
               ) != DialogResult.Yes)
                return;

            try
            {
                Database.Execute("DELETE FROM Schools WHERE SchoolId=@id", Database.P("@id", Convert.ToInt32(dgvSekolah.CurrentRow.Cells[0].Value)));
                LoadData();
                MessageBox.Show("Data berhasil di hapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch (Exception ex)
            {
                MessageBox.Show("Data bahan baku gagal di hapus:" + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            {

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvSekolah.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di edit", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (var f = new FormsEditSekolah(Convert.ToInt32(dgvSekolah.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using(var f = new FormsEditSekolah())
                if (f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }
    }
}
