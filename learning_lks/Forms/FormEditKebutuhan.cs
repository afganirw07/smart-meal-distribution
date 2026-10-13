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
    public partial class FormEditKebutuhan : Form
    {
        private readonly int? _id;
        public FormEditKebutuhan()
        {
            InitializeComponent();
            LoadMaterial();
            Text = "Tambah Kebutuhan SPPG";
        }
        public FormEditKebutuhan(int id) : this()
        {
            _id = id;
            LoadData();
            Text = "Edit Kebutuhan SPPG";
        }

        private void LoadMaterial()
        {
            try
            {
                var dt = Database.Query("SELECT MaterialId, MaterialName, Unit FROM RawMaterials ORDER BY MaterialName");
                inBahan.DataSource = dt;
                inBahan.DisplayMember = "MaterialName";
                inBahan.ValueMember = "MaterialId";
            } catch(Exception ex)
            {
                MessageBox.Show(
                  "Gagal Mengload Data:" + ex,
                  "Terjadi Kesalahan",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                  );
            }
            }

        private void LoadData()
        {
            try
            {
                var dt = Database.Query("Select K.*, r.MaterialName from KitchenNeeds K JOIN RawMaterials r ON K.MaterialId = r.MaterialId where K.NeedId=@i", Database.P("@i", _id));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var r = dt.Rows[0];
                inDate.Value = Convert.ToDateTime(r["NeedDate"]);
                inBahan.SelectedValue = Convert.ToInt32(r["MaterialId"]);
                inJumlah.Text = r["Quantity"].ToString();
                inSatuan.Text = r["Unit"].ToString();
                inCatatan.Text = r["Notes"].ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(
                   "Gagal Mengload Data:" + ex,
                   "Terjadi Kesalahan",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                   );
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inJumlah.Text) ||
         string.IsNullOrEmpty(inSatuan.Text) ||
            string.IsNullOrEmpty(inCatatan.Text))
            {
                MessageBox.Show("Field wajib diisi.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                if (_id.HasValue)
                {
                    Database.Execute("Update KitchenNeeds set NeedDate=@a,MaterialId=@b, Quantity=@c, Unit=@d, Notes=@e where NeedId=@i",
                    Database.P("@a", inDate.Value.Date),
                    Database.P("@b", Convert.ToInt32(inBahan.SelectedValue)),
                    Database.P("@c", Convert.ToDecimal(inJumlah.Text)),
                    Database.P("@d", inSatuan.Text),
                    Database.P("@e", inCatatan.Text),
                    Database.P("@i", _id)
                        );   
                }
                else
                {
                    Database.Execute(
                    "INSERT INTO KitchenNeeds (NeedDate, MaterialId, Quantity, Unit, Notes) VALUES (@a, @b, @c, @d, @e)",
                  Database.P("@a", inDate.Value.Date),
                  Database.P("@b", Convert.ToInt32(inBahan.SelectedValue)),
                  Database.P("@c", Convert.ToDecimal(inJumlah.Text)),
                  Database.P("@d", inSatuan.Text),
                  Database.P("@e", inCatatan.Text));
                }
                DialogResult = DialogResult.OK;
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show(
                   "Terjadi Kesalahan:" + ex,
                   "Terjadi Kesalahan",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                   );
            }
        }

        }
    }
