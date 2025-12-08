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

namespace StudentViolationMonitoringSystem.AdminHomePage
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

     private void LoadStudentRecords()
    {
        using (MySqlConnection conn = Database.GetConnection())
        {
            try
            {
                conn.Open();

                    string query = @"SELECT
                                   s.student_id AS 'Student ID', 
                                   s.name AS 'Full Name',
                                   s.section AS 'Section', 
                                   s.year_level AS 'Year Level', 
                                   o.offense_name AS 'Offense',
                                   o.category AS 'Category', 
                                   o.default_action AS 'Action Taken'
                                   FROM StudentInfo s
                                    CROSS JOIN Offenses o";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvStudentInfo.DataSource = table;
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
        }
    }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }
    }
}
