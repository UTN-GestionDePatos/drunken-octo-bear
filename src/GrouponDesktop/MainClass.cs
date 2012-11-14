using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrouponDesktop.Core;
using GrouponDesktop.GUI;

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
            new Login().ShowDialog();
            Session s = (Session) AppContext.getObject(typeof(Session));
            if (s != null)
            {
                Application.Run(new Main());
            }
        }
    }
}
