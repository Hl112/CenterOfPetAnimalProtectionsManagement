using System;
using System.ComponentModel;
using System.Data.Entity.Core;
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
        private bool _isAction = false;
        public bool IsAction { get => _isAction; set => IsAction = _isAction; }
        public PetDetail()
        {
            InitializeComponent();
            try
            {
                MyInit();
                this.Text = "Pet Details";
                errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                btnViewPetDiary.Visible = false;
                btnDeletePet.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error!", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private tblPet p;
        public PetDetail(bool isCreate, tblPet pet)
        {
            InitializeComponent();
            this.isCreate = isCreate;
            p = pet;
            try
            {
                MyInit();

                if (pet != null)
                {
                    SetData(pet);
                    p = pet;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error!", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
            if (isCreate) btnDeletePet.Enabled = false;
        }

        private void cboPetCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbPetCategory = sender as ComboBox;

            if (cbPetCategory != null && cbPetCategory.SelectedItem != null)
            {
                tblPetCategory selectedCategory = cbPetCategory.SelectedItem as tblPetCategory;
                if (selectedCategory != null)
                {
                    var listType = TblPetTypeDAO.Instance.GetTypesById(selectedCategory.id);
                    if (listType != null)
                    {
                        cboPetType.DataSource = listType;
                        cboPetType.DisplayMember = "name";
                    }
                }
            }

        }

        private void Clear()
        {
            txtPetName.Clear();
            txtPetId.Clear();
            txtPetAdopter.Clear();
            txtPetAge.Clear();
            txtPetDescription.Clear();
            txtPetFurcolor.Clear();
            txtPetGender.Clear();
            rdoPetAdoptedNo.Checked = true;
            rdoPetSterilizedNo.Checked = true;
            picPetAva.Image = picPetAva.BackgroundImage;
            openFileImage.Reset();
        }
        private tblPet GetData()
        {
            tblPet pet;
            string error = "";
            int typeId = ((tblPetType)cboPetType.SelectedItem).id;
            int petId;
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
            string image = DateTime.Now.Ticks.ToString() + "_" + openFileImage.SafeFileName;

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
                image = image,
                status = true
            };
            if (!string.IsNullOrWhiteSpace(txtPetId.Text))
            {
                petId = int.Parse(txtPetId.Text);
                pet.id = petId;
            }
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
            if (pet.isSterilized != null) rdoPetSterilizedYes.Checked = (bool)pet.isSterilized;
            rdoPetAdoptedYes.Checked = pet.adopter == null ? false : true;
            if (rdoPetAdoptedYes.Checked)
            {
                txtPetAdopter.Text = pet.adopter;
                if (pet.dateAdopted != null) dtmPetDateAdopted.Value = (DateTime)pet.dateAdopted;
            }

            txtPetDescription.Text = pet.description;
            if (pet.image != null)
            {
                string pathImage = FileDAO.Folder + "/" + pet.image;
                if (File.Exists(pathImage))
                    picPetAva.Image = new Bitmap(pathImage);
            }
        }

        private void btnUpdatePet_Click(object sender, EventArgs e)
        {
            try
            {
                tblPet pet = GetData();
                bool result;
                if (pet == null) return;
                if (isCreate)
                {
                    result = TblPetDAO.Instance.CreatePet(pet);
                    _isAction = true;
                    
                }
                else
                {
                    result = TblPetDAO.Instance.UpdatePet(pet);
                    _isAction = true;
                }

                if (result)
                {
                    if (openFileImage.FileName != "")
                    {
                        FileDAO.CopyImage(openFileImage.FileName, pet.image);
                    }
                    MessageBox.Show("Successfuly", "Action", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if(isCreate) Clear();
                }
                else
                {
                    MessageBox.Show("Fail", "Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                this.Close();
            }

        }

        private void rdoPetAdoptedYes_CheckedChanged(object sender, EventArgs e)
        {
            bool adopted = (rdoPetAdoptedYes).Checked;
            btnChooseAdopter.Visible = adopted;
            btnChooseAdopter.Enabled = adopted;
            dtmPetDateAdopted.Enabled = adopted;
            if (!adopted)
            {
                txtPetAdopter.Clear();
            }
        }
        #endregion
        #region Event
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
        private void txtPetName_Validating(object sender, CancelEventArgs e)
        {
            ValidEmpty(txtPetName, "Name is not empty!");
        }

        private void txtPetGender_Validating(object sender, CancelEventArgs e)
        {
            ValidEmpty(txtPetGender, "Gender is not empty");
        }
        private void txtPetAge_Validating(object sender, CancelEventArgs e)
        {
            ValidEmpty(txtPetAge, "Age is not empty");
        }

        private void txtPetFurcolor_Validating(object sender, CancelEventArgs e)
        {
            ValidEmpty(txtPetFurcolor, "Furcolor is not empty");
        }
        #endregion

        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (r == DialogResult.Yes && p != null)
                {
                    if (TblPetDAO.Instance.DeletePet(p.id))
                    {
                        MessageBox.Show("Deleted successfully", "Action");
                    }
                    this.Close();
                    _isAction = true;
                }
            }
            catch (EntityException)
            {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnViewPetDiary_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewNotification newForm = new ViewNotification(p.id);
            newForm.ShowDialog();
            this.Show();
        }

        private void btnChooseAdopter_Click(object sender, EventArgs e)
        {
            ListAdopters newF = new ListAdopters(txtPetAdopter.Text);
            this.Hide();
            newF.ShowDialog();
            this.Show();
            txtPetAdopter.Text = newF.SelectedAdopter;
        }

        private void cboPetCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboPetType_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboPetCategory_KeyPress(sender, e);
        }
    }
}
