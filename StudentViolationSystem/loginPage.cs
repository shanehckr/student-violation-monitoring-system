using MySql.Data.MySqlClient;
using System.Security.Cryptography;
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userInput = userField.Text.Trim(); // Username or email
            string password = passField.Text.Trim();

            // Hash the input password
            string passwordHash = HashPassword(password);

            string connString = "Server=localhost;Database=student_violation_monitoring_system_db;Uid=root;Pwd=0ms2026System;";

            string query = @"
                    SELECT role, email 
                    FROM studentinfo 
                    WHERE (username = @userInput OR email = @userInput) 
                    AND password = @passwordHash
                    LIMIT 1";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userInput", userInput);
                        cmd.Parameters.AddWithValue("@passwordHash", passwordHash);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                string email = reader["email"].ToString(); 

                                if (role == "admin")
                                {
                                    homePage form = new homePage();
                                    form.Show();
                                    this.Hide();
                                }
                                else if (role == "student")
                                {
                                    studentView form = new studentView();
                                    form.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Unrecognized role.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username/email or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
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
       

    private void userField_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
