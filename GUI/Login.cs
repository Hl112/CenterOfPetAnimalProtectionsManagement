using CenterOfPetAnimalProtectionsManagement.GUI;
using System;
using System.Threading;
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

        public void ShowAdminHome(tblAccount user)
        {
            AdminHome NewForm = new AdminHome(user);
            Application.Run(NewForm);
        }

        public void ShowAdopterHome(tblAccount user)
        {
            UpdatePetDiary NewForm = new UpdatePetDiary(user);
            Application.Run(NewForm);
        }

        readonly TblAccountDao DAO = new TblAccountDao();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassoword.Text;

            try
            {
                tblAccount user = DAO.CheckLogin(username, password);
                if (user != null)
                {
                    this.Hide();
                    if (user.roleID == 1)
                    {
                        Thread t = new Thread(() => ShowAdminHome(user));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                    }
                    else if (user.roleID == 0)
                    {
                        Thread t = new Thread(() => ShowAdopterHome(user));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                    }

                    this.Close();
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
