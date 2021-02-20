using System;
using System.Threading;
using System.Windows.Forms;


namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class PetsManagement : Form
    {
        public PetsManagement()
        {
            InitializeComponent();
        }

        public void ShowCreatePet()
        {
            PetDetail newForm = new PetDetail();
            Application.Run(newForm);
        }

        public void ShowPetDetail()
        {
            PetDetail newForm = new PetDetail();
            Application.Run(newForm);
        }

        public void ShowAdminHome()
        {
            AdminHome newForm = new AdminHome();
            Application.Run(newForm);
        }

        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowCreatePet));
            t.Start();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowAdminHome));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Close();

        }
    }
}
