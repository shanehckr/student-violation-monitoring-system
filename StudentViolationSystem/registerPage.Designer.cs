namespace StudentViolationSystem
{
    partial class RegisterPage
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
            this.registerLbl = new System.Windows.Forms.Label();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.initialField = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.FnameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.registerLbl);
            this.panel1.Controls.Add(this.confirmPassField);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.userField);
            this.panel1.Controls.Add(this.initialField);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.FnameField);
            this.panel1.Controls.Add(this.surnameField);
            this.panel1.Location = new System.Drawing.Point(279, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 468);
            this.panel1.TabIndex = 1;
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.Location = new System.Drawing.Point(173, 37);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(124, 31);
            this.registerLbl.TabIndex = 7;
            this.registerLbl.Text = "Register";
            // 
            // confirmPassField
            // 
            this.confirmPassField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassField.Location = new System.Drawing.Point(29, 313);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(433, 29);
            this.confirmPassField.TabIndex = 6;
            this.confirmPassField.Enter += new System.EventHandler(this.confirmPassField_Enter);
            this.confirmPassField.Leave += new System.EventHandler(this.confirmPassField_Leave);
            // 
            // passField
            // 
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(29, 269);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(433, 29);
            this.passField.TabIndex = 5;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // userField
            // 
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(29, 230);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(433, 29);
            this.userField.TabIndex = 4;
            this.userField.Enter += new System.EventHandler(this.userField_Enter);
            this.userField.Leave += new System.EventHandler(this.userField_Leave);
            // 
            // initialField
            // 
            this.initialField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialField.Location = new System.Drawing.Point(29, 186);
            this.initialField.Name = "initialField";
            this.initialField.Size = new System.Drawing.Size(433, 29);
            this.initialField.TabIndex = 3;
            this.initialField.Enter += new System.EventHandler(this.initialField_Enter);
            this.initialField.Leave += new System.EventHandler(this.initialField_Leave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(163, 379);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(166, 41);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // FnameField
            // 
            this.FnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameField.Location = new System.Drawing.Point(29, 143);
            this.FnameField.Name = "FnameField";
            this.FnameField.Size = new System.Drawing.Size(433, 29);
            this.FnameField.TabIndex = 1;
            this.FnameField.Enter += new System.EventHandler(this.FnameField_Enter);
            this.FnameField.Leave += new System.EventHandler(this.FnameField_Leave);
            // 
            // surnameField
            // 
            this.surnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameField.Location = new System.Drawing.Point(29, 99);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(433, 29);
            this.surnameField.TabIndex = 0;
            this.surnameField.TextChanged += new System.EventHandler(this.RegisterPage_Load);
            this.surnameField.Enter += new System.EventHandler(this.surnameField_Enter);
            this.surnameField.Leave += new System.EventHandler(this.surnameField_Leave);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 644);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegisterPage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox initialField;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox FnameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label registerLbl;
    }
}