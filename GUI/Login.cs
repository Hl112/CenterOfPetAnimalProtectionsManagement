using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenterOfPetAnimalProtectionsManagement.DAO;

namespace CenterOfPetAnimalProtectionsManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassoword.Text;
            bool result = TblAccountDao.Instance.CheckLogin(username, password);
            if (result)
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

        }
    }
}
