namespace StudentViolationSystem
{
    partial class studentView
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
            this.schoolNameLbl = new System.Windows.Forms.Label();
            this.studNumText = new System.Windows.Forms.Label();
            this.studNameText = new System.Windows.Forms.Label();
            this.gradeLvlText = new System.Windows.Forms.Label();
            this.sectionText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOutText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.logOutText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.schoolNameLbl);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 71);
            this.panel1.TabIndex = 0;
            // 
            // schoolNameLbl
            // 
            this.schoolNameLbl.AutoSize = true;
            this.schoolNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolNameLbl.Location = new System.Drawing.Point(89, 24);
            this.schoolNameLbl.Name = "schoolNameLbl";
            this.schoolNameLbl.Size = new System.Drawing.Size(345, 25);
            this.schoolNameLbl.TabIndex = 0;
            this.schoolNameLbl.Text = "Highlands National High School";
            this.schoolNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // studNumText
            // 
            this.studNumText.AutoSize = true;
            this.studNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNumText.Location = new System.Drawing.Point(71, 109);
            this.studNumText.Name = "studNumText";
            this.studNumText.Size = new System.Drawing.Size(100, 24);
            this.studNumText.TabIndex = 1;
            this.studNumText.Text = "202500567";
            // 
            // studNameText
            // 
            this.studNameText.AutoSize = true;
            this.studNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNameText.Location = new System.Drawing.Point(70, 133);
            this.studNameText.Name = "studNameText";
            this.studNameText.Size = new System.Drawing.Size(215, 24);
            this.studNameText.TabIndex = 2;
            this.studNameText.Text = "DELA CRUZ, JUAN A.";
            // 
            // gradeLvlText
            // 
            this.gradeLvlText.AutoSize = true;
            this.gradeLvlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLvlText.Location = new System.Drawing.Point(75, 157);
            this.gradeLvlText.Name = "gradeLvlText";
            this.gradeLvlText.Size = new System.Drawing.Size(31, 20);
            this.gradeLvlText.TabIndex = 3;
            this.gradeLvlText.Text = "7 - ";
            // 
            // sectionText
            // 
            this.sectionText.AutoSize = true;
            this.sectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionText.Location = new System.Drawing.Point(110, 157);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(20, 20);
            this.sectionText.TabIndex = 4;
            this.sectionText.Text = "A";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(70, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 392);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentViolationSystem.Properties.Resources.school_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logOutText
            // 
            this.logOutText.AutoSize = true;
            this.logOutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutText.Location = new System.Drawing.Point(953, 24);
            this.logOutText.Name = "logOutText";
            this.logOutText.Size = new System.Drawing.Size(63, 20);
            this.logOutText.TabIndex = 7;
            this.logOutText.Text = "Log out";
            this.logOutText.Click += new System.EventHandler(this.logOutText_Click);
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sectionText);
            this.Controls.Add(this.gradeLvlText);
            this.Controls.Add(this.studNameText);
            this.Controls.Add(this.studNumText);
            this.Controls.Add(this.panel1);
            this.Name = "studentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label schoolNameLbl;
        private System.Windows.Forms.Label studNumText;
        private System.Windows.Forms.Label studNameText;
        private System.Windows.Forms.Label gradeLvlText;
        private System.Windows.Forms.Label sectionText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logOutText;
    }
}