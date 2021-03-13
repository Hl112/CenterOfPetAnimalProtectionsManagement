using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class frmAdopterPanel : UserControl
    {
        public frmAdopterPanel()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            this.ParentForm.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.ParentForm.Close();
        }

        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
