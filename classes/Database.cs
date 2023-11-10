using System;
using Devart.Data.PostgreSql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem.scripts
{
    class Database
    {
        // An instance of class PgSqlConnection to connect Database
        PgSqlConnection conn;
        // An instance of class PgSqlCommand to perform SQL queries
        PgSqlCommand cmd;

        // The database state
        public string getmessage { get; set; }
        public Database()
        {
            // Connection string
            string cs = "User Id=postgres;Host=localhost;Database=postgres;Password=2881kolia228;Initial Schema=public";
            // Passing the connection string to PgSqlConnection class constructor
            conn = new PgSqlConnection(cs);
            cmd = new PgSqlCommand();
        }

        // Database connection
        public bool connect()
        {
            try
            {
                conn.Open();
                // Setting the state of database (success)
                getmessage = "Connect successfully";
                return true;
            }
            catch (Exception)
            {
                // Setting the state of database (fail)
                getmessage = "Unable to connect Connection Fail";
                return false;
            }
        }
    }
}
