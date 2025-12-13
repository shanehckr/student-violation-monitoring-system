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
            this.logOutText = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Button();
            this.addOffenseButton = new System.Windows.Forms.Button();
            this.offenseRecButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.userManagementIcon = new System.Windows.Forms.PictureBox();
            this.addOffenseIcon = new System.Windows.Forms.PictureBox();
            this.offenseRecIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // offenseRecLabel
            // 
            this.offenseRecLabel.AutoSize = true;
            this.offenseRecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenseRecLabel.Location = new System.Drawing.Point(214, 24);
            this.offenseRecLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.offenseRecLabel.Name = "offenseRecLabel";
            this.offenseRecLabel.Size = new System.Drawing.Size(156, 24);
            this.offenseRecLabel.TabIndex = 2;
            this.offenseRecLabel.Text = "Offense Record";
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(220, 53);
            this.searchField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(546, 26);
            this.searchField.TabIndex = 3;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            this.searchField.Enter += new System.EventHandler(this.textBox1_Enter);
            this.searchField.Leave += new System.EventHandler(this.searchField_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.userManagementIcon);
            this.panel1.Controls.Add(this.logOutText);
            this.panel1.Controls.Add(this.addOffenseIcon);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.offenseRecIcon);
            this.panel1.Controls.Add(this.homeIcon);
            this.panel1.Controls.Add(this.addOffenseButton);
            this.panel1.Controls.Add(this.offenseRecButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(-13, -27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 677);
            this.panel1.TabIndex = 4;
            // 
            // logOutText
            // 
            this.logOutText.AutoSize = true;
            this.logOutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutText.Location = new System.Drawing.Point(74, 638);
            this.logOutText.Name = "logOutText";
            this.logOutText.Size = new System.Drawing.Size(66, 20);
            this.logOutText.TabIndex = 5;
            this.logOutText.Text = "Log Out";
            this.logOutText.Click += new System.EventHandler(this.logOutText_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(13, 361);
            this.userButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(186, 46);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "User Mangement";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // addOffenseButton
            // 
            this.addOffenseButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addOffenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOffenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOffenseButton.Location = new System.Drawing.Point(13, 302);
            this.addOffenseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addOffenseButton.Name = "addOffenseButton";
            this.addOffenseButton.Size = new System.Drawing.Size(186, 46);
            this.addOffenseButton.TabIndex = 3;
            this.addOffenseButton.Text = "Add Offense";
            this.addOffenseButton.UseVisualStyleBackColor = false;
            this.addOffenseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // offenseRecButton
            // 
            this.offenseRecButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.offenseRecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offenseRecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenseRecButton.Location = new System.Drawing.Point(13, 240);
            this.offenseRecButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.offenseRecButton.Name = "offenseRecButton";
            this.offenseRecButton.Size = new System.Drawing.Size(186, 46);
            this.offenseRecButton.TabIndex = 2;
            this.offenseRecButton.Text = "Offense Record";
            this.offenseRecButton.UseVisualStyleBackColor = false;
            this.offenseRecButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(13, 177);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(186, 46);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userManagementIcon
            // 
            this.userManagementIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userManagementIcon.Image = global::StudentViolationSystem.Properties.Resources.user_management_icon;
            this.userManagementIcon.Location = new System.Drawing.Point(19, 372);
            this.userManagementIcon.Name = "userManagementIcon";
            this.userManagementIcon.Size = new System.Drawing.Size(35, 24);
            this.userManagementIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userManagementIcon.TabIndex = 13;
            this.userManagementIcon.TabStop = false;
            // 
            // addOffenseIcon
            // 
            this.addOffenseIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addOffenseIcon.Image = global::StudentViolationSystem.Properties.Resources.add_offense_icon__1_;
            this.addOffenseIcon.Location = new System.Drawing.Point(19, 314);
            this.addOffenseIcon.Name = "addOffenseIcon";
            this.addOffenseIcon.Size = new System.Drawing.Size(35, 24);
            this.addOffenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addOffenseIcon.TabIndex = 12;
            this.addOffenseIcon.TabStop = false;
            // 
            // offenseRecIcon
            // 
            this.offenseRecIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.offenseRecIcon.Image = global::StudentViolationSystem.Properties.Resources.offense_record_icon;
            this.offenseRecIcon.Location = new System.Drawing.Point(19, 253);
            this.offenseRecIcon.Name = "offenseRecIcon";
            this.offenseRecIcon.Size = new System.Drawing.Size(35, 24);
            this.offenseRecIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offenseRecIcon.TabIndex = 11;
            this.offenseRecIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homeIcon.Image = global::StudentViolationSystem.Properties.Resources.home_icon__1_;
            this.homeIcon.Location = new System.Drawing.Point(18, 188);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(35, 24);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 10;
            this.homeIcon.TabStop = false;
            // 
            // offenseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.offenseRecLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "offenseRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "offenseRecord";
            this.Load += new System.EventHandler(this.offenseRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagementIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addOffenseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offenseRecIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label offenseRecLabel;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button addOffenseButton;
        private System.Windows.Forms.Button offenseRecButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label logOutText;
        private System.Windows.Forms.PictureBox userManagementIcon;
        private System.Windows.Forms.PictureBox addOffenseIcon;
        private System.Windows.Forms.PictureBox offenseRecIcon;
        private System.Windows.Forms.PictureBox homeIcon;
    }
}