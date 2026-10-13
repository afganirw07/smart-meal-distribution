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
    public partial class ForrmPemasok : Form
    {
        private readonly int? _id;
        public ForrmPemasok()
        {
            InitializeComponent();
            Text = "Tambah Pesanan Ke Pemasok";
            LoadBahan();
        }
        public ForrmPemasok(int id) : this()
        {
            _id = id;
            LoadData();
            Text = "Edit Pesanan Ke Pemasok";
        }

        private void LoadBahan()
        {
            try
            {
                var dt = Database.Query("SELECT MaterialId, MaterialName FROM RawMaterials ORDER BY MaterialName");
                inBahanBaku.DataSource = dt;
                inBahanBaku.DisplayMember = "MaterialName";
                inBahanBaku.ValueMember = "MaterialId";

                inStatus.Items.AddRange(new string[] { "Pending", "Proses", "Selesai" });
                inStatus.DropDownStyle = ComboBoxStyle.DropDown;
                inStatus.SelectedIndex = 0;
            } catch (Exception ex)
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
                var dt = Database.Query("Select * from SupplierOrders where OrderId=@id", Database.P("@id", _id));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var r = dt.Rows[0];
                inDate.Value = Convert.ToDateTime(r["OrderDate"]);
                inPemasok.Text = r["SupplierName"].ToString();
                inBahanBaku.SelectedValue = Convert.ToInt32(r["MaterialId"]);
                inPesan.Text = r["OrderQuantity"].ToString();
                inSatuan.Text = r["Unit"].ToString();
                inStatus.Text = r["Status"].ToString();
                inCatatan.Text = r["Notes"].ToString();
            } catch (Exception ex)
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
            if (string.IsNullOrEmpty(inPemasok.Text) ||
             inBahanBaku.SelectedValue == null ||
             string.IsNullOrEmpty(inPesan.Text) ||
             string.IsNullOrEmpty(inSatuan.Text) ||
             string.IsNullOrEmpty(inStatus.Text) ||
             string.IsNullOrEmpty(inCatatan.Text))
            {
                MessageBox.Show(
                    "Field wajib diisi.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute(
                        "UPDATE SupplierOrders SET OrderDate=@a, SupplierName=@b, MaterialId=@c, OrderQuantity=@d, Unit=@e, Status=@f, Notes=@g WHERE OrderId=@id",
                        Database.P("@a", inDate.Value.Date),
                        Database.P("@b", inPemasok.Text),
                        Database.P("@c", Convert.ToInt32(inBahanBaku.SelectedValue)),
                        Database.P("@d", Convert.ToDecimal(inPesan.Text)),
                        Database.P("@e", inSatuan.Text),
                        Database.P("@f", inStatus.Text),
                        Database.P("@g", inCatatan.Text),
                        Database.P("@id", _id.Value)
                    );
                }
                else
                {
                    Database.Execute(
                        "INSERT INTO SupplierOrders (OrderDate, SupplierName, MaterialId, OrderQuantity, Unit, Status, Notes) VALUES (@a, @b, @c, @d, @e, @f, @g)",
                        Database.P("@a", inDate.Value.Date),
                        Database.P("@b", inPemasok.Text),
                        Database.P("@c", Convert.ToInt32(inBahanBaku.SelectedValue)),
                        Database.P("@d", Convert.ToDecimal(inPesan.Text)),
                        Database.P("@e", inSatuan.Text),
                        Database.P("@f", inStatus.Text),
                        Database.P("@g", inCatatan.Text)
                    );
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
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
