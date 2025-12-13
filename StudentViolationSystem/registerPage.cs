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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();

            surnameField.Text = "Surname";
            surnameField.ForeColor = Color.LightGray;

            FnameField.Text = "First Name";
            FnameField.ForeColor = Color.LightGray;

            initialField.Text = "MIddle Initial";
            initialField.ForeColor = Color.LightGray;

            userField.Text = "Username";
            userField.ForeColor = Color.LightGray;

            passField.Text = "Password";
            passField.ForeColor = Color.LightGray;

            confirmPassField.Text = "Confirm Password";
            confirmPassField.ForeColor = Color.LightGray;

            this.ActiveControl = registerLbl;
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text == "Surname")
            {
                surnameField.Text = "";
                surnameField.ForeColor = Color.Black;
            }
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text == "")
            {
                surnameField.Text = "Surname";
                surnameField.ForeColor = Color.LightGray;
            }
        }

        private void FnameField_Enter(object sender, EventArgs e)
        {
            if (FnameField.Text == "First Name")
            {
                FnameField.Text = "";
                FnameField.ForeColor = Color.Black;
            }
        }

        private void FnameField_Leave(object sender, EventArgs e)
        {
            if (FnameField.Text == "")
            {
                FnameField.Text = "First Name";
                FnameField.ForeColor = Color.LightGray;
            }
        }

        private void initialField_Enter(object sender, EventArgs e)
        {
            if (initialField.Text == "Middle Initial")
            {
                initialField.Text = "";
                initialField.ForeColor = Color.Black;
            }
        }

        private void initialField_Leave(object sender, EventArgs e)
        {
            if (initialField.Text == "")
            {
                initialField.Text = "Middile Initial";
                initialField.ForeColor = Color.LightGray;
            }
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

        private void confirmPassField_Enter(object sender, EventArgs e)
        {
            if (confirmPassField.Text == "Confirm Password")
            {
                confirmPassField.Text = "";
                confirmPassField.ForeColor = Color.Black;
            }
        }

        private void confirmPassField_Leave(object sender, EventArgs e)
        {
            if (confirmPassField.Text == "")
            {
                confirmPassField.Text = "Confirm Password";
                confirmPassField.ForeColor = Color.LightGray;
            }
        }

        private void RegisterPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
