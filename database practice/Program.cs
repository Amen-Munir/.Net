using DataBaseConnectivityPractice.models;
using System;
using System.Data.SqlClient;

namespace DataBaseConnectivityPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new user object
            user o = new user();
            o.Name= "test";
            o.Password= "password";

            try
            {
                // Define the connection string
                string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Assignment01;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                // Create and open the connection
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();

                    // Define the parameterized SQL query
                    string query = "INSERT INTO users (name, password) VALUES (@name, @password)";

                    // Create the SQL command with the parameterized query
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters (ensure parameter names match the query exactly)
                        cmd.Parameters.AddWithValue("@name", o.Name);
                        cmd.Parameters.AddWithValue("@password", o.Password);

                        // Execute the command
                        int num = cmd.ExecuteNonQuery();

                        // Check if any rows were affected and print result
                        if (num > 0)
                        {
                            Console.WriteLine($"{num} row(s) affected.");
                        }
                        else
                        {
                            Console.WriteLine("No rows were affected.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }
    }
}
