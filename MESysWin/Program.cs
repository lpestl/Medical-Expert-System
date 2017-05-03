using MESysWin.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Print("---------------------------", "----", Log.type.INFO);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Log.Print("Run main form in MAIN", "start", Log.type.INFO);
            Application.Run(new MainForm());
            Log.Print("Close forms and exit in main thread", "close", Log.type.INFO);
        }
    }
}
