using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static Mysqlx.Notice.Warning.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace StudentViolationSystem
{
    public partial class addOffense : Form
    {
        public addOffense()
        {
            this.ActiveControl = studInfoTxt;
            InitializeComponent();

            studNameCb.DropDownStyle = ComboBoxStyle.DropDown; // allows typing
            studNameCb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studNameCb.AutoCompleteSource = AutoCompleteSource.ListItems;

            studIdTxtField.ReadOnly = true;
            secTxtField.ReadOnly = true;
            yearLvlTxtField.ReadOnly = true;
            actionTakenTxtField.ReadOnly = true;

            offenseClassCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            offenseTitleCombo.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage newform = new homePage();
            newform.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            offenseRecord newform = new offenseRecord();
            newform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addOffense newform = new addOffense();
            newform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userManagementPage form = new userManagementPage();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addOffense_Load(object sender, EventArgs e)
        {
            LoadStudentNames();
            LoadOffenseClassification();


        }

        private void logOutText_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                loginPage newform = new loginPage();
                newform.Show();
                this.Hide();
            }
        }

        private void homeNav_Click(object sender, EventArgs e)
        {
            homePage home = new homePage();
            home.Show();
            this.Hide();
        }

        private void offenseRecNav_Click(object sender, EventArgs e)
        {
            offenseRecord offenseRec = new offenseRecord();
            offenseRec.Show();
            this.Hide();
        }

        private void addOffenseNav_Click(object sender, EventArgs e)
        {
            addOffense addOff = new addOffense();
            addOff.Show();
            this.Hide();
        }

        private void userManagementNav_Click(object sender, EventArgs e)
        {
            userManagementPage userMan = new userManagementPage();
            userMan.Show();
            this.Hide();
        }


        private void LoadStudentNames()
        {
            studNameCb.Items.Clear();

            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name FROM studentinfo ORDER BY name ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        studNameCb.Items.Add(reader["name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student names: " + ex.Message);
                }
            }
        }

        private void SaveYearLevelToDb(string selectedYear, int studentId)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE studentinfo SET year_level = @year";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@year", selectedYear);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving year level: " + ex.Message);
                }
            }
        }

        private void SaveSectionToDb(string selectedSection, int studentId)
        {
            string connString = "Server=localhost;Database=student_violation_monitoring_system_db;Uid=root;Pwd=0ms2026System;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE studentinfo 
                             SET section = @section 
                             WHERE student_id = @studentId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@section", selectedSection);
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0
                            ? "Section saved successfully!"
                            : "No record updated. Check student ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_violation_monitoring_system_db;Uid=root;Pwd=;";
            
            if (studNameCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student!");
                return;
            }

            if (string.IsNullOrWhiteSpace(studIdTxtField.Text) ||
                string.IsNullOrWhiteSpace(yearLvlTxtField.Text) ||
                string.IsNullOrWhiteSpace(secTxtField.Text))
            {
                MessageBox.Show("Student information is incomplete!");
                return;
            }

           
            if (!int.TryParse(studIdTxtField.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID!");
                return;
            }

            string yearLevel = yearLvlTxtField.Text;
            string section = secTxtField.Text;

       
            SaveYearLevelToDb(yearLevel, studentId);
            SaveSectionToDb(section, studentId);

    
            if (offenseTitleCombo.SelectedItem != null)
            {
                string offenseName = offenseTitleCombo.SelectedItem.ToString();
                DateTime violationDate = dateTimePicker.Value;

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        // Get offense_id from offense name
                        string offenseQuery = "SELECT offense_id FROM offenses WHERE offense_name=@offenseName";
                        MySqlCommand offenseCmd = new MySqlCommand(offenseQuery, conn);
                        offenseCmd.Parameters.AddWithValue("@offenseName", offenseName);
                        object offenseIdObj = offenseCmd.ExecuteScalar();

                        if (offenseIdObj != null)
                        {
                            int offenseId = Convert.ToInt32(offenseIdObj);

                            // Insert into studentinfo table
                            string insertQuery = @"
                        INSERT INTO violations (student_id, offense_id, date, year_level, section)
                        VALUES (@studentId, @offenseId, @date,@yearLevel,@section )";
                            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                            insertCmd.Parameters.AddWithValue("@studentId", studentId);
                            insertCmd.Parameters.AddWithValue("@offenseId", offenseId);
                            insertCmd.Parameters.AddWithValue("@date", violationDate);
                            insertCmd.Parameters.AddWithValue("@yearLevel", yearLevel);
                            insertCmd.Parameters.AddWithValue("@section", section);

                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Student record and offense saved successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Offense not found in the database.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving offense: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Student record updated successfully!");
            }
        }

        private void studNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studNameCb.SelectedItem != null)
            {
                string selectedName = studNameCb.SelectedItem.ToString();
                FillStudentDetails(selectedName);
            }
        }

        private void FillStudentDetails(string name)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT student_id, section, year_level FROM studentinfo WHERE name = @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        studIdTxtField.Text = reader["student_id"].ToString();
                        yearLvlTxtField.Text = reader["year_level"].ToString();
                        secTxtField.Text = reader["section"].ToString();
                        }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching student details: " + ex.Message);
                }
            }
        }

        private void LoadOffenseClassification()
        {
            offenseClassCombo.Items.Clear();
            offenseClassCombo.Items.Add("Major");
            offenseClassCombo.Items.Add("Minor");
        }

        private void LoadOffenseClassification(string offenseClass)
        {
            offenseTitleCombo.Items.Clear();

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT offense_name FROM offenses WHERE category=@category";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@category", offenseClass);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    offenseTitleCombo.Items.Add(reader.GetString("offense_name"));
                }
            }
        }
    

        private void OffenseClassificationToDb(string selectedOffenseClassification, int studentId)
        {
            string connString = "Server=localhost;Database=student_violation_monitoring_system_db;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE violations 
                             SET category = @category 
                             WHERE student_id = @studentId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedOffenseClassification);
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0
                            ? "Offense Classification saved successfully!"
                            : "No record updated. Check student ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void offenseClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (offenseClassCombo.SelectedItem != null)
            {
                string selectedClass = offenseClassCombo.SelectedItem.ToString();
                LoadOffenseClassification(selectedClass);
            }
        }

        private void offenseTitleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=student_violation_monitoring_system_db;Uid=root;Pwd=;";

            if (offenseTitleCombo.SelectedItem != null)
            {
                string selectedOffense = offenseTitleCombo.SelectedItem.ToString();
                using (MySqlConnection conn = new MySqlConnection (connString))
                {
                    conn.Open();
                    string query = "SELECT default_action FROM offenses WHERE offense_name=@offenseName";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@offenseName", selectedOffense);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        actionTakenTxtField.Text = result.ToString(); 
                    }
                }
            }
        }

        private void homeNav_Click_1(object sender, EventArgs e)
        {
            homePage home = new homePage();
            home.Show();
            this.Hide();
        }

        private void offenseRecNav_Click_1(object sender, EventArgs e)
        {
            offenseRecord record = new offenseRecord();
            record.Show();
            this.Hide();
        }

        private void userManagementNav_Click_1(object sender, EventArgs e)
        {
            userManagementPage usuer = new userManagementPage();
            usuer.Show();
            this.Hide();
        }

        private void logOutNav_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                loginPage form = new loginPage();
                form.Show();
                this.Hide();
            }
        }

        private void yearLvlTxtField_TextChanged(object sender, EventArgs e)
        {

        }

        private void studIdTxtField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





