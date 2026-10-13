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
    public partial class UCMonitoringPemasok : UserControl
    {
        public UCMonitoringPemasok()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string search = "")
        {
            try
            {
                string sql = @"select pd.ProcessId as [ID], pd.ProcessDate as [Tanggal], sc.SchoolName as [Sekolah], pd.PortionCount as [Porsi], pd.ProductionStatus as [Status], pd.DistributionStatus as [Status Distribusi], pd.Notes 
From ProductionDistribution as pd
INNER JOIN Schools as sc ON pd.SchoolId = sc.SchoolId WHERE sc.SchoolName LIKE @search";
                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvPemasok.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show("Gagal Mengload data:" + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Silakan pilih data yang ingin di hapus", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                Database.Execute("DELETE FROM ProductionDistribution where ProcessId=@id", Database.P("@id", Convert.ToInt32(dgvPemasok.CurrentRow.Cells[0].Value)));
                LoadData();
                MessageBox.Show("Data berharhasil di hapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus data:" + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvPemasok.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih data yang ingin di ubah", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using(var f = new FormsMonitoringPemasok(Convert.ToInt32(dgvPemasok.CurrentRow.Cells[0].Value)))
                if (f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using(var f = new FormsMonitoringPemasok())
                if(f.ShowDialog() == DialogResult.OK) { LoadData(); }
        }
    }
}
