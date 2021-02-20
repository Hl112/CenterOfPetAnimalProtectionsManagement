using System;
using System.Threading;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        public void ShowPetManagement()
        {
            PetsManagement newForm = new PetsManagement();
            Application.Run(newForm);
        }

        private void btnPetsManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowPetManagement));
            t.Start();
            this.Close();
        }
    }
}
