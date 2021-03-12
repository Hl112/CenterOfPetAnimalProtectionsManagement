using DataProvider;
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
            
        }

        private void btnSave_Click(object sender, System.EventArgs e) {

        }

        private void btnChooseImg_Click(object sender, System.EventArgs e) {

        }
    }
}
