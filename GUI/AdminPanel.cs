using System;
using System.Drawing;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class frmAdmin : UserControl
    {
        private Point _pos;
        public frmAdmin()
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.ParentForm.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            _pos = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ParentForm.Left += e.X - _pos.X;
                this.ParentForm.Top += e.Y - _pos.Y;
            }
        }

        private void petsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is PetsManagement))
            {
                this.ParentForm.Hide();
                PetsManagement form = new PetsManagement();
                form.ShowDialog();
                this.ParentForm.Close();
            }
        }

        private void adoptersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is AdoptersManagement))
            {
                this.ParentForm.Hide();
                AdoptersManagement form = new AdoptersManagement();
                form.ShowDialog();
                this.ParentForm.Close();
            }
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is ViewNotification))
            {
                this.ParentForm.Hide();
                ViewNotification form = new ViewNotification();
                form.ShowDialog();
                this.ParentForm.Close();
            }
        }

        private void txtAppName_MouseDown(object sender, MouseEventArgs e)
        {
            menuStrip1_MouseDown(sender,e);
        }

        private void txtAppName_MouseMove(object sender, MouseEventArgs e)
        {
            menuStrip1_MouseMove(sender,e);
        }
    }
}
