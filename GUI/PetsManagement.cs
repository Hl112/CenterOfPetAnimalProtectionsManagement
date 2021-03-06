using System;
using System.Threading;
using System.Windows.Forms;
using DataProvider;


namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class PetsManagement : Form
    {
        tblAccount admin;
        public PetsManagement(tblAccount user)
        {
            InitializeComponent();
            this.admin = user;
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
            AdminHome newForm = new AdminHome(admin);
            Application.Run(newForm);
        }

        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PetDetail newForm = new PetDetail();
                newForm.ShowDialog();
                this.Show();
            }
            catch (Exception exception)
            {
            }
            // Thread t = new Thread(new ThreadStart(ShowCreatePet));
            // t.Start();
            // this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Thread t = new Thread(new ThreadStart(ShowAdminHome));
            // t.SetApartmentState(ApartmentState.STA);
            // t.Start();
            this.Close();

        }
    }
}
