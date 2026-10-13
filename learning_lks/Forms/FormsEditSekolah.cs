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
    public partial class FormsEditSekolah : Form
    {
        private readonly int? _id;
        public FormsEditSekolah()
        {
            InitializeComponent();
            Text = "Tambah Sekolah Penerima";
        }
        public FormsEditSekolah(int id) : this()
        {
            _id = id;
            Text = "Edit Nama Sekolah Penerima";
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                var dt = Database.Query("SELECT * FROM Schools where SchoolId=@id", Database.P("@id", _id));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var r = dt.Rows[0];
                lblNama.Text = r["SchoolName"].ToString();
                lblAddres.Text = r["Address"].ToString();
                lblKepala.Text = r["PICName"].ToString();
                lblNo.Text = r["PICPhone"].ToString();
                lblJumlah.Text = r["StudentCount"].ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan:" + ex, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNamaSekolah.Text) ||string.IsNullOrEmpty(lblAlamat.Text) || string.IsNullOrEmpty(lblPicName.Text) || string.IsNullOrEmpty(lblPICPhone.Text) || string.IsNullOrEmpty(lblJumlahSiswa.Text))
            {
                MessageBox.Show("Field wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }


            try
            {

                if (_id.HasValue)
                {
                    Database.Execute("UPDATE Schools SET SchoolName=@n, Address=@a, PICName=@na, PICPhone=@p, StudentCount=@c where SchoolId=@id",
                       Database.P("@n", lblNama.Text.Trim()),
                       Database.P("@a", lblAddres.Text.Trim()),
                       Database.P("@na", lblKepala.Text.Trim()),
                       Database.P("@p", lblNo.Text.Trim()),
                       Database.P("@c", lblJumlah.Text.Trim()),
                       Database.P("@id", _id)
                        );
                } else
                {
                    Database.Execute("INSERT INTO Schools (SchoolName, Address, PICName, PICPhone, StudentCount) values(@a,@b,@c,@d,@e)",
                       Database.P("@a", lblNama.Text.Trim()),
                       Database.P("@b", lblAddres.Text.Trim()),
                       Database.P("@c", lblKepala.Text.Trim()),
                       Database.P("@d", lblNo.Text.Trim()),
                       Database.P("@e", lblJumlah.Text.Trim())
                        );
                }
                DialogResult = DialogResult.OK;
                Close();
            } catch (Exception ex)
            {
                { MessageBox.Show("Terjadi Kesalahan:" + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
        }
    }
}
