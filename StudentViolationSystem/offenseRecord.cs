using MySql.Data.MySqlClient;
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
    public partial class offenseRecord : Form
    {
        //private object conn;

        public offenseRecord()
        {
            InitializeComponent();
            searchField.Text = "Search";
            searchField.ForeColor = Color.Black;

            this.ActiveControl = offenseRecLabel;

            OffenseRecordTable();
        }

        private void OffenseRecordTable()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            v.date AS 'Date',
                            s.student_id AS 'Student ID',
                            s.name AS 'Name',
                            s.year_level AS 'Year Level',
                            s.section AS 'Section',
                            o.offense_name AS 'Offense Name',
                            o.category AS 'Category',
                            o.default_action AS 'Action Taken'
                       
                        FROM studentinfo s
                        INNER JOIN violations v ON s.student_id = v.student_id
                        INNER JOIN offenses o ON v.offense_id = o.offense_id";



                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    offenseRecDataGridView.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Failed to load student records.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (searchField.Text == "Search")
            {
                searchField.Text = "";
                searchField.ForeColor = Color.Black;
            }
        }

        private void searchField_Leave(object sender, EventArgs e)
        {
            if (searchField.Text == "")
            {
                searchField.Text = "Search";
                searchField.ForeColor = Color.  Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage newform = new homePage();
            newform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }

        private void offenseRecord_Load(object sender, EventArgs e)
        {

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
    }
}
