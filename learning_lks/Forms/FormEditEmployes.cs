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
    public partial class FormEditEmployes : Form
    {
        private readonly int? _id;
        public FormEditEmployes()
        {
            InitializeComponent();
            Text = "Tambah Pegawai";
        }
        public FormEditEmployes(int id) : this()
        {
            _id = id;
            Text = "Ubah Pegawai";
            LoadData();


        }

        private void LoadData()
        {
            try
            {
                var dt = Database.Query("Select * From Employees WHERE EmployeeId= @i", Database.P("@i", _id));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Data tidak ditemukan",
                        "Terjadi Kesalahan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                var r = dt.Rows[0];
                lblNamaPegawai.Text = r["EmployeeName"].ToString();
                lblJabatan.Text = r["Position"].ToString();
                lblNomer.Text = r["Phone"].ToString();
                lblAlamat.Text = r["Address"].ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Gagal Memuat data :" + ex,
                    "Terjadi Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private void FormEditEmployes_Load(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblNamaPegawai.Text) || string.IsNullOrEmpty(lblJabatan.Text) || string.IsNullOrEmpty(lblNomer.Text) || string.IsNullOrEmpty(lblAlamat.Text))
            {
                MessageBox.Show("Nama pegawai wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute("Update Employees SET EmployeeName=@n, Position=@p, Phone=@h, Address=@a WHERE EmployeeId=@i",
                        Database.P("@n", lblNamaPegawai.Text.Trim()),
                        Database.P("@p", lblJabatan.Text.Trim()),
                        Database.P("@h", lblNomer.Text.Trim()),
                        Database.P("@a", lblAlamat.Text.Trim()),
                        Database.P("@i", _id.Value)
                        );
                }
                else
                {
                    Database.Query("INSERT INTO Employees (EmployeeName,Position,Phone,Address) VALUES(@n,@p,@h,@a)",
                        Database.P("@n", lblNamaPegawai.Text.Trim()),
                        Database.P("@p", lblJabatan.Text.Trim()),
                        Database.P("@h", lblNomer.Text.Trim()),
                        Database.P("@a", lblAlamat.Text.Trim())
                        );
                }
                DialogResult = DialogResult.OK;
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Gagal saat melakukan proses :" + ex,
                    "Terjadi Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
