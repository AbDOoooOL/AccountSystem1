using AccountSystem.BL;
using AccountSystem.DAL;
using AccountSystem.PL;
namespace AccountSystem
{
    internal static class Program
    {
        public static string? uname;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PL.frm_logins());
        }
    }
}