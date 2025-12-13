using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentViolationSystem
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();

            userField.Text = "Username";
            userField.ForeColor = Color.LightGray;

            passField.Text = "Password";
            passField.ForeColor = Color.LightGray;

            this.ActiveControl = schoolNameLbl;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            RegisterPage newForm = new RegisterPage();
            newForm.Show();
        }

        private void userField_Enter(object sender, EventArgs e)
        {
            if (userField.Text == "Username")
            {
                userField.Text = "";
                userField.ForeColor = Color.Black;
            }
        }

        private void userField_Leave(object sender, EventArgs e)
        {
            if (userField.Text == "")
            {
                userField.Text = "Username";
                userField.ForeColor = Color.LightGray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Password")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Password";
                passField.ForeColor = Color.LightGray;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userField.Text == "admin" && passField.Text == "pass")
            {
                homePage form = new homePage();
                form.Show();
                this.Hide();
            } else if (userField.Text == "cess" && passField.Text == "pass")
            {
                studentView newform = new studentView();
                newform.Show();
                this.Hide();
            }
            
        }

        private void userField_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
