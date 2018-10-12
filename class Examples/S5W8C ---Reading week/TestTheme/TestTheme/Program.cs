using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using USKINCOMLib;

namespace TestTheme
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
            USkinSDK.USkinInit("", "", "..\\Skins\\DiyGreen.msstyles");
            Application.Run(new Form1());
        }
    }
}
