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
    public partial class UCDataPegawai : UserControl
    {
        public UCDataPegawai()
        {
            InitializeComponent();
            LoadDataEmployes();
        }

        private void LoadDataEmployes()
        {
            var dt = Database.Query("Select EmployeeId AS [Id Pegawai], EmployeeName AS [Nama Pegawai], Position As Jabatan, Phone As [Nomer Telepon], Address AS Alamat from Employees;");
            dgvEmployes.DataSource = dt;
        }
    }
}
