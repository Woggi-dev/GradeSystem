using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeSystem.scripts
{
    class Database
    {
        static void Main()
        {
            // Строка подключения
            string connectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

            // Создание объекта SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Открытие подключения
                    connection.Open();
                    Console.WriteLine("Подключение открыто");

                    // Здесь вы можете выполнять операции с базой данных

                    // Пример выполнения SQL-запроса
                    string sqlQuery = "SELECT * FROM YourTable";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Обработка данных из результата запроса
                                Console.WriteLine(reader["ColumnName"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                finally
                {
                    // Закрытие подключения в блоке finally для обеспечения корректного закрытия даже в случае исключения
                    connection.Close();
                    Console.WriteLine("Подключение закрыто");
                }
            }
        }
    }
}
