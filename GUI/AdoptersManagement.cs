using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Windows.Forms;
using BussinessObject.DataAccess;
using DataProvider;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class AdoptersManagement : Form
    {
        public AdoptersManagement()
        {
            InitializeComponent();
        }

        private void LoadAdoptersListView(List<tblAccount> listAdopters)
        {
            lvListAdopters.Clear();
            lvListAdopters.Columns.Add("Username");
            lvListAdopters.Columns.Add("Full name");
            lvListAdopters.Columns.Add("Address");
            lvListAdopters.Columns.Add("Phone");

            if (lvListAdopters != null)
            {
                foreach (var adopter in listAdopters)
                {
                    ListViewItem item = new ListViewItem(adopter.username);
                    item.SubItems.Add(adopter.fullname);
                    item.SubItems.Add(adopter.address);
                    item.SubItems.Add(adopter.phone);
                    lvListAdopters.Items.Add(item);

                }
                lvListAdopters.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvListAdopters.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvListAdopters.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvListAdopters.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void btnShowAllAdopters_Click(object sender, System.EventArgs e)
        {
            try
            {
                var listAdopters = TblAccountDAO.Instance.GetAllAdopters();
                LoadAdoptersListView(listAdopters);
            }
            catch (EntityException)
            {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSearchAdopter_Click(object sender, EventArgs e)
        {
            String usernameSearch = txtUsername.Text;
            String nameSearch = txtUsername.Text;
            String phoneSearch = txtUsername.Text;
            bool isInBlacklist = cbIsInBlacklist.Checked;
            bool status = cbAdopterStatus.Checked;

        }

        private void lvListAdopters_DoubleClick(object sender, EventArgs e)
        {
            String username = lvListAdopters.SelectedItems[0].SubItems[0].Text;
            tblAccount adopter = TblAccountDAO.Instance.GetAccountByUsername(username);
            this.Hide();
            AdopterDetail form = new AdopterDetail(false,adopter);
            form.ShowDialog();
            this.Show();
        }

        private void btnCreateAdopter_Click(object sender, EventArgs e)
        {
            AdopterDetail newF = new AdopterDetail(true,null);
            this.Hide();
            newF.ShowDialog();
            this.Show();
        }
    }
}
