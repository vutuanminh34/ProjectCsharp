using System;
using System.Windows.Forms;
using GUI;
using GUI.ExportGUI;
using GUI.MonthlyReportGUI;
using GUI.ProductGUI;
using GUI.TypeGUI;

namespace GUI
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
            Application.Run(new MonthlyReport());
        }
    }
}
