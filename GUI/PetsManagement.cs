using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Threading;
using System.Windows.Forms;
using BussinessObject.DataAccess;
using DataProvider;


namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class PetsManagement : Form
    {
        tblAccount admin;
        public PetsManagement(tblAccount user)
        {
            InitializeComponent();
            this.admin = user;
            InitializeData();
            
        }

        public PetsManagement() {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData() {
            cbPetStatus.Checked = true;
            //set enable = false
            cboPetSearchType.Enabled = false;
            dtmPetSearchDateAdoptedFrom.Enabled = false;
            dtmPetSearchDateAdoptedTo.Enabled = false;
            dtmPetSearchDateAdoptedTo.Value = DateTime.Today;
            dtmPetSearchDateAdoptedFrom.Value = new DateTime(2020, 1, 1);

            //load Pet Category
            try {
                List<tblPetCategory> petCate = TblPetCategoryDAO.Instance.GetAllCategories();
                cboPetSearchCategory.DataSource = petCate;
                cboPetSearchCategory.DisplayMember = "name";
                cboPetSearchCategory.ValueMember = "id";
                cboPetSearchCategory.SelectedIndex = -1;
            } catch (EntityException) {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
        }

        public void ShowCreatePet()
        {
            PetDetail newForm = new PetDetail();
            Application.Run(newForm);
        }

        public void ShowPetDetail()
        {
            PetDetail newForm = new PetDetail();
            Application.Run(newForm);
        }

        public void ShowAdminHome()
        {
            AdminHome newForm = new AdminHome(admin);
            Application.Run(newForm);
        }

        private void btnCreatePet_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PetDetail newForm = new PetDetail();
                newForm.ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
            }
            // Thread t = new Thread(new ThreadStart(ShowCreatePet));
            // t.Start();
            // this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Thread t = new Thread(new ThreadStart(ShowAdminHome));
            // t.SetApartmentState(ApartmentState.STA);
            // t.Start();
            this.Close();

        }

        private void cboPetSearchCategory_SelectedIndexChanged(object sender, EventArgs e) {
            if (cboPetSearchCategory.SelectedIndex != -1) {
                int cateID = 0;
                try {
                    cateID = int.Parse(cboPetSearchCategory.SelectedValue.ToString());
                } catch (FormatException) {

                }
                if(cateID != 0) {
                    var petTypes = TblPetTypeDAO.Instance.GetTypesById(cateID);
                    cboPetSearchType.DataSource = petTypes;
                    cboPetSearchType.DisplayMember = "name";
                    cboPetSearchType.ValueMember = "id";
                    cboPetSearchType.Enabled = true;
                    cboPetSearchType.SelectedIndex = -1;
                }
            } else {
                cboPetSearchType.SelectedIndex = -1;
                cboPetSearchType.Enabled = false;
            }
        }

        private void cbAdopted_CheckedChanged(object sender, EventArgs e) {
            if (cbAdopted.Checked) {
                dtmPetSearchDateAdoptedFrom.Enabled = true;
                dtmPetSearchDateAdoptedTo.Enabled = true;
            } else {
                dtmPetSearchDateAdoptedFrom.Enabled = false;
                dtmPetSearchDateAdoptedFrom.Value = new DateTime(2020, 1, 1);
                dtmPetSearchDateAdoptedTo.Enabled = false;
                dtmPetSearchDateAdoptedTo.Value = DateTime.Today;
            }
        }

        private void btnShowAllPets_Click(object sender, EventArgs e) {
            try {
                var l = TblPetDAO.Instance.GetAllPets();
                LoadListView(l);
            } catch (EntityException) {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvPets_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int pID = (int)dgvPets.CurrentRow.Cells[0].Value;
            tblPet pet = TblPetDAO.Instance.GetPetByID(pID);
            this.Hide();
            PetDetail frm = new PetDetail(false, pet);
            frm.ShowDialog();
            this.Show();
        }

        //This function will load data from list to ListView
        private void LoadListView(List<tblPet> l) {
            DataTable dt = new DataTable();
            dt.Columns.Add("Pet ID", typeof(int));
            dt.Columns.Add("Pet Name", typeof(string));
            dt.Columns.Add("Adopted", typeof(bool));
            if (l.Count != 0) {
                foreach (var pet in l) {
                    dt.Rows.Add(pet.id, pet.name, pet.status);
                }
            }
            dgvPets.DataSource = dt;
        }


        private void btnClearFilter_Click(object sender, EventArgs e) {
            cboPetSearchCategory.SelectedIndex = -1;
            txtPetIdSearch.Clear();
            txtPetSearchFurcolor.Clear();
            cbPetStatus.Checked = false;
            cbAdopted.Checked = false;
        }

        private void btnSearchPet_Click(object sender, EventArgs e) {
            //get search information
            string searchCate = cboPetSearchCategory.SelectedIndex == -1 ? "" : cboPetSearchCategory.SelectedValue.ToString();
            string searchType = cboPetSearchType.SelectedIndex != -1 ? cboPetSearchType.SelectedValue.ToString() : "";
            string searchID = txtPetIdSearch.Text.Trim();
            string searchFurColor = txtPetSearchFurcolor.Text.Trim();
            string searchStatus = cbPetStatus.Checked.ToString();
            bool isAdopted = cbAdopted.Checked;
            DateTime searchAdoptedDateFrom = dtmPetSearchDateAdoptedFrom.Value;
            DateTime searchAdoptedDateTo = dtmPetSearchDateAdoptedTo.Value;
            try {
                var list = TblPetDAO.Instance.SearchPets(searchCate, searchType, searchID,
                searchFurColor, searchStatus, isAdopted, searchAdoptedDateFrom, searchAdoptedDateTo);
                LoadListView(list);
            } catch (EntityException) {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
    
        }
    }
}
