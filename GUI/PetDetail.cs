using System;
using System.Drawing;
using System.Windows.Forms;
using CenterOfPetAnimalProtectionsManagement.DAO;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class PetDetail : Form
    {
        private bool isCreate = true;
        public PetDetail()
        {
            InitializeComponent();
            MyInit();
        }

        public PetDetail(bool isCreate)
        {
            InitializeComponent();
            this.isCreate = isCreate;
            MyInit();

        }

        private void MyInit()
        {
            //Init Category
            var x = TblPetCategoryDAO.Instance.GetAllCategories();
            cboPetCategory.DataSource = x;
            cboPetCategory.DisplayMember = "name";
            //Init Adopted 
            bool adopted = rdoPetAdoptedYes.Checked;
            txtPetAdopter.Enabled = adopted;
            dtmPetDateAdopted.Enabled = adopted;
        }

        private void cboPetCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbPetCategory = sender as ComboBox;

            if (cbPetCategory.SelectedItem != null)
            {
                tblPetCategory selectedCategory = cbPetCategory.SelectedItem as tblPetCategory;
                var listType = TblPetTypeDAO.Instance.GetTypesById(selectedCategory.id);
                if (listType != null)
                {
                    cboPetType.DataSource = listType;
                    cboPetType.DisplayMember = "name";
                }
            }
            
        }

        private tblPet GetData()
        {
            tblPet pet = null;
            string error = "";
            int categoryId = (cboPetCategory.SelectedItem as tblPetCategory).id;
            int typeId = (cboPetType.SelectedItem as tblPetType).id;
            string name = txtPetName.Text;
            string gender = txtPetGender.Text;
            string age = txtPetAge.Text;
            string furColor = txtPetFurcolor.Text;
            bool isSterilized = rdoPetSterilizedYes.Checked;
            bool isAdopter = rdoPetAdoptedYes.Checked;
            string adopter = txtPetAdopter.Text;
            DateTime dateCreate = dtmPetCreateDate.Value;
            DateTime? dateAdopted = dtmPetDateAdopted.Value;
            if (name.Trim().Length == 0)
            {
                error += "Name is not empty!\n";
            }

            if (gender.Trim().Length == 0)
            {
                error += "Gender is not empty!\n";
            }
            if (age.Trim().Length == 0)
            {
                error += "Age is not empty!\n";
            }
            if (furColor.Trim().Length == 0)
            {
                error += "FurColor is not empty!\n";
            }
            if (isAdopter)
            {
                if (adopter.Trim().Length == 0)
                {
                    error += "Adopter is not empty!\n";
                }
            }
            else
            {
                dateAdopted = null;
            }

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (adopter.Length == 0)
            {
                adopter = null;
            }
            pet = new tblPet()
            {
                name = name, gender = gender, age = age, furColor = furColor, isSterilized = isSterilized,
                adopter = adopter, dateAdopted = dateAdopted, typeID = typeId, createdDate = dateCreate
            };

            return pet;
        }

        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            tblPet pet = GetData();
            bool result = false;
            if(pet == null) return;
            
            if (isCreate)
            {
                result = TblPetDAO.Instance.CreatePet(pet);
            }
            else
            {
                result = TblPetDAO.Instance.UpdatePet(pet);
            }

            if (result)
            {
                MessageBox.Show("Successfuly", "Action", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Fail", "Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rdoPetAdoptedYes_CheckedChanged(object sender, EventArgs e)
        {
            bool adopted = (rdoPetAdoptedYes).Checked;
            txtPetAdopter.Enabled = adopted;
            dtmPetDateAdopted.Enabled = adopted;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileImage.ShowDialog() == DialogResult.OK)
            {
                picPetAva.Image = new Bitmap(openFileImage.FileName);
                picPetAva.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
