using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


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
