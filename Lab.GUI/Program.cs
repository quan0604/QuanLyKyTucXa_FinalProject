using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                FormDangNhap loginForm = new FormDangNhap();
                DialogResult loginResult = loginForm.ShowDialog();

                if (loginResult == DialogResult.OK)
                {
                    // Login succeeded
                    FormMain mainForm = new FormMain(loginForm.LoggedInEmployee);
                    DialogResult mainResult = mainForm.ShowDialog();

                    if (mainResult == DialogResult.OK)
                    {
                        // Logout requested (loop continues)
                        continue;
                    }
                    else
                    {
                        // Exit requested from Main Form
                        break;
                    }
                }
                else
                {
                    // Login cancelled/failed
                    break;
                }
            }
        }
    }
}
