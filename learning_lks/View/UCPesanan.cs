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
    public partial class UCPesanan : UserControl
    {
        public UCPesanan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string search = "")
        {
            try
            {
                string sql = @"SELECT so.OrderId as [ID], so.OrderDate as [Tanggal Pemesanan], so.SupplierName as [Pemasok], m.MaterialName as [Bahan], so.OrderQuantity as [Jumlah], 
                so.Unit as [Satuan], so.Status, so.Notes from SupplierOrders as so inner join RawMaterials m on so.MaterialId = m.MaterialId Where so.SupplierName LIKE @search OR  m.MaterialName LIKE @search OR so.status LIKE @search";
                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvPemasok.DataSource = dt;
            }
            catch (Exception ex)
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPemasok.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di hapus", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (MessageBox.Show(
          "Yakin ingin menghapus data pesanan yang ingin di pilih?",
          "Silakan Konfirmasi",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
          ) != DialogResult.Yes)
                return;
            try
            {
                Database.Execute("DELETE FROM SupplierOrders where OrderId=@id", Database.P("@id", Convert.ToInt32(dgvPemasok.CurrentRow.Cells[0].Value)));
                LoadData();
                MessageBox.Show("Data pesanan berhasil di hapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UbahStatus_Click(object sender, EventArgs e)
        {
            if (dgvPemasok.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di ubah status", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string status = dgvPemasok.CurrentRow.Cells[6].Value.ToString();

            string statusBaru = status == "Pending" ? "Proses" :
                                status == "Proses" ? "Selesai" : null;

            if (statusBaru == null)
            {
                MessageBox.Show("Status sudah Selesai.");
                return;
            }

            if (MessageBox.Show(
                $"Yakin ingin mengubah status menjadi {statusBaru}?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.Execute(
                    "UPDATE SupplierOrders SET Status = @status WHERE OrderId = @id",
                    Database.P("@status", statusBaru),
                    Database.P("@id", Convert.ToInt32(dgvPemasok.CurrentRow.Cells[0].Value))
                );

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvPemasok.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di ubah", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (var f = new ForrmPemasok(Convert.ToInt32(dgvPemasok.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var f = new ForrmPemasok())
                if(f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }
    }
}
