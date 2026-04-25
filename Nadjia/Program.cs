using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadjia
{
    static class nadiaConfig
    {
        public static string trackLibraryFolder;
        public static string LRQuestionsFolder;
        public static string soundboardLibraryFolder;
        public static string masterDatabase;
    }
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
            Application.Run(new frmDashboard());
        }
    }
}
