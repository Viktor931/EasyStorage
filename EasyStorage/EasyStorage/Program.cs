using System;
using System.Windows.Forms;

namespace EasyStorage
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
            Application.Run(new LoginFrm());
        }
        public static MainDatabase GetMainDatabase()
        {
            return DatabaseImpl.GetDatabase();
        }
        public static KorisnikDatabase GetKorisnikDatabase()
        {
            return DatabaseImpl.GetDatabase();
        }
    }
}
