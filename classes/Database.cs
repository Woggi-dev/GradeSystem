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
        public static void Connect()
        {
            // Строка подключения
            string sqlConnection = @"Data Source=DESKTOP-O4H69NN\SQLEXPRESS;Initial Catalog=Grade_System;Integrated Security=True";

            // Создание объекта SqlConnection
            using (SqlConnection connection = new SqlConnection(sqlConnection))
            {
                try
                {
                    // Открытие подключения
                    connection.Open();
                    Console.WriteLine("Подключение открыто");
                    connection.Close();
                    Console.WriteLine("Подключение закрыто");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
        
    }
}
