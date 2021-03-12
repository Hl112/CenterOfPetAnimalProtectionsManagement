using System.Drawing;
using System.Windows.Forms;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class PetDiaryImage : Form
    {
        public PetDiaryImage()
        {
            InitializeComponent();
        }

        public PetDiaryImage(string path)
        {
            InitializeComponent();
            picPetImage.Image = new Bitmap(path);
        }
    }
}
