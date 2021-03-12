
namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    partial class frmNormalControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNormalControlPanel));
            this.txtAppName = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAppName
            // 
            this.txtAppName.AutoSize = true;
            this.txtAppName.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppName.Location = new System.Drawing.Point(248, 13);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(685, 28);
            this.txtAppName.TabIndex = 13;
            this.txtAppName.Text = "MANAGEMENT APPLICATION FOR CENTER OF PET ANIMAL PROTECTIONS";
            this.txtAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(1126, 14);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 27);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1158, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 27);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(1091, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(28, 26);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmNormalControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAppName);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "frmNormalControlPanel";
            this.Size = new System.Drawing.Size(1200, 50);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAppName;
        private Bunifu.Framework.UI.BunifuCustomLabel btnMinimize;
        private Bunifu.Framework.UI.BunifuCustomLabel btnClose;
        private System.Windows.Forms.PictureBox btnLogout;
    }
}
