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
    public partial class    UCBahanBaku : UserControl
    {
        public UCBahanBaku()
        {
            InitializeComponent();
            LoadDataBahanBaku();
        }

        private void LoadDataBahanBaku(string search = "")
        {
            try
            {
                string sql = @"SELECT MaterialId AS [Material Id], MaterialName AS [Nama Material], Category, Unit, Stock, EstimatedPrice AS [Harga] FROM RawMaterials WHERE MaterialName LIKE @search OR Category LIKE @search";
                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvBahanBaku.DataSource = dt;
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

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            if (dgvBahanBaku.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di hapus", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (MessageBox.Show(
               "Yakin ingin menghapus data bahan baku yang ingin di pilih?",
               "Silakan Konfirmasi",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
               ) != DialogResult.Yes)
                return;

            try
            {
                Database.Execute("Delete from RawMaterials where MaterialId= @i", Database.P("@i", Convert.ToInt32( dgvBahanBaku.CurrentRow.Cells[0].Value)));
                LoadDataBahanBaku();
                MessageBox.Show("Data bahan baku berhasil di hapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch(Exception ex)
            {
                MessageBox.Show("Data bahan baku gagal di hapus:"+ ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvBahanBaku.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di ubah", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (var f = new FormEditBahanBaku(Convert.ToInt32(dgvBahanBaku.CurrentRow.Cells[0].Value)))
            if (f.ShowDialog() == DialogResult.OK) { LoadDataBahanBaku(); }
        }

        private void btnNambah_Click(object sender, EventArgs e)
        {
            using(var f = new FormEditBahanBaku())
                if (f.ShowDialog() == DialogResult.OK) { LoadDataBahanBaku(); }
        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataBahanBaku(btnSearch.Text.Trim());
        }
    }
}
