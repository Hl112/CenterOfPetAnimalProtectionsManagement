using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuTextbox;
using BussinessObject.DataAccess;
using DataProvider;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class PetDetail : Form
    {
        private bool isCreate = true;
        public PetDetail()
        {
            InitializeComponent();
            try
            {
                MyInit();
                errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error!", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public PetDetail(bool isCreate, tblPet pet)
        {
            InitializeComponent();
            this.isCreate = isCreate;
            try
            {
                MyInit();
                if (pet != null)
                {
                    SetData(pet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error!", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        #region Function
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

            if (cbPetCategory != null && cbPetCategory.SelectedItem != null)
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
            tblPet pet;
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
            string description = txtPetDescription.Text;
            DateTime dateCreate = dtmPetCreateDate.Value;
            DateTime? dateAdopted = dtmPetDateAdopted.Value;
            string image = openFileImage.SafeFileName;
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
                name = name,
                gender = gender,
                age = age,
                furColor = furColor,
                isSterilized = isSterilized,
                adopter = adopter,
                dateAdopted = dateAdopted,
                typeID = typeId,
                createdDate = dateCreate,
                description = description,
                image = image
            };

            return pet;
        }

        public void SetData(tblPet pet)
        {
            cboPetType.SelectedItem = pet.tblPetType;
            cboPetCategory.SelectedItem = pet.tblPetType.tblPetCategory;
            txtPetId.Text = pet.id + "";
            txtPetName.Text = pet.name;
            txtPetGender.Text = pet.gender;
            txtPetAge.Text = pet.age;
            txtPetFurcolor.Text = pet.furColor;
            dtmPetCreateDate.Value = pet.createdDate;
            rdoPetSterilizedYes.Checked = (bool)pet.isSterilized;
            rdoPetAdoptedYes.Checked = pet.adopter == null ? false : true;
            if (rdoPetAdoptedYes.Checked)
            {
                txtPetAdopter.Text = pet.adopter;
                dtmPetDateAdopted.Value = (DateTime)pet.dateAdopted;
            }

            txtPetDescription.Text = pet.description;
            if (pet.image != null)
            {
                string pathImage = FileDAO.Folder + "/" + pet.image;
                if (File.Exists(pathImage))
                    picPetAva.Image = new Bitmap(pathImage);
            }
        }

        #endregion
        #region Event
        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            tblPet pet = GetData();
            bool result = false;
            if (pet == null) return;
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
                FileDAO.CopyImage(openFileImage.FileName, openFileImage.SafeFileName);
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picPetAva_Click(object sender, EventArgs e)
        {
            if (openFileImage.ShowDialog() == DialogResult.OK)
            {
                picPetAva.Image = new Bitmap(openFileImage.FileName);
                picPetAva.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }

        private void ValidEmpty(Control c, string message)
        {
            errorProvider.SetError(c, (c as BunifuTextBox)?.Text == String.Empty ? message : null);
        }
        private void txtPetName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidEmpty(txtPetName,"Name is not empty!");
        }

        private void txtPetGender_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidEmpty(txtPetGender,"Gender is not empty");
        }
        private void txtPetAge_Validating(object sender, CancelEventArgs e)
        {
            ValidEmpty(txtPetAge,"Age is not empty");
        }

        private void txtPetFurcolor_Validating(object sender, CancelEventArgs e)
        {
            ValidEmpty(txtPetFurcolor,"Furcolor is not empty");
        }
        #endregion

       
    }
}
