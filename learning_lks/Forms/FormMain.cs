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
            WindowState = FormWindowState.Maximized;
            GetUsernameAndRole();
            ShowUserControl(new UCDashboard(), "Dashboard");
            SetActiveButton(btnDashboard);
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
    }
}
