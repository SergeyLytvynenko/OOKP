using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;database=ookp;password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //INSERT
            //string query = "INSERT INTO students (student_name,avg_rating) VALUES ('Kate', 38);";

            //UPDATE
            //string query = "UPDATE students SET student_name = 'Alexandr' WHERE id = 2";

            // DELETE
            string query = "DELETE FROM students WHERE id = 3";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }

}