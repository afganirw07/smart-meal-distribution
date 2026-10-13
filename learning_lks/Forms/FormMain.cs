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
using learning_lks.View;

namespace learning_lks.Forms
{
    public partial class FormMain : Form
    {
        private Button activeButton;
        public FormMain()
        {
            InitializeComponent();
            GetUsernameAndRole();
            ShowUserControl(new UCDashboard(), "Dashboard");
            SetActiveButton(btnDashboard);
            validateRole();
        }


        private void validateRole()
        {
            string role = Session.Role;

            bool isSupervisor = role == "SupervisorSPPG";
            bool isPetugas = role == "PetugasSPPG";

            btnMonitongPemasok.Visible = isSupervisor;
            btnLaporan.Visible = isSupervisor;

            btnDataPegawai.Visible = isPetugas;
            btnBahanBaku.Visible =  isPetugas;
            btnSekolah.Visible =  isPetugas;
            btnKebutuhan.Visible =  isPetugas;
            btnPemasok.Visible = isSupervisor || isPetugas;

            btnDashboard.Visible = isSupervisor || isPetugas;
            btnProfile.Visible = isSupervisor || isPetugas;
        }


        private void SetActiveButton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(105, 105, 105);
                activeButton.ForeColor = Color.White;
                activeButton.Font = new Font(activeButton.Font, FontStyle.Regular);
            }

            activeButton = button;

            activeButton.BackColor = Color.FromArgb(0, 112, 192);
            activeButton.ForeColor = Color.White;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
        }

       private void ShowUserControl(UserControl userControl, string pageTitle)
        {
            PanelContent.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            PanelContent.Controls.Add(userControl);
            lblPageTittle.Text = pageTitle;
        }

        private void GetUsernameAndRole()
        {
            lblNameUser.Text = Session.FullName;
            lblRoleUser.Text = Session.Position;
        }


        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show(
                "Anda akan keluar dari sistem. Lanjutkan",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (ok != DialogResult.Yes) return;


            Session.Clear();
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCDashboard(), "Dashboard");
            SetActiveButton(btnDashboard);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCProfile(), "Profil");
            SetActiveButton(btnProfile);
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCDataPegawai(), "Data Karyawan");
            SetActiveButton(btnDataPegawai);
        }

        private void btnBahanBaku_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCBahanBaku(), "Data Bahan Baku");
            SetActiveButton(btnBahanBaku);
        }

        private void btnSekolah_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCSekolah(), "Data Sekolah Penerima");
            SetActiveButton(btnSekolah);
        }

        private void btnKebutuhan_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCKebutuhanDapur(), "Kebutuhan Dapur");
            SetActiveButton(btnKebutuhan);
        }

        private void btnPemasok_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCPesanan(), "Pesanan ke Pemasok");
            SetActiveButton(btnPemasok);
        }

        private void btnMonitongPemasok_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCMonitoringPemasok(), "Monitoring Pemasok Distribusi");
            SetActiveButton(btnMonitongPemasok);
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UCLaporan(), "Laporan SPPG");
            SetActiveButton(btnLaporan);
        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
