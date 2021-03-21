
namespace CenterOfPetAnimalProtectionsManagement.GUI
{
    partial class ListAdopters
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAdopters));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dgvListAdopters = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchValue = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboPetSearchCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmAdmin1 = new CenterOfPetAnimalProtectionsManagement.GUI.frmAdmin();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAdopters)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Maroon;
            label2.Location = new System.Drawing.Point(99, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(965, 60);
            label2.TabIndex = 0;
            label2.Text = "S E A R C H   P E T S   B Y   A D O P T E R";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListAdopters
            // 
            this.dgvListAdopters.AllowUserToAddRows = false;
            this.dgvListAdopters.AllowUserToDeleteRows = false;
            this.dgvListAdopters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListAdopters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListAdopters.BackgroundColor = System.Drawing.Color.White;
            this.dgvListAdopters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAdopters.Location = new System.Drawing.Point(183, 281);
            this.dgvListAdopters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListAdopters.Name = "dgvListAdopters";
            this.dgvListAdopters.ReadOnly = true;
            this.dgvListAdopters.RowHeadersVisible = false;
            this.dgvListAdopters.RowHeadersWidth = 62;
            this.dgvListAdopters.RowTemplate.Height = 28;
            this.dgvListAdopters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAdopters.Size = new System.Drawing.Size(720, 264);
            this.dgvListAdopters.TabIndex = 1;
            this.dgvListAdopters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListAdopters_CellClick);
            this.dgvListAdopters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListAdopters_CellDoubleClick);
            this.dgvListAdopters.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListAdopters_CellMouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 281);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 268);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.AcceptsReturn = false;
            this.txtSearchValue.AcceptsTab = false;
            this.txtSearchValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchValue.AnimationSpeed = 200;
            this.txtSearchValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.txtSearchValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchValue.BackgroundImage")));
            this.txtSearchValue.BorderColorActive = System.Drawing.Color.DarkGreen;
            this.txtSearchValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearchValue.BorderColorHover = System.Drawing.Color.Green;
            this.txtSearchValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.txtSearchValue.BorderRadius = 1;
            this.txtSearchValue.BorderThickness = 2;
            this.txtSearchValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.DefaultFont = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.DefaultText = "";
            this.txtSearchValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.txtSearchValue.HideSelection = true;
            this.txtSearchValue.IconLeft = null;
            this.txtSearchValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.IconPadding = 10;
            this.txtSearchValue.IconRight = null;
            this.txtSearchValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.Lines = new string[0];
            this.txtSearchValue.Location = new System.Drawing.Point(126, 46);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchValue.MaxLength = 32767;
            this.txtSearchValue.MinimumSize = new System.Drawing.Size(196, 22);
            this.txtSearchValue.Modified = false;
            this.txtSearchValue.Multiline = false;
            this.txtSearchValue.Name = "txtSearchValue";
            stateProperties13.BorderColor = System.Drawing.Color.Maroon;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchValue.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Empty;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchValue.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.Maroon;
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchValue.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchValue.OnIdleState = stateProperties16;
            this.txtSearchValue.PasswordChar = '\0';
            this.txtSearchValue.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchValue.PlaceholderText = "";
            this.txtSearchValue.ReadOnly = false;
            this.txtSearchValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchValue.SelectedText = "";
            this.txtSearchValue.SelectionLength = 0;
            this.txtSearchValue.SelectionStart = 0;
            this.txtSearchValue.ShortcutsEnabled = true;
            this.txtSearchValue.Size = new System.Drawing.Size(267, 30);
            this.txtSearchValue.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtSearchValue.TabIndex = 21;
            this.txtSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchValue.TextMarginBottom = 0;
            this.txtSearchValue.TextMarginLeft = 5;
            this.txtSearchValue.TextMarginTop = 0;
            this.txtSearchValue.TextPlaceholder = "";
            this.txtSearchValue.UseSystemPasswordChar = false;
            this.txtSearchValue.WordWrap = true;
            this.txtSearchValue.TextChange += new System.EventHandler(this.txtSearchValue_TextChange);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.cboPetSearchCategory, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 43);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(397, 80);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // cboPetSearchCategory
            // 
            this.cboPetSearchCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboPetSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.cboPetSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPetSearchCategory.FormattingEnabled = true;
            this.cboPetSearchCategory.Location = new System.Drawing.Point(127, 8);
            this.cboPetSearchCategory.Name = "cboPetSearchCategory";
            this.cboPetSearchCategory.Size = new System.Drawing.Size(267, 26);
            this.cboPetSearchCategory.TabIndex = 27;
            this.cboPetSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cboPetSearchCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search By:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Key Word:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.tableLayoutPanel3.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel3.Controls.Add(label2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1067, 54);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 56);
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(321, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 147);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Details";
            // 
            // frmAdmin1
            // 
            this.frmAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.frmAdmin1.ForeColor = System.Drawing.Color.Transparent;
            this.frmAdmin1.Location = new System.Drawing.Point(0, -1);
            this.frmAdmin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmAdmin1.Name = "frmAdmin1";
            this.frmAdmin1.Size = new System.Drawing.Size(1067, 34);
            this.frmAdmin1.TabIndex = 0;
            this.frmAdmin1.Load += new System.EventHandler(this.frmAdmin1_Load);
            // 
            // ListAdopters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1067, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListAdopters);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.frmAdmin1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListAdopters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListAdopters";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAdopters)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private frmAdmin frmAdmin1;
        private System.Windows.Forms.DataGridView dgvListAdopters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearchValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPetSearchCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}