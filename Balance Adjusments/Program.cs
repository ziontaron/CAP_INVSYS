using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CAP_Inventory_System;

namespace Balance_Adjusments
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(ref Inventory_System_API IE)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f_BalanceAdj(ref IE));
        }
    }
}
