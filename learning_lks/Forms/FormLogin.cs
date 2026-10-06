using learning_lks.Helper;
using System;
using System.Windows.Forms;

namespace learning_lks.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var username = textUsername.Text.Trim();
            var password = textPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password Wajib di Isi",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
                return;
            }

            try
            {
                var dt = Database.Query(
                    "SELECT UserId, Username, FullName, Role, Position FROM Users WHERE Username=@u AND Password=@p",
                    Database.P("@u", username),
                    Database.P("@p", password)
                    );

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Username atau Password Salah",
                  "Login Gagal",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                 );
                    return;
                }

                var row = dt.Rows[0];
           
                Session.Set(
                    Convert.ToInt32(row["UserID"]),
                    row["Username"].ToString(),
                    row["FullName"].ToString(),
                    row["Role"].ToString(),
                    row["Position"].ToString()
                    );
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
            "Gagal Login\n\n" +
            "Error: " + ex.Message + "\n\n" +
            "Detail:\n" + ex.ToString(),
            "Gagal Login",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                                );
                return;
            }

        }

        private void ButtonBatal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void Keys_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ButtonLogin_Click(sender, EventArgs.Empty);
            }
        }
    }
}
