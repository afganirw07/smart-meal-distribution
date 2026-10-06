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
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
            GetAllData();
        }

        private int ScalarInt(string sql)
        {
            var v = Database.Scalar(sql);
            return v == null || v == DBNull.Value ? 0 : Convert.ToInt32(v);
        }

        private void GetAllData()
        {
            try
            {
                int totPeg = ScalarInt("SELECT COUNT(*) FROM Employees");
                int totBhn = ScalarInt("SELECT COUNT(*) FROM RawMaterials");
                int totSek = ScalarInt("SELECT COUNT(*) FROM Schools");
                int totPsn = ScalarInt("SELECT COUNT(*) FROM SupplierOrders");
                int psnPnd = ScalarInt("SELECT COUNT(*) FROM SupplierOrders WHERE Status='Pending'");
                int psnDpr = ScalarInt("SELECT COUNT(*) FROM SupplierOrders WHERE Status='Diproses'");
                int psnSls = ScalarInt("SELECT COUNT(*) FROM SupplierOrders WHERE Status='Selesai'");
                int totDst = ScalarInt("SELECT COUNT(*) FROM ProductionDistribution");

                lblTotalPegawai.Text = totPeg.ToString();
                lblTotalBahan.Text = totBhn.ToString();
                lblTotalSekolah.Text = totSek.ToString();
                lblTotalPesanan.Text = totPsn.ToString();
                lblTotalPending.Text = psnPnd.ToString();
                lblPesananDiproses.Text = psnDpr.ToString();
                lblPesananSelesai.Text = psnSls.ToString();
                lblDataDistribusi.Text = totDst.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal Memuat Data: " + ex.Message,
                    "Terjadi Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void label14_Click(object sender, EventArgs e) // damn
        {

        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshButton.Enabled = false;
            RefreshButton.Text = "Memuat...";

            try
            {
                await Task.Run(() => GetAllData());
            } finally
            {
                RefreshButton.Text = "Refresh";
                RefreshButton.Enabled = true;
            } 
        }
    }
}
