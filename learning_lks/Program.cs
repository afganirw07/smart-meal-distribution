using learning_lks.Forms;
using learning_lks.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning_lks
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Database.CheckConnection(out string err))
            {
                MessageBox.Show(
                        "Tidak Dapat Terhubung ke Database SQL Server .\n\n" +
                        "Detail Error:\n" + err + ".\n\n",
                        "Database Gagal Terhubung",
                       MessageBoxButtons.OK, 
                       MessageBoxIcon.Error);
                return;
            }

            while (true)
            {

                using (var login = new FormLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK) 
                        break;
                }

                using (var main = new FormMain())
                {
                    Application.Run(main);
                }
            }
        }
    }
}
