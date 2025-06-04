using MadZooWinApp_EF;
using MadZooWinApp_EF.Data;

namespace Name_it_MadZooWinApp_EF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
            }

            LoginForm loginForm = new LoginForm();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK && loginForm.LoggedInUser != null)
            {
                Application.Run(new DashboardForm(loginForm.LoggedInUser));
            }
        }

    }
}