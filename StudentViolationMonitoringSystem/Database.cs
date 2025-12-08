using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentViolationMonitoringSystem
{
    internal class Database
    {
        private static string connStr = "server=localhost;user=root;database=student_violation_monitoring_system_db;port=3306;password=0ms2026System;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
