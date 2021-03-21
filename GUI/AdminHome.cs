using DataProvider;
using System;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class AdminHome : Form
    {
        tblAccount admin;
        public AdminHome(tblAccount user)
        {
            InitializeComponent();
            lbWelcome.Text = "Welcome " + user.fullname;
            this.admin = user;
        }

        public void ShowPetManagement()
        {
            PetsManagement newForm = new PetsManagement(admin);
            Application.Run(newForm);
        }

        private void btnPetsManagement_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PetsManagement newForm = new PetsManagement(admin);
                newForm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ViewNotification newForm = new ViewNotification();
                newForm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void picAdoptersManagement_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                AdoptersManagement newForm = new AdoptersManagement();
                newForm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
            }
        }
    }
}
