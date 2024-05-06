using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_Management_System
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

            Application.Run(new RegisterForm());
            Application.Run(new Login());
            Application.Run(new AdminForm(1));
            Application.Run(new AuthorForm(2));
            Application.Run(new SubscriptionForm(3));

        }
    }
}
