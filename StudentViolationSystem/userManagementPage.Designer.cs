namespace StudentViolationSystem
{
    partial class userManagementPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userManagementNav = new System.Windows.Forms.Label();
            this.addOffenseNav = new System.Windows.Forms.Label();
            this.offenseRecNav = new System.Windows.Forms.Label();
            this.homeNav = new System.Windows.Forms.Label();
            this.addOffenseIcon = new System.Windows.Forms.PictureBox();
            this.offenseRecIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.userManagementIcon = new System.Windows.Forms.PictureBox();
            this.logOutText = new System.Windows.Forms.Label();
            this.userManagementLbl = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.userManagementDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.userManagementNav);
            this.panel1.Controls.Add(this.addOffenseNav);
            this.panel1.Controls.Add(this.offenseRecNav);
            this.panel1.Controls.Add(this.homeNav);
            this.panel1.Controls.Add(this.addOffenseIcon);
            this.panel1.Controls.Add(this.offenseRecIcon);
            this.panel1.Controls.Add(this.homeIcon);
            this.panel1.Controls.Add(this.userManagementIcon);
            this.panel1.Controls.Add(this.logOutText);
            this.panel1.Location = new System.Drawing.Point(-16, -32);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 830);
            this.panel1.TabIndex = 6;
            // 
            // userManagementNav
            // 
            this.userManagementNav.AutoSize = true;
            this.userManagementNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagementNav.Location = new System.Drawing.Point(91, 405);
            this.userManagementNav.Name = "userManagementNav";
            this.userManagementNav.Size = new System.Drawing.Size(118, 16);
            this.userManagementNav.TabIndex = 28;
            this.userManagementNav.Text = "User Management";
            this.userManagementNav.Click += new System.EventHandler(this.userManagementNav_Click);
            // 
            // addOffenseNav
            // 
            this.addOffenseNav.AutoSize = true;
            this.addOffenseNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOffenseNav.Location = new System.Drawing.Point(91, 344);
            this.addOffenseNav.Name = "addOffenseNav";
            this.addOffenseNav.Size = new System.Drawing.Size(81, 16);
            this.addOffenseNav.TabIndex = 27;
            this.addOffenseNav.Text = "Add Offense";
            this.addOffenseNav.Click += new System.EventHandler(this.addOffenseNav_Click);
            // 
            // offenseRecNav
            // 
            this.offenseRecNav.AutoSize = true;
            this.offenseRecNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offenseRecNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.offenseRecNav.Location = new System.Drawing.Point(86, 277);
            this.offenseRecNav.Name = "offenseRecNav";
            this.offenseRecNav.Size = new System.Drawing.Size(148, 25);
            this.offenseRecNav.TabIndex = 26;
            this.offenseRecNav.Text = "Offense Record";
            this.offenseRecNav.Click += new System.EventHandler(this.offenseRecNav_Click);
            // 
            // homeNav
            // 
            this.homeNav.AutoSize = true;
            this.homeNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homeNav.Location = new System.Drawing.Point(86, 210);
            this.homeNav.Name = "homeNav";
            this.homeNav.Size = new System.Drawing.Size(64, 25);
            this.homeNav.TabIndex = 21;
            this.homeNav.Text = "Home";
            this.homeNav.Click += new System.EventHandler(this.homeNav_Click);
            // 
            // addOffenseIcon
            // 
            this.addOffenseIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addOffenseIcon.Image = global::StudentViolationSystem.Properties.Resources.add_offense_icon__1_;
            this.addOffenseIcon.Location = new System.Drawing.Point(32, 331);
            this.addOffenseIcon.Margin = new System.Windows.Forms.Padding(4);
            this.addOffenseIcon.Name = "addOffenseIcon";
            this.addOffenseIcon.Size = new System.Drawing.Size(47, 30);
            this.addOffenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addOffenseIcon.TabIndex = 24;
            this.addOffenseIcon.TabStop = false;
            // 
            // offenseRecIcon
            // 
            this.offenseRecIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.offenseRecIcon.Image = global::StudentViolationSystem.Properties.Resources.offense_record_icon;
            this.offenseRecIcon.Location = new System.Drawing.Point(32, 272);
            this.offenseRecIcon.Margin = new System.Windows.Forms.Padding(4);
            this.offenseRecIcon.Name = "offenseRecIcon";
            this.offenseRecIcon.Size = new System.Drawing.Size(47, 30);
            this.offenseRecIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offenseRecIcon.TabIndex = 23;
            this.offenseRecIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeIcon.Image = global::StudentViolationSystem.Properties.Resources.home_icon__1_;
            this.homeIcon.Location = new System.Drawing.Point(32, 209);
            this.homeIcon.Margin = new System.Windows.Forms.Padding(4);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(47, 30);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 22;
            this.homeIcon.TabStop = false;
            // 
            // userManagementIcon
            // 
            this.userManagementIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userManagementIcon.Image = global::StudentViolationSystem.Properties.Resources.user_management_icon;
            this.userManagementIcon.Location = new System.Drawing.Point(32, 391);
            this.userManagementIcon.Margin = new System.Windows.Forms.Padding(4);
            this.userManagementIcon.Name = "userManagementIcon";
            this.userManagementIcon.Size = new System.Drawing.Size(47, 30);
            this.userManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userManagementIcon.TabIndex = 25;
            this.userManagementIcon.TabStop = false;
            // 
            // logOutText
            // 
            this.logOutText.AutoSize = true;
            this.logOutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutText.Location = new System.Drawing.Point(97, 784);
            this.logOutText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOutText.Name = "logOutText";
            this.logOutText.Size = new System.Drawing.Size(82, 25);
            this.logOutText.TabIndex = 8;
            this.logOutText.Text = "Log Out";
            this.logOutText.Click += new System.EventHandler(this.logOutText_Click);
            // 
            // userManagementLbl
            // 
            this.userManagementLbl.AutoSize = true;
            this.userManagementLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementLbl.Location = new System.Drawing.Point(287, 30);
            this.userManagementLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userManagementLbl.Name = "userManagementLbl";
            this.userManagementLbl.Size = new System.Drawing.Size(225, 29);
            this.userManagementLbl.TabIndex = 7;
            this.userManagementLbl.Text = "User Management";
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(293, 65);
            this.searchField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(727, 30);
            this.searchField.TabIndex = 4;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            this.searchField.Enter += new System.EventHandler(this.searchField_Enter);
            this.searchField.Leave += new System.EventHandler(this.searchField_Leave);
            // 
            // userManagementDataGrid
            // 
            this.userManagementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userManagementDataGrid.Location = new System.Drawing.Point(293, 178);
            this.userManagementDataGrid.Name = "userManagementDataGrid";
            this.userManagementDataGrid.RowHeadersWidth = 51;
            this.userManagementDataGrid.RowTemplate.Height = 24;
            this.userManagementDataGrid.Size = new System.Drawing.Size(1045, 532);
            this.userManagementDataGrid.TabIndex = 8;
            // 
            // userManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.userManagementDataGrid);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.userManagementLbl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userManagementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userManagementPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userManagementLbl;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label logOutText;
        private System.Windows.Forms.Label userManagementNav;
        private System.Windows.Forms.Label addOffenseNav;
        private System.Windows.Forms.Label offenseRecNav;
        private System.Windows.Forms.Label homeNav;
        private System.Windows.Forms.PictureBox addOffenseIcon;
        private System.Windows.Forms.PictureBox offenseRecIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox userManagementIcon;
        private System.Windows.Forms.DataGridView userManagementDataGrid;
    }
}