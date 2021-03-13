using System;
using System.Windows.Forms;
using DataProvider;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class AdopterHome : Form
    {
        private tblAccount adopter;
        public AdopterHome(tblAccount adopter)
        {
            InitializeComponent();
            txtWelcome.Text = "Welcome " + adopter.fullname;
            this.adopter = adopter;
        }

        private void picUpdatePetDiary_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                UpdatePetDiary newForm = new UpdatePetDiary(adopter);
                newForm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void picViewListDiary_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ViewNotification newForm = new ViewNotification(adopter);
                newForm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
