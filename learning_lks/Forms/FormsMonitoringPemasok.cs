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

namespace learning_lks.Forms
{
    public partial class FormsMonitoringPemasok : Form
    {
        private readonly int? _id;
        public FormsMonitoringPemasok()
        {
            InitializeComponent();
            Text = "Tambah Monitoring Pemasok";
            LoadSchools();
        }
        public FormsMonitoringPemasok(int id) : this()
        {
            _id = id;
            LoadData();
            Text = "Ubah Monitoring Pemasok";
        }

        private void LoadSchools()
        {
            var dt = Database.Query("Select SchoolId, SchoolName from Schools");
            inSchool.DataSource = dt;
            inSchool.DisplayMember = "SchoolName";
            inSchool.ValueMember = "SchoolId";

            inStatus.Items.AddRange(new string[] { "Belum Diproses", "Diproses", "Selesai" });
            inStatus.DropDownStyle = ComboBoxStyle.DropDown;
            inStatus.SelectedIndex = 0;

            inStatusDst.Items.AddRange(new string[] { "Belum Dikirim", "Dikirim", "Selesai Dikirim" });
            inStatusDst.DropDownStyle = ComboBoxStyle.DropDown;
            inStatusDst.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                var dt = Database.Query("Select * from ProductionDistribution where ProcessId=@id", Database.P("@id", _id));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var r = dt.Rows[0];
                inDate.Value = Convert.ToDateTime(r["ProcessDate"]);
                inSchool.SelectedValue = Convert.ToInt32(r["SchoolId"]);
                inPorsi.Text = r["PortionCount"].ToString();
                inStatus.SelectedValue = r["ProductionStatus"].ToString();
                inStatusDst.Text = r["DistributionStatus"].ToString();
                inCatatan.Text = r["Notes"].ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Gagal Mengload data:" + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
        
            try
            {
                if (_id.HasValue)
                {
                    Database.Execute("Update ProductionDistribution set ProcessDate=@a,SchoolId=@b, PortionCount=@c,ProductionStatus=@d,DistributionStatus=@e, Notes=@f Where ProcessId=@id",
                        Database.P("@a", inDate.Value.Date),
                        Database.P("@b", Convert.ToInt32(inSchool.SelectedValue)),
                        Database.P("@c", Convert.ToInt32(inPorsi.Text)),
                        Database.P("@d", inStatus.Text.Trim()),
                        Database.P("@e", inStatusDst.Text.Trim()),
                        Database.P("@f", inCatatan.Text.Trim()),
                        Database.P("@id", _id)
                        );
                }
                else
                {
                    Database.Execute("Insert into ProductionDistribution(ProcessDate, SchoolId, PortionCount, ProductionStatus,DistributionStatus, Notes) values(@a,@b,@c,@d,@e,@f)",
                         Database.P("@a", inDate.Value.Date),
                        Database.P("@b", Convert.ToInt32(inSchool.SelectedValue)),
                        Database.P("@c", Convert.ToInt32(inPorsi.Text)),
                        Database.P("@d", inStatus.Text.Trim()),
                        Database.P("@e", inStatusDst.Text.Trim()),
                        Database.P("@f", inCatatan.Text.Trim())
                        );
                }
                DialogResult = DialogResult.OK;
                Close();
            } catch(Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data: " + ex.Message,
                    "Terjadi Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
