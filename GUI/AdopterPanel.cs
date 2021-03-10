using System.Drawing;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class frmAdopterPanel : UserControl
    {
        private Point pos;
        public frmAdopterPanel()
        {
            InitializeComponent();
        }

        private void frmAdopterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
        }

        private void frmAdopterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            this.ParentForm.Left = e.X - pos.X;
            this.ParentForm.Top = e.Y - pos.Y;
        }
    }
}
