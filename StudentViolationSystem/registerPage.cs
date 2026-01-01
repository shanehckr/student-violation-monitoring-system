using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            fNameField.Text = "First Name";
            fNameField.ForeColor = Color.LightGray;

            initialField.Text = "Middle Initial";
            initialField.ForeColor = Color.LightGray;

            userField.Text = "Username";
            userField.ForeColor = Color.LightGray;

            passField.Text = "Password";
            passField.ForeColor = Color.LightGray;

            confirmPassField.Text = "Confirm Password";
            confirmPassField.ForeColor = Color.LightGray;

            studentIdField.Text = "Student ID";
            studentIdField.ForeColor = Color.LightGray;

            emailField.Text = "Email";
            emailField.ForeColor = Color.LightGray;


            this.ActiveControl = registerLbl;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2")); 
                return builder.ToString();
            }
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
            if (fNameField.Text == "First Name")
            {
                fNameField.Text = "";
                fNameField.ForeColor = Color.Black;
            }
        }

        private void FnameField_Leave(object sender, EventArgs e)
        {
            if (fNameField.Text == "")
            {
                fNameField.Text = "First Name";
                fNameField.ForeColor = Color.LightGray;
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
                initialField.Text = "Middle Initial";
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Get input values
            string surname = surnameField.Text.Trim();
            string firstName = fNameField.Text.Trim();
            string middleInitial = initialField.Text.Trim();
            string username = userField.Text.Trim();
            string studentId = studentIdField.Text.Trim();
            string email = emailField.Text.Trim();
            string password = passField.Text.Trim();
            string confirmPassword = confirmPassField.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(studentId) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string fullName = string.IsNullOrEmpty(middleInitial)
                ? $"{surname}, {firstName}"
                : $"{surname}, {firstName} {middleInitial.ToUpper()}.";

            string hashedPassword = HashPassword(password);

          
            string role = "student";

            string connString = "Server=localhost;Database=student_violation_monitoring_system_db;Uid=root;Pwd=;";

            
            string query = @"
                INSERT INTO studentinfo (student_id, NAME, username, email, password, role)
                VALUES (@student_id, @name, @username, @email, @password, @role)";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_id", studentId);
                        cmd.Parameters.AddWithValue("@name", fullName);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", role);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating account: " + ex.Message);
                }
            }
        }

        private void studentIdField_Enter(object sender, EventArgs e)
        {
            if (studentIdField.Text == "Student ID")
            {
                studentIdField.Text = "";
                studentIdField.ForeColor = Color.Black;
            }
        }

        private void studentIdField_Leave(object sender, EventArgs e)
        {
            if (studentIdField.Text == "")
            {
                studentIdField.Text = "Student ID";
                studentIdField.ForeColor = Color.LightGray;
            }
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Email")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {
                emailField.Text = "Email";
                emailField.ForeColor = Color.LightGray;
            }
        }
    }
}





