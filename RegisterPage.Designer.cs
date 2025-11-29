namespace WindowsFormsApp1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Register = new System.Windows.Forms.Label();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.initialField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fnameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Register);
            this.panel2.Controls.Add(this.confirmPassField);
            this.panel2.Controls.Add(this.passField);
            this.panel2.Controls.Add(this.userField);
            this.panel2.Controls.Add(this.initialField);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.fnameField);
            this.panel2.Controls.Add(this.surnameField);
            this.panel2.Location = new System.Drawing.Point(444, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 574);
            this.panel2.TabIndex = 2;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(187, 71);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(152, 39);
            this.Register.TabIndex = 8;
            this.Register.Text = "Register";
            // 
            // confirmPassField
            // 
            this.confirmPassField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPassField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassField.Location = new System.Drawing.Point(91, 404);
            this.confirmPassField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(371, 30);
            this.confirmPassField.TabIndex = 7;
            this.confirmPassField.TabStop = false;
            this.confirmPassField.Enter += new System.EventHandler(this.confirmPassField_Enter);
            this.confirmPassField.Leave += new System.EventHandler(this.confirmPassField_Leave);
            // 
            // passField
            // 
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(91, 353);
            this.passField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(371, 30);
            this.passField.TabIndex = 6;
            this.passField.TabStop = false;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // userField
            // 
            this.userField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(91, 297);
            this.userField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(371, 30);
            this.userField.TabIndex = 5;
            this.userField.TabStop = false;
            this.userField.Enter += new System.EventHandler(this.userField_Enter);
            this.userField.Leave += new System.EventHandler(this.userField_Leave);
            // 
            // initialField
            // 
            this.initialField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialField.Location = new System.Drawing.Point(91, 246);
            this.initialField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.initialField.Name = "initialField";
            this.initialField.Size = new System.Drawing.Size(371, 30);
            this.initialField.TabIndex = 4;
            this.initialField.TabStop = false;
            this.initialField.Enter += new System.EventHandler(this.initialField_Enter);
            this.initialField.Leave += new System.EventHandler(this.initialField_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fnameField
            // 
            this.fnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameField.Location = new System.Drawing.Point(91, 194);
            this.fnameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fnameField.Name = "fnameField";
            this.fnameField.Size = new System.Drawing.Size(371, 30);
            this.fnameField.TabIndex = 1;
            this.fnameField.TabStop = false;
            this.fnameField.Enter += new System.EventHandler(this.fnameField_Enter);
            this.fnameField.Leave += new System.EventHandler(this.fnameField_Leave);
            // 
            // surnameField
            // 
            this.surnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameField.Location = new System.Drawing.Point(91, 144);
            this.surnameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(371, 30);
            this.surnameField.TabIndex = 0;
            this.surnameField.TabStop = false;
            this.surnameField.Enter += new System.EventHandler(this.surnameField_Enter);
            this.surnameField.Leave += new System.EventHandler(this.surnameField_Leave);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fnameField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox initialField;
        private System.Windows.Forms.Label Register;
    }
}