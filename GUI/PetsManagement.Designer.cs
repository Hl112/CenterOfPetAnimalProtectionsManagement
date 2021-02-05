
namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    partial class frmPetsManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetsManagement));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowAllPets = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreatePet = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchPet = new System.Windows.Forms.Button();
            this.cboPetCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPetType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchPetID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tipButtonCreate = new System.Windows.Forms.ToolTip(this.components);
            this.txtFurcolor = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoSterilizedNo = new System.Windows.Forms.RadioButton();
            this.rdoSterilizedYes = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoAdoptedYes = new System.Windows.Forms.RadioButton();
            this.rdoAdoptedNo = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.frmAdmin1 = new CenterOfPetAnimalProtectionsManagement.GUI.frmAdmin();
            this.dtmDateAdoptedSearch = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreatePet)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Maroon;
            label1.Location = new System.Drawing.Point(402, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(395, 38);
            label1.TabIndex = 0;
            label1.Text = "P E T S   M A N A G E M E N T";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 42);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(-1, 668);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 70);
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(75, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1113, 651);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(60, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 480);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnShowAllPets, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(559, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(551, 645);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnShowAllPets
            // 
            this.btnShowAllPets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowAllPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.btnShowAllPets.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllPets.ForeColor = System.Drawing.Color.White;
            this.btnShowAllPets.Location = new System.Drawing.Point(211, 598);
            this.btnShowAllPets.Name = "btnShowAllPets";
            this.btnShowAllPets.Size = new System.Drawing.Size(128, 42);
            this.btnShowAllPets.TabIndex = 1;
            this.btnShowAllPets.Text = "Show all";
            this.btnShowAllPets.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.btnSearchPet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 645);
            this.panel1.TabIndex = 6;
            // 
            // btnCreatePet
            // 
            this.btnCreatePet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreatePet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreatePet.Image = ((System.Drawing.Image)(resources.GetObject("btnCreatePet.Image")));
            this.btnCreatePet.Location = new System.Drawing.Point(7, 0);
            this.btnCreatePet.Name = "btnCreatePet";
            this.btnCreatePet.Size = new System.Drawing.Size(66, 70);
            this.btnCreatePet.TabIndex = 5;
            this.btnCreatePet.TabStop = false;
            this.btnCreatePet.Tag = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCreatePet);
            this.panel2.Location = new System.Drawing.Point(442, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 78);
            this.panel2.TabIndex = 6;
            this.tipButtonCreate.SetToolTip(this.panel2, "Click here to create new Pet");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create Pet";
            // 
            // btnSearchPet
            // 
            this.btnSearchPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.btnSearchPet.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPet.ForeColor = System.Drawing.Color.White;
            this.btnSearchPet.Location = new System.Drawing.Point(185, 598);
            this.btnSearchPet.Name = "btnSearchPet";
            this.btnSearchPet.Size = new System.Drawing.Size(128, 42);
            this.btnSearchPet.TabIndex = 2;
            this.btnSearchPet.Text = "Search";
            this.btnSearchPet.UseVisualStyleBackColor = false;
            // 
            // cboPetCategory
            // 
            this.cboPetCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPetCategory.FormattingEnabled = true;
            this.cboPetCategory.Location = new System.Drawing.Point(160, 20);
            this.cboPetCategory.Name = "cboPetCategory";
            this.cboPetCategory.Size = new System.Drawing.Size(220, 28);
            this.cboPetCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.cboPetType, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboPetCategory, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtSearchPetID, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtFurcolor, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.dtmDateAdoptedSearch, 1, 6);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(57, 93);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(450, 497);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type:";
            // 
            // cboPetType
            // 
            this.cboPetType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPetType.FormattingEnabled = true;
            this.cboPetType.Location = new System.Drawing.Point(160, 88);
            this.cboPetType.Name = "cboPetType";
            this.cboPetType.Size = new System.Drawing.Size(220, 28);
            this.cboPetType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "PetID: ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Furcolor:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(3, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sterilized:";
            // 
            // txtSearchPetID
            // 
            this.txtSearchPetID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchPetID.Location = new System.Drawing.Point(160, 157);
            this.txtSearchPetID.Name = "txtSearchPetID";
            this.txtSearchPetID.Size = new System.Drawing.Size(220, 26);
            this.txtSearchPetID.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(3, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date adopted: ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(3, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Adopted:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(178, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 38);
            this.label10.TabIndex = 6;
            this.label10.Text = "Search by:";
            // 
            // tipButtonCreate
            // 
            this.tipButtonCreate.ToolTipTitle = "Create Pet";
            // 
            // txtFurcolor
            // 
            this.txtFurcolor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFurcolor.Location = new System.Drawing.Point(160, 225);
            this.txtFurcolor.Name = "txtFurcolor";
            this.txtFurcolor.Size = new System.Drawing.Size(220, 26);
            this.txtFurcolor.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.rdoSterilizedYes);
            this.flowLayoutPanel1.Controls.Add(this.rdoSterilizedNo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(160, 275);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 62);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // rdoSterilizedNo
            // 
            this.rdoSterilizedNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoSterilizedNo.AutoSize = true;
            this.rdoSterilizedNo.ForeColor = System.Drawing.Color.Maroon;
            this.rdoSterilizedNo.Location = new System.Drawing.Point(3, 33);
            this.rdoSterilizedNo.Name = "rdoSterilizedNo";
            this.rdoSterilizedNo.Size = new System.Drawing.Size(54, 24);
            this.rdoSterilizedNo.TabIndex = 0;
            this.rdoSterilizedNo.TabStop = true;
            this.rdoSterilizedNo.Text = "No";
            this.rdoSterilizedNo.UseVisualStyleBackColor = true;
            // 
            // rdoSterilizedYes
            // 
            this.rdoSterilizedYes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoSterilizedYes.AutoSize = true;
            this.rdoSterilizedYes.ForeColor = System.Drawing.Color.Maroon;
            this.rdoSterilizedYes.Location = new System.Drawing.Point(3, 3);
            this.rdoSterilizedYes.Name = "rdoSterilizedYes";
            this.rdoSterilizedYes.Size = new System.Drawing.Size(62, 24);
            this.rdoSterilizedYes.TabIndex = 1;
            this.rdoSterilizedYes.TabStop = true;
            this.rdoSterilizedYes.Text = "Yes";
            this.rdoSterilizedYes.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.Controls.Add(this.rdoAdoptedYes);
            this.flowLayoutPanel2.Controls.Add(this.rdoAdoptedNo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(160, 344);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(108, 60);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // rdoAdoptedYes
            // 
            this.rdoAdoptedYes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoAdoptedYes.AutoSize = true;
            this.rdoAdoptedYes.ForeColor = System.Drawing.Color.Maroon;
            this.rdoAdoptedYes.Location = new System.Drawing.Point(3, 3);
            this.rdoAdoptedYes.Name = "rdoAdoptedYes";
            this.rdoAdoptedYes.Size = new System.Drawing.Size(62, 24);
            this.rdoAdoptedYes.TabIndex = 1;
            this.rdoAdoptedYes.TabStop = true;
            this.rdoAdoptedYes.Text = "Yes";
            this.rdoAdoptedYes.UseVisualStyleBackColor = true;
            // 
            // rdoAdoptedNo
            // 
            this.rdoAdoptedNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoAdoptedNo.AutoSize = true;
            this.rdoAdoptedNo.ForeColor = System.Drawing.Color.Maroon;
            this.rdoAdoptedNo.Location = new System.Drawing.Point(3, 33);
            this.rdoAdoptedNo.Name = "rdoAdoptedNo";
            this.rdoAdoptedNo.Size = new System.Drawing.Size(54, 24);
            this.rdoAdoptedNo.TabIndex = 0;
            this.rdoAdoptedNo.TabStop = true;
            this.rdoAdoptedNo.Text = "No";
            this.rdoAdoptedNo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(201, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 38);
            this.label11.TabIndex = 7;
            this.label11.Text = "List Pets:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 84);
            this.panel3.TabIndex = 2;
            // 
            // frmAdmin1
            // 
            this.frmAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.frmAdmin1.ForeColor = System.Drawing.Color.Transparent;
            this.frmAdmin1.Location = new System.Drawing.Point(-1, 0);
            this.frmAdmin1.Name = "frmAdmin1";
            this.frmAdmin1.Size = new System.Drawing.Size(1204, 42);
            this.frmAdmin1.TabIndex = 0;
            // 
            // dtmDateAdoptedSearch
            // 
            this.dtmDateAdoptedSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtmDateAdoptedSearch.Location = new System.Drawing.Point(160, 439);
            this.dtmDateAdoptedSearch.Name = "dtmDateAdoptedSearch";
            this.dtmDateAdoptedSearch.Size = new System.Drawing.Size(287, 26);
            this.dtmDateAdoptedSearch.TabIndex = 16;
            // 
            // frmPetsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.frmAdmin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPetsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetsManagement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreatePet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private frmAdmin frmAdmin1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnShowAllPets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCreatePet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchPet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPetCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboPetType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchPetID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip tipButtonCreate;
        private System.Windows.Forms.TextBox txtFurcolor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoSterilizedYes;
        private System.Windows.Forms.RadioButton rdoSterilizedNo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rdoAdoptedYes;
        private System.Windows.Forms.RadioButton rdoAdoptedNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtmDateAdoptedSearch;
    }
}