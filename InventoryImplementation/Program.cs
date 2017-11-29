using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryImplementation
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
            //Application.Run(new f_InventoryLogin());
            Application.Run(new f_InventorySysFE());
            //Application.Run(new f_MOTags());
            //Application.Run(new f_InvEventAdmin());
            //Application.Run(new f_CaptureTag());
        }
    }
}
