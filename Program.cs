using System;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement
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
            // Application.Run(new GUI.PetsManagement());
            //Application.Run(new GUI.AdminHome());
            Application.Run(new Login());
        }
    }
}
