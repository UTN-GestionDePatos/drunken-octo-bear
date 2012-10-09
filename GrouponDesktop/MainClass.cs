using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop
{
    static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new AppContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
