using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BussinessObject.DataAccess;
using DataProvider;

namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    public partial class ViewNotification : Form
    {
        private string imgPath = "";

        private bool isForAdopter = false;
        //For admin
        public ViewNotification()
        {
            InitializeComponent();
            try
            {
                LoadNoti();
                this.Text = "Notification";
            }
            catch (Exception)
            {
                MessageBox.Show("Conection Error.");
                this.Close();
            }
        }

        //For Admin, in Adopterdetail, when click one row of listview Pets
        public ViewNotification(int petID)
        {
            InitializeComponent();
            try
            {
                //Load list pet diary
                List<tblPetDiary> petDiaries = TblPetDiaryDAO.Instance.GetPetDiariesByPetID(petID);
                LoadNoti(petDiaries);
                this.Text = "Pet Diary By Pet";
            }
            catch (Exception)
            {
                MessageBox.Show("Conection Error.");
                this.Close();
            }
        }

        //For Adopter
        public ViewNotification(tblAccount adopter)
        {
            InitializeComponent();
            try
            {
                isForAdopter = true;
                //Load list pet diary
                List<tblPetDiary> petDiaries = TblPetDiaryDAO.Instance.GetPetDiariesByAopter(adopter.username);
                LoadNoti(petDiaries);
                this.Text = "Pet Diary By Adopter";
            }
            catch (Exception)
            {
                MessageBox.Show("Conection Error.");
                this.Close();
            }
        }

        #region Load Notification
        public void LoadNoti()
        {
            List<tblPetDiary> list = NotificationDAO.Instance.GetNotification();
            foreach (var VARIABLE in list)
            {
                ListViewItem item = new ListViewItem(new []{VARIABLE.adopter,VARIABLE.petId.ToString(), VARIABLE.tblPet.name});
                item.Tag = VARIABLE;
                if (!VARIABLE.isRead)
                {
                    item.ForeColor = Color.Red;
                   
                }
                lvNotification.Items.Add(item);
            }
        }
        public void LoadNoti(List<tblPetDiary> petDiaries) {
            
            foreach (tblPetDiary diary in petDiaries) {
                ListViewItem item = new ListViewItem(new[] { diary.adopter, diary.petId.ToString(), diary.tblPet.name });
                item.Tag = diary;
                if (!diary.isRead && !isForAdopter) {
                    item.ForeColor = Color.Red;

                }
                lvNotification.Items.Add(item);
            }
        }
        #endregion
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void lvNotification_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var item = e.Item;
                if (item != null)
                {
                    tblPetDiary noti = (tblPetDiary) item.Tag;
                    tbDate.Text = noti.createDate.ToString();
                    txtName.Text = noti.tblPet.name;
                    txtAdopter.Text = noti.adopter;
                    txtPetDiaryDetail.Text = noti.diaryDetail;
                    imgPath = FileDAO.Folder + "/" + noti.diaryImages;
                   if(!noti.isRead && !isForAdopter)  NotificationDAO.Instance.MakeRead(noti.id);
                    item.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error");
                this.Close();
            }
        }

        private void btnViewImagePetDiary_Click(object sender, EventArgs e)
        {
            if (File.Exists(imgPath))
            {
                new PetDiaryImage(imgPath).ShowDialog();
            }
            else
            {
                MessageBox.Show("No Image");
            }
        }

        private void ViewNotification_Load(object sender, EventArgs e)
        {
            if (isForAdopter)
            {
                frmAdmin1.Visible = false;
                frmAdopterPanel1.Visible = true;
            }
            else
            {
                frmAdmin1.Visible = true;
                frmAdopterPanel1.Visible = false;
            }
        }
    }
}
