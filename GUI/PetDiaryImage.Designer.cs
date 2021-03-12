
namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    partial class PetDiaryImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetDiaryImage));
            this.flpPetDiaryImages = new System.Windows.Forms.FlowLayoutPanel();
            this.picPetImage = new System.Windows.Forms.PictureBox();
            this.flpPetDiaryImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPetImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPetDiaryImages
            // 
            this.flpPetDiaryImages.Controls.Add(this.picPetImage);
            this.flpPetDiaryImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPetDiaryImages.Location = new System.Drawing.Point(0, 0);
            this.flpPetDiaryImages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpPetDiaryImages.Name = "flpPetDiaryImages";
            this.flpPetDiaryImages.Size = new System.Drawing.Size(519, 354);
            this.flpPetDiaryImages.TabIndex = 0;
            // 
            // picPetImage
            // 
            this.picPetImage.Location = new System.Drawing.Point(3, 3);
            this.picPetImage.Name = "picPetImage";
            this.picPetImage.Size = new System.Drawing.Size(516, 351);
            this.picPetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPetImage.TabIndex = 0;
            this.picPetImage.TabStop = false;
            // 
            // PetDiaryImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.flpPetDiaryImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PetDiaryImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetDiaryImage";
            this.flpPetDiaryImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPetImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPetDiaryImages;
        private System.Windows.Forms.PictureBox picPetImage;
    }
}