using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class frmAdopterPanel : UserControl
    {
        public frmAdopterPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            this.ParentForm.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.ParentForm.Close();
        }
    }
}
