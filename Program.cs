namespace Millonario
{
    internal static class Program
    {
        public static List<User> userList = new List<User>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            userList.Add(new User("admin", "admin123", "admin@email.com"));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}