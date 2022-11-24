using AssetTracker;

namespace AssetTracker2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DialogResult result;

            using (var loginForm = new LoginForm())
                result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
                Application.Run(new HomeForm());
        }
    }
}