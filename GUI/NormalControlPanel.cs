using System;
using System.Drawing;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class frmNormalControlPanel : UserControl
    {
        private Point pos;
        public frmNormalControlPanel()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.ParentForm.Close();
        }

        private void frmNormalControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
        }

        private void frmNormalControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ParentForm.Left += e.X - pos.X;
                this.ParentForm.Top += e.Y - pos.Y;
            }
        }

        private void txtAppName_MouseDown(object sender, MouseEventArgs e)
        {
            frmNormalControlPanel_MouseDown(sender,e);
        }

        private void txtAppName_MouseMove(object sender, MouseEventArgs e)
        {
            frmNormalControlPanel_MouseMove(sender,e);
        }
    }
}
