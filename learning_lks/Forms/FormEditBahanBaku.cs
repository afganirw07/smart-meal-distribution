using learning_lks.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning_lks.Forms
{
    public partial class FormEditBahanBaku : Form
    {
        private readonly int? _id;
        public FormEditBahanBaku()
        {
            InitializeComponent();
            Text = "Tambah Bahan Baku";
        }
        public FormEditBahanBaku(int id) : this()
        {
            _id = id;
            Text = "Edit Bahan Baku";
            LoadData();
        } 


        private void LoadData()
        {
            try
            {
                var dt = Database.Query("Select * from RawMaterials where MaterialId=@id", Database.P("@id", _id));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan", "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                var r = dt.Rows[0];
                lblNamaMaterial.Text = r["MaterialName"].ToString();
                lblCategory.Text = r["Category"].ToString();
                lblUnit.Text = r["Unit"].ToString();
                lblStock.Text = r["Stock"].ToString();
                lblHarga.Text = r["EstimatedPrice"].ToString();
            }catch (Exception ex)
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
            if (string.IsNullOrEmpty(lblNamaMaterial.Text) || string.IsNullOrEmpty(lblCategory.Text) || string.IsNullOrEmpty(lblStock.Text) || string.IsNullOrEmpty(lblUnit.Text) || string.IsNullOrEmpty(lblHarga.Text)) {
                MessageBox.Show("Field wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!decimal.TryParse(lblStock.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal stock) || stock < 0){
                { MessageBox.Show("Stok harus angka >= 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            if (!decimal.TryParse(lblHarga.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal harga) || harga < 0)
            {
                { MessageBox.Show("Harga harus angka >= 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }

            try
            {
                if (_id.HasValue)
                {
                    Database.Execute("UPDATE RawMaterials SET MaterialName=@m, Category=@c, Unit=@u, Stock=@s, EstimatedPrice=@e Where MaterialId=@id",
                        Database.P("@m", lblNamaMaterial.Text.Trim()),
                        Database.P("@c", lblCategory.Text.Trim()),
                        Database.P("@u", lblUnit.Text.Trim()),
                        Database.P("@s", stock),
                        Database.P("@e", harga),
                        Database.P("@id", _id.HasValue)
                        );
                } else
                {
                    Database.Execute("INSERT INTO RawMaterials(MaterialName,Category, Unit, Stock, EstimatedPrice) values(@m,@c,@u,@s,@e)",
                        Database.P("@m", lblNamaMaterial.Text.Trim()),
                        Database.P("@c", lblCategory.Text.Trim()),
                        Database.P("@u", lblUnit.Text.Trim()),
                        Database.P("@s", stock),
                        Database.P("@e", harga)
                        );
                }

                DialogResult = DialogResult.OK;
                Close();

            } catch(Exception ex)
            {
                { MessageBox.Show("Terjadi Kesalahan:" + ex, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
        }
    }
}
