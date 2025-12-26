namespace StudentViolationSystem
{
    partial class offenseRecord
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
            this.offenseRecLabel = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
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
            this.offenseRecDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // offenseRecLabel
            // 
            this.offenseRecLabel.AutoSize = true;
            this.offenseRecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenseRecLabel.Location = new System.Drawing.Point(273, 24);
            this.offenseRecLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.offenseRecLabel.Name = "offenseRecLabel";
            this.offenseRecLabel.Size = new System.Drawing.Size(196, 29);
            this.offenseRecLabel.TabIndex = 2;
            this.offenseRecLabel.Text = "Offense Record";
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(278, 73);
            this.searchField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(546, 30);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            this.searchField.Enter += new System.EventHandler(this.textBox1_Enter);
            this.searchField.Leave += new System.EventHandler(this.searchField_Leave);
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
            this.panel1.Location = new System.Drawing.Point(-13, -27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 869);
            this.panel1.TabIndex = 4;
            // 
            // userManagementNav
            // 
            this.userManagementNav.AutoSize = true;
            this.userManagementNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagementNav.Location = new System.Drawing.Point(81, 353);
            this.userManagementNav.Name = "userManagementNav";
            this.userManagementNav.Size = new System.Drawing.Size(130, 18);
            this.userManagementNav.TabIndex = 20;
            this.userManagementNav.Text = "User Management";
            this.userManagementNav.Click += new System.EventHandler(this.userManagementNav_Click);
            // 
            // addOffenseNav
            // 
            this.addOffenseNav.AutoSize = true;
            this.addOffenseNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOffenseNav.Location = new System.Drawing.Point(81, 292);
            this.addOffenseNav.Name = "addOffenseNav";
            this.addOffenseNav.Size = new System.Drawing.Size(89, 18);
            this.addOffenseNav.TabIndex = 19;
            this.addOffenseNav.Text = "Add Offense";
            this.addOffenseNav.Click += new System.EventHandler(this.addOffenseNav_Click);
            // 
            // offenseRecNav
            // 
            this.offenseRecNav.AutoSize = true;
            this.offenseRecNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offenseRecNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.offenseRecNav.Location = new System.Drawing.Point(76, 225);
            this.offenseRecNav.Name = "offenseRecNav";
            this.offenseRecNav.Size = new System.Drawing.Size(148, 25);
            this.offenseRecNav.TabIndex = 18;
            this.offenseRecNav.Text = "Offense Record";
            this.offenseRecNav.Click += new System.EventHandler(this.offenseRecNav_Click);
            // 
            // homeNav
            // 
            this.homeNav.AutoSize = true;
            this.homeNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homeNav.Location = new System.Drawing.Point(76, 158);
            this.homeNav.Name = "homeNav";
            this.homeNav.Size = new System.Drawing.Size(64, 25);
            this.homeNav.TabIndex = 13;
            this.homeNav.Text = "Home";
            this.homeNav.Click += new System.EventHandler(this.homeNav_Click);
            // 
            // addOffenseIcon
            // 
            this.addOffenseIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addOffenseIcon.Image = global::StudentViolationSystem.Properties.Resources.add_offense_icon__1_;
            this.addOffenseIcon.Location = new System.Drawing.Point(22, 279);
            this.addOffenseIcon.Margin = new System.Windows.Forms.Padding(4);
            this.addOffenseIcon.Name = "addOffenseIcon";
            this.addOffenseIcon.Size = new System.Drawing.Size(47, 30);
            this.addOffenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addOffenseIcon.TabIndex = 16;
            this.addOffenseIcon.TabStop = false;
            // 
            // offenseRecIcon
            // 
            this.offenseRecIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.offenseRecIcon.Image = global::StudentViolationSystem.Properties.Resources.offense_record_icon;
            this.offenseRecIcon.Location = new System.Drawing.Point(22, 220);
            this.offenseRecIcon.Margin = new System.Windows.Forms.Padding(4);
            this.offenseRecIcon.Name = "offenseRecIcon";
            this.offenseRecIcon.Size = new System.Drawing.Size(47, 30);
            this.offenseRecIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offenseRecIcon.TabIndex = 15;
            this.offenseRecIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.homeIcon.Image = global::StudentViolationSystem.Properties.Resources.home_icon__1_;
            this.homeIcon.Location = new System.Drawing.Point(22, 157);
            this.homeIcon.Margin = new System.Windows.Forms.Padding(4);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(47, 30);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 14;
            this.homeIcon.TabStop = false;
            // 
            // userManagementIcon
            // 
            this.userManagementIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userManagementIcon.Image = global::StudentViolationSystem.Properties.Resources.user_management_icon;
            this.userManagementIcon.Location = new System.Drawing.Point(22, 339);
            this.userManagementIcon.Margin = new System.Windows.Forms.Padding(4);
            this.userManagementIcon.Name = "userManagementIcon";
            this.userManagementIcon.Size = new System.Drawing.Size(47, 30);
            this.userManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userManagementIcon.TabIndex = 17;
            this.userManagementIcon.TabStop = false;
            // 
            // logOutText
            // 
            this.logOutText.AutoSize = true;
            this.logOutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutText.Location = new System.Drawing.Point(74, 638);
            this.logOutText.Name = "logOutText";
            this.logOutText.Size = new System.Drawing.Size(82, 25);
            this.logOutText.TabIndex = 5;
            this.logOutText.Text = "Log Out";
            this.logOutText.Click += new System.EventHandler(this.logOutText_Click);
            // 
            // offenseRecDataGridView
            // 
            this.offenseRecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offenseRecDataGridView.Location = new System.Drawing.Point(279, 226);
            this.offenseRecDataGridView.Name = "offenseRecDataGridView";
            this.offenseRecDataGridView.RowHeadersWidth = 51;
            this.offenseRecDataGridView.RowTemplate.Height = 24;
            this.offenseRecDataGridView.Size = new System.Drawing.Size(1077, 463);
            this.offenseRecDataGridView.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(279, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 40);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(1076, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 40);
            this.panel3.TabIndex = 7;
            // 
            // offenseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.offenseRecDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.offenseRecLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "offenseRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.offenseRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label offenseRecLabel;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logOutText;
        private System.Windows.Forms.Label userManagementNav;
        private System.Windows.Forms.Label addOffenseNav;
        private System.Windows.Forms.Label offenseRecNav;
        private System.Windows.Forms.Label homeNav;
        private System.Windows.Forms.PictureBox addOffenseIcon;
        private System.Windows.Forms.PictureBox offenseRecIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox userManagementIcon;
        private System.Windows.Forms.DataGridView offenseRecDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}