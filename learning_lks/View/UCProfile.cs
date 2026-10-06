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
    public partial class UCProfile : UserControl
    {
        public UCProfile()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            lblUsername.Text = Session.Username ?? "-";
            lblName.Text = Session.FullName ?? "-";
            lblRole.Text = Session.Role == "PetugasSPPG" ? "Petugas SPPG" : Session.Role == "SupervisorSPPG" ? "Supervisor SPPG" : Session.Role ?? "-";
            lblJabatan.Text = Session.Position ?? "-";
        }
    }
}
