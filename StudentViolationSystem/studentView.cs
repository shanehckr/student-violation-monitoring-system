using System;
using MySql.Data.MySqlClient;
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
    public partial class studentView : Form
    {
        public studentView()
        {
            InitializeComponent();
            StudentViewData();
        }



        private void StudentViewData()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT
                        v.date AS 'Date',
                        o.offense_name AS 'Offense',
                        o.category AS 'Category',
                        o.default_action AS 'Action Taken'

                   FROM StudentInfo s
                   INNER JOIN violations v ON s.student_id = v.student_id
                   INNER JOIN offenses o ON v.offense_id = o.offense_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    studentDataGridView.DataSource = table;
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




        private void label1_Click(object sender, EventArgs e)
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
    }
}
