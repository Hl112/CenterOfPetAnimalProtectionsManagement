using DataProvider;
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
            /*pbPetImg.BackgroundImage = ;*/
        }

        private void btnSave_Click(object sender, System.EventArgs e) {
            MessageBox.Show(Validation(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnChooseImg_Click(object sender, System.EventArgs e) {
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                Image img = Image.FromFile(openFileDialog.FileName);
                pbPetImg.Image = img;
            }
        }

        #region Validation
        private string Validation() {
            /*StringBuilder errors = new StringBuilder("");
            if(cboPetSearchCategory.SelectedIndex == -1) {
                if(errors.Length != 0) {
                    errors.AppendLine();
                }
                errors.Append("Please choose Pet");
            }
            if (string.IsNullOrWhiteSpace(txtPetDiaryDetail.Text)) {
                if (errors.Length != 0) {
                    errors.AppendLine();
                }
                errors.Append("Please enter content");
            }*/

            /*return errors.ToString();*/
            if (cboPetSearchCategory.SelectedIndex == -1) {
                cboPetSearchCategory.Focus();
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
    }
}
