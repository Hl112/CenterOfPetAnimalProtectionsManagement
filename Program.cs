using System;
using System.Windows.Forms;
using CenterOfPetAnimalProtectionsManagement.GUI;

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
            //Application.Run(new Login());
            Application.Run(new AdoptersManagement()); 
        }
    }
}
