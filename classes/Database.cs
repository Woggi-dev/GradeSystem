using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem.scripts
{
    public class Database
    {
        private static string connectionString;

        public Database()
        {
            connectionString = @"Data Source=DESKTOP-O4H69NN\SQLEXPRESS;Initial Catalog=Grade_System;Integrated Security=True";
        }

        // Open a connection and return it
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connection is successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
            }

            return connection;
        }

        public static bool SelectData(string queryString)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                    return false;

                SqlCommand command = new SqlCommand(queryString, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            return table.Rows.Count > 0;
        }

        // Insert or update data in the database
        public static bool PerformSqlQuery(string queryString)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                    return false;

                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

    }
}
