using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BussinessObject.DataAccess;
using DataProvider;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class AdopterDetail : Form
    {
        private const string password = "123";
        private const int roleID = 2;//Adopter
        private bool isCreate = true;
        private tblAccount adopter;
        public AdopterDetail()
        {
            InitializeComponent();
        }

        public AdopterDetail(bool isCreate, tblAccount adopter)
        {
            InitializeComponent();
            if (isCreate)
            {

            }
            else
            {
                this.adopter = adopter;
                LoadData(adopter);
            }
        }

        private tblAccount GetData()
        {
            tblAccount account = null;
            string id = txtAdopterUsername.Text;
            string fullname = txtAdopterFullname.Text;
            string phone = txtAdopterPhone.Text;
            string address = txtAdopterAddress.Text;
            bool isBlack = rdoBlackListYes.Checked;
            string reason = null;
            if (isBlack) reason = txtAdopterReasonBlacklist.Text;
            string image = null;
            if (openFile.SafeFileName != "")
                image = openFile.SafeFileName;
            string valid = "";
            if (string.IsNullOrWhiteSpace(id)) valid += "ID is not empty\n";
            if (string.IsNullOrWhiteSpace(fullname)) valid += "Fullname is not empty\n";
            if (string.IsNullOrWhiteSpace(phone)) valid += "Phone is not empty\n";
            //if (!Regex.IsMatch(phone,"\\d")) valid += "Phone is number\n";
            if (string.IsNullOrWhiteSpace(address)) valid += "Address is not empty\n";
            if (isBlack)
                if (string.IsNullOrWhiteSpace(reason))
                    valid += "Reason is not empty";
            if (valid != "")
            {
                MessageBox.Show(valid, "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            account = new tblAccount()
            {
                username = id,
                fullname = fullname,
                phone = phone,
                address = address,
                isInBlackList = isBlack,
                status = true,
                password = password,
                reasonBlackList = reason,
                roleID = roleID,
                image = image
                
            };
            return account;
        }

        private void SetData(tblAccount account)
        {
            txtAdopterUsername.Text = account.username;
            txtAdopterFullname.Text = account.fullname;
            txtAdopterPhone.Text = account.phone;
            txtAdopterAddress.Text = account.address;
            rdoBlackListYes.Checked = account.isInBlackList;
            txtAdopterReasonBlacklist.Text = account.reasonBlackList;
            if (account.tblPet.Count != 0)
            {
                 //lvListPetsOfAdopter.Items = ;
            }
        }

        private void picAdopterAva_Click(object sender, System.EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAdopterAva.Image = new Bitmap(openFile.FileName);
            }
        }

        private void btnUpdateAdopter_Click(object sender, System.EventArgs e)
        {
            try{
            tblAccount account = GetData();
            bool result = false;
            if(account == null) return;
            if (isCreate)
            {
               result = TblAccountDAO.Instance.CreateAdopter(account);
            }
            else
            {
               //result = TblAccountDAO.Instance.UpdateAdopter(account);
            }

            if (result)
            {
                if (openFile.FileName != "")
                {
                    FileDAO.CopyImage(openFile.FileName, openFile.SafeFileName);
                }
                MessageBox.Show("Successfuly", "Action", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Fail", "Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
            throw;
        }

        }

    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData(tblAccount adopter)
        {
            txtAdopterUsername.Text = adopter.username;
            txtAdopterFullname.Text = adopter.fullname;
            txtAdopterPhone.Text = adopter.phone;
            txtAdopterAddress.Text = adopter.address;
            if (adopter.isInBlackList)
            {
                rdoBlackListYes.Checked = true;
                lbReason.Visible = true;
                txtAdopterReasonBlacklist.Visible = true;
                txtAdopterReasonBlacklist.Text = adopter.reasonBlackList;
            }
            else
            {
                rdoBlackListNo.Checked = true;
                lbReason.Visible = false;
                txtAdopterReasonBlacklist.Visible = false;
            }

            if (adopter.image != null)
            {
                if (adopter.image.Trim() != String.Empty)
                {
                    picAdopterAva.ImageLocation = @"..\..\..\images\" + adopter.image;
                    picAdopterAva.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }

            LoadLvListPets(adopter.username);

        }

        private void LoadLvListPets(string username)
        {
            var listPets = TblPetDAO.Instance.GetPetsByAdopterUsername(username);
            if (listPets != null)
            {
                lvListPetsOfAdopter.Clear();
                lvListPetsOfAdopter.Columns.Add("Id");
                lvListPetsOfAdopter.Columns.Add("Name");
                lvListPetsOfAdopter.Columns.Add("Age");
                lvListPetsOfAdopter.Columns.Add("Date Adopted");

                foreach (var pet in listPets)
                {
                    ListViewItem item = new ListViewItem(pet.id.ToString());
                    item.SubItems.Add(pet.name);
                    item.SubItems.Add(pet.age);
                    item.SubItems.Add(pet.dateAdopted.ToString());
                    lvListPetsOfAdopter.Items.Add(item);

                }
                lvListPetsOfAdopter.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvListPetsOfAdopter.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvListPetsOfAdopter.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                lvListPetsOfAdopter.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void rdoBlackListYes_Click(object sender, EventArgs e)
        {
            lbReason.Visible = true;
            txtAdopterReasonBlacklist.Visible = true;
        }

        private void rdoBlackListNo_Click(object sender, EventArgs e)
        {
            lbReason.Visible = false;
            txtAdopterReasonBlacklist.Visible = false;
        }
    }
}
