using CenterOfPetAnimalProtectionsManagement.GUI;
using System;
using System.Windows.Forms;
using BussinessObject.DataAccess;
using DataProvider;

namespace CenterOfPetAnimalProtectionsManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Login";

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

        readonly TblAccountDAO DAO = new TblAccountDAO();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassoword.Text;

            try
            {
                tblAccount user = DAO.CheckLogin(username, password);
                if (user != null)
                {
                    if (user.roleID == 1)
                    {
                        this.Hide();
                        AdminHome newForm = new AdminHome(user);
                        newForm.ShowDialog();
                        this.Close();
                    }
                    else if (user.roleID == 2)
                    {
                        this.Hide();
                        AdopterHome newForm = new AdopterHome(user);
                        newForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
    }
}
