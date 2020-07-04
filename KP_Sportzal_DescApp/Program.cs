using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_Sportzal_DescApp
{

    class SessionData
    {
        public static bool Avtorization = false;
        public static string user = "";
        public static string role = "";
        public static long select_id = 0;
    }

    static class Program
    {
  
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
