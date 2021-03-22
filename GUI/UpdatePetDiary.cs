using BussinessObject.DataAccess;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Drawing;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class UpdatePetDiary : Form
    {
        private tblAccount adopter;
        public UpdatePetDiary(tblAccount user)
        {
            InitializeComponent();
            this.adopter = user;
            InitData();
        }

        public UpdatePetDiary() {
            InitializeComponent();
            InitData();
        }

        private void InitData() {
            openFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            openFileDialog.Multiselect = false;

            //load pet's name cbo
            List<tblPet> pets;
            try {
                pets = TblPetDAO.Instance.GetPetsByAdopterUsername(adopter.username);
            } catch (EntityException) {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cboPetName.DataSource = pets;
            cboPetName.DisplayMember = "name";
            cboPetName.ValueMember = "id";
            cboPetName.SelectedIndex = -1;
        }


        private void btnSave_Click(object sender, System.EventArgs e) {
            string error = Validation();
            if (!string.IsNullOrEmpty(error)) {
                MessageBox.Show(error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes) {
                string fileName = DateTime.Now.Ticks.ToString() + "_" + openFileDialog.SafeFileName;

                tblPetDiary diary = new tblPetDiary {
                    adopter = adopter.username,
                    petId = (int)cboPetName.SelectedValue,
                    diaryDetail = txtPetDiaryDetail.Text.Trim(),
                    diaryImages = fileName,
                    createDate = DateTime.Now,
                    isRead = false
                };

                bool result = TblPetDiaryDAO.Instance.CreatePetDiary(diary);
                if (result) {
                    FileDAO.CopyImage(openFileDialog.FileName, fileName);
                    MessageBox.Show("Saved successfully!", "Notification");
                    RefreshScreen();
                }
            }
        }

        private void RefreshScreen() {
            openFileDialog.FileName = "";
            pbPetImg.Image = null;
            cboPetName.SelectedIndex = -1;
            txtPetDiaryDetail.Clear();

        }

        private void btnChooseImg_Click(object sender, System.EventArgs e) {
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                Image img = Image.FromFile(openFileDialog.FileName);
                pbPetImg.Image = img;
            }
        }

        #region Validation
        private string Validation() {
            if (cboPetName.SelectedIndex == -1) {
                cboPetName.Focus();
                return "Please choose Pet.";
            }
            if (string.IsNullOrWhiteSpace(txtPetDiaryDetail.Text)) {
                txtPetDiaryDetail.Focus();
                return "Please enter content.";
                
            }
            if(pbPetImg.Image == null) {
                pbPetImg.Focus();
                return "Please upload picture";
            }
            return "";
        }
        #endregion

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cboPetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
