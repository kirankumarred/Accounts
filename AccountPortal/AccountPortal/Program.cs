using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kiran.Accountportal.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Login login = new Login();
                if (login.ShowDialog() == DialogResult.Cancel)
                    return;
                Application.Run(new MainForm());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Caught exception: " + ex.Message + " \n " + ex.StackTrace, "Real Deal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
