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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        public void ShowPetManagement()
        {
            PetsManagement newForm = new PetsManagement();
            Application.Run(newForm);
        }

        private void btnPetsManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowPetManagement));
            t.Start();
            this.Close();
        }
    }
}
