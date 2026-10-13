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
    public partial class UCLaporan : UserControl
    {
        public UCLaporan()
        {
            InitializeComponent();
            LoadComboBox();
            SelectCombo();
        }

        private void LoadComboBox()
        {
            InKategori.Items.AddRange(new string[] {"Laporan Bahan Baku", "Laporan Kebutuhan Dapur", "Laporan Pesanan Pemasok", "Laporan Data Distribusi"});
            InKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            InKategori.SelectedIndexChanged += new EventHandler(InKategori_SelectedIndexChanged);
            InKategori.SelectedIndex = 0;
        }

        private void InKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCombo();
        }

        private void SelectCombo()
        {
            string pilihan = InKategori.SelectedItem?.ToString();

            string search = btnSearch?.Text ?? "";

            switch (pilihan)
            {
                case "Laporan Bahan Baku":
                    ListBahanBaku(search);
                    break;
                case "Laporan Kebutuhan Dapur":
                    ListKebutuhanDapur(search);
                    break;
                case "Laporan Pesanan Pemasok":
                    ListPemasok(search);
                    break;
                case "Laporan Data Distribusi":
                    ListDistribusi(search);
                    break;

            }
        }


        private void ListBahanBaku(string search = "")
        {
            try
            {
                string sql = @"Select MaterialId as [ID], MaterialName as [Nama], Category as [Kategori], Unit as [Satuan], Stock as [Stok], EstimatedPrice as [Harga] from RawMaterials where MaterialName LIKE @search or Category LIKE @search";

                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvLaporan.DataSource = dt;
                lblSearch.Text = "Cari Nama Bahan / Categori";
            } catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListKebutuhanDapur(string search = "")
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
Where rm.MaterialName LIKE @search";

                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvLaporan.DataSource = dt;
                lblSearch.Text = "Cari Nama Bahan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListPemasok(string search = "")
        {
            try
            {
                string sql = @"select pd.ProcessId as [ID], pd.ProcessDate as [Tanggal], sc.SchoolName as [Sekolah], pd.PortionCount as [Porsi], pd.ProductionStatus as [Status], pd.DistributionStatus as [Status Distribusi], pd.Notes 
From ProductionDistribution as pd
INNER JOIN Schools as sc ON pd.SchoolId = sc.SchoolId WHERE sc.SchoolName LIKE @search";

                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvLaporan.DataSource = dt;
                lblSearch.Text = "Cari Nama Sekolah";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListDistribusi(string search = "")
        {
            try
            {
                string sql = @"SELECT so.OrderId as [ID], so.OrderDate as [Tanggal Pemesanan], so.SupplierName as [Pemasok], m.MaterialName as [Bahan], so.OrderQuantity as [Jumlah], 
                so.Unit as [Satuan], so.Status, so.Notes from SupplierOrders as so inner join RawMaterials m on so.MaterialId = m.MaterialId Where so.SupplierName LIKE @search OR  m.MaterialName LIKE @search OR so.status LIKE @search";

                var dt = Database.Query(sql, Database.P("@search", "%" + search + "%"));
                dgvLaporan.DataSource = dt;
                lblSearch.Text = "Cari Nama Bahan / Supplier / Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            SelectCombo();
        }
    }
}
