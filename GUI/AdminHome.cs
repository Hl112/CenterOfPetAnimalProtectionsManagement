using System;
using System.Threading;
using System.Windows.Forms;
using DataProvider;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class AdminHome : Form
    {
        tblAccount admin;
        public AdminHome(tblAccount user)
        {
            InitializeComponent();
            txtWelcome.Text = "Welcome " + user.fullname;
            this.admin = user;
        }

        public void ShowPetManagement()
        {
            PetsManagement newForm = new PetsManagement(admin);
            Application.Run(newForm);
        }

        private void btnPetsManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowPetManagement));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            this.Close();
        }
    }
}
