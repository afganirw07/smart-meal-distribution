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
    public partial class UCKebutuhanDapur : UserControl
    {
        public UCKebutuhanDapur()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string search = "")
        {
            try
            {
                string sql = @"SELECT
  Kn.NeedId AS [ID],
  Kn.NeedDate AS [Tanggal],
  rm.MaterialName AS [Bahan],
  Kn.Quantity AS [Jumlah],
  Kn.Unit AS [Satuan],
  Kn.Notes AS [Keterangan]
FROM KitchenNeeds AS Kn
LEFT JOIN RawMaterials AS rm ON Kn.MaterialId = rm.MaterialId
Where rm.MaterialName LIKE @search
";
                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvKebutuhan.DataSource = dt;
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKebutuhan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di hapus", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (MessageBox.Show(
            "Yakin ingin menghapus data kebutuhahan SPPG yang ingin di pilih?",
            "Silakan Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            ) != DialogResult.Yes)
                return;

            try
            {
                Database.Execute("DELETE FROM KitchenNeeds Where NeedId=@id", Database.P("@id", Convert.ToInt32(dgvKebutuhan.CurrentRow.Cells[0].Value)));
                LoadData();
                MessageBox.Show("Data kebutuhahan SPPG berhasil di hapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvKebutuhan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di edit", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using(var f = new FormEditKebutuhan(Convert.ToInt32(dgvKebutuhan.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new FormEditKebutuhan())
                if (f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }
    }
}
