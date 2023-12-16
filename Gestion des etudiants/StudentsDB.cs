using System.Data;
using MySql.Data.MySqlClient;

namespace Gestion_des_etudiants
{
    public class StudentsDB
    {
        MySqlConnection connection;

        public StudentsDB() {
            InitialiseDBConnection();
        }

        public void InitialiseDBConnection()
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=students;User ID=root;Password=root";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connection opened successfully.");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error opening the connection: " + e.Message);
            }
        }

        public void AddStudent(int code, string nom, string prenom, string filiere)
        {
            try
            {
                string sql = "INSERT INTO students (Code,Nom,Prenom,Filiere) VALUES (@Code,@Nom,@Prenom,@Filiere)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add(new MySqlParameter("@Code", MySqlDbType.Int16, 255)).Value = code;
                command.Parameters.Add(new MySqlParameter("@Nom", MySqlDbType.VarChar)).Value = nom;
                command.Parameters.Add(new MySqlParameter("@Prenom", MySqlDbType.VarChar, 50)).Value = prenom;
                command.Parameters.Add(new MySqlParameter("@Filiere", MySqlDbType.VarChar, 50)).Value = filiere;

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Student added successfully.");
                    MessageBox.Show("Student added successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to add the student.");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error adding the student: " + e.Message);
            }
        }

        public DataTable GetStudentList()
        {
            DataTable table = new DataTable();
            try
            {
                string query = "SELECT * FROM students";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error adding the student: " + e.Message);
            }

            return table;
        }

        public void DeleteStudent(int code)
        {
            try
            {
                string sql = "DELETE FROM students WHERE Code = @Code";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add(new MySqlParameter("@Code", MySqlDbType.Int16)).Value = code;

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Student deleted successfully.");
                    MessageBox.Show("Student deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to delete the student.");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error deleting the student: " + e.Message);
            }
        }

        public void UpdateStudent(int code, string nom, string prenom, string filiere)
        {
            try
            {
                string sql = "UPDATE students SET Nom = @Nom, Prenom = @Prenom, Filiere = @Filiere WHERE Code = @Code";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add(new MySqlParameter("@Code", MySqlDbType.Int16)).Value = code;
                command.Parameters.Add(new MySqlParameter("@Nom", MySqlDbType.VarChar)).Value = nom;
                command.Parameters.Add(new MySqlParameter("@Prenom", MySqlDbType.VarChar, 50)).Value = prenom;
                command.Parameters.Add(new MySqlParameter("@Filiere", MySqlDbType.VarChar, 50)).Value = filiere;

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Student updated successfully.");
                    MessageBox.Show("Student updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update the student.");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error updating the student: " + e.Message);
            }
        }

        public DataRow GetFirstStudent()
        {
            DataTable table = new DataTable();

            try
            {
                string query = "SELECT * FROM students ORDER BY Code LIMIT 1";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return table.Rows[0]; // Return the first student's data
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error getting the first student: " + e.Message);
            }

            return null;
        }

        public DataRow GetPreviousStudent(int Code)
        {
            DataTable table = new DataTable();

            try
            {
                string query = "SELECT * FROM students WHERE Code < @CurrentCode ORDER BY Code DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.Add(new MySqlParameter("@CurrentCode", MySqlDbType.Int16)).Value = Code;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return table.Rows[0]; // Return the previous student's data
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error getting the previous student: " + e.Message);
            }

            return null;
        }

        public DataRow GetNextStudent(int Code)
        {
            DataTable table = new DataTable();

            try
            {
                string query = "SELECT * FROM students WHERE Code > @CurrentCode ORDER BY Code DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.Add(new MySqlParameter("@CurrentCode", MySqlDbType.Int16)).Value = Code;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return table.Rows[0]; // Return the next student's data
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error getting the next student: " + e.Message);
            }

            return null;
        }

        public DataRow GetLastStudent()
        {
            DataTable table = new DataTable();

            try
            {
                string query = "SELECT * FROM students ORDER BY Code DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return table.Rows[0]; // Return the last student's data
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error getting the last student: " + e.Message);
            }

            return null;
        }

        public DataRow GetStudent(int code)
        {
            DataTable table = new DataTable();

            try
            {
                string query = "SELECT * FROM students WHERE Code = @Code";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.Add(new MySqlParameter("@Code", MySqlDbType.Int16)).Value = code;

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return table.Rows[0]; // Return the student's data
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error getting the student: " + e.Message);
            }

            return null;
        }


    }

}
