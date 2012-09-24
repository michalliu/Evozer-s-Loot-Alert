using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LootAlert
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Settings.load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LootAlert());
            Settings.save();
        }
    }
}
