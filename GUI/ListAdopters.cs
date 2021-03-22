using BussinessObject.DataAccess;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class ListAdopters : Form
    {
        public ListAdopters()
        {
            InitializeComponent();
        }

        public ListAdopters(string currentUser) : this()
        {
            SelectedAdopter = currentUser;
        }

        private DataTable dtAdopters;
        private List<tblAccount> adopters;
        private const string VIEW_ICON = "..\\..\\icon\\icons8-eye-20-maroon.png";
        public string SelectedAdopter { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin1_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            //load search filter
            cboPetSearchCategory.Items.Add("Username");
            cboPetSearchCategory.Items.Add("Phone");
            cboPetSearchCategory.SelectedIndex = 0;

            //load dgv
            adopters = null;
            Image viewImage = Image.FromFile(VIEW_ICON); ;
            try
            {
                adopters = TblAccountDAO.Instance.GetAllAdopters();
                LoadListAdopter(adopters, viewImage);
            }
            catch (EntityException)
            {
                MessageBox.Show("Connection Error!!!");
                this.Close();
            }
        }

        private void LoadListAdopter(List<tblAccount> adopters, Image viewImage)
        {
            dtAdopters = new DataTable();
            dtAdopters.Columns.Add("Username", typeof(string));
            dtAdopters.Columns.Add("FullName", typeof(string));
            dtAdopters.Columns.Add("Phone", typeof(string));
            dtAdopters.Columns.Add("Details", typeof(Bitmap));

            if (adopters != null)
            {
                foreach (tblAccount adopter in adopters)
                {
                    dtAdopters.Rows.Add(adopter.username, adopter.fullname, adopter.phone, viewImage);
                }
            }
            dgvListAdopters.DataSource = dtAdopters;
        }

        //This function will show adopter detail form when click eye icon
        private void dgvListAdopters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //skip column header
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                if (dgvListAdopters.CurrentCell != null && dgvListAdopters.CurrentCell.Value != null)
                {
                    string username = dgvListAdopters.CurrentRow.Cells[0].Value.ToString();
                    this.Hide();
                    AdopterDetail frm = new AdopterDetail(adopters.Find(x => x.username == username));
                    frm.ShowDialog();
                    this.Show();
                }
            }
        }

        //this function will change cursor when hover on the 3rd column
        private void dgvListAdopters_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 3)
                dgvListAdopters.Cursor = Cursors.Hand;
            else
                dgvListAdopters.Cursor = Cursors.Default;
        }

        private void txtSearchValue_TextChange(object sender, EventArgs e)
        {
            SearchAdopters(cboPetSearchCategory.SelectedItem.ToString(), txtSearchValue.Text);
        }

        private void SearchAdopters(string searchBy, string value)
        {
            DataView dv = dtAdopters.DefaultView;
            string filter = "";
            if (searchBy.Equals("Username"))
            {
                filter = "Username like '%" + value + "%'";
            }
            else
            {
                filter = "Phone like '%" + value + "%'";
            }

            dv.RowFilter = filter;
        }

        private void cboPetSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtAdopters != null)
            {
                SearchAdopters(cboPetSearchCategory.SelectedItem.ToString(), txtSearchValue.Text);
            }
        }

        private void dgvListAdopters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SelectedAdopter = dgvListAdopters.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void cboPetSearchCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
