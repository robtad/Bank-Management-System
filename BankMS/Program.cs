using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMS
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
            //Application.Run(new loginForm());
            //Application.Run(new customerForm());
            //Application.Run(new customerChildForm.paraYatirCekForm());
            //Application.Run(new customerChildForm.paraGonderForm());
            //Application.Run(new tellerChildForm.hesaplarForm());
            //Application.Run(new customerChildForm.bilgiGuncelleForm());
            Application.Run(new managerForm());
            //Application.Run(new customerChildForm.aylikOzetForm());


        }
    }
}
