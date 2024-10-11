using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email=emailTextBox.Text;
            string password = passwordBox.Password;
            if(email.EndsWith("@gmail.com"))
            {
                try
                {
                    string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Project01;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        con.Open();
                        string query = "SELECT COUNT(*) FROM dbo.admin WHERE email= @Email AND password=@pass";
                        SqlCommand cmd =new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@pass", password);
                        int count = (int)cmd.ExecuteScalar();

                        if(count==1)
                        {
                            MessageBox.Show("Successfull");
                        }
                        else
                        {
                            MessageBox.Show("OOPS");
                        }
                        con.Close();
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
    {
        // If the email domain is incorrect, show an error message
        MessageBox.Show("Invalid email domain. Only @gmail.com accounts are allowed.", "Invalid Email", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
        }
    }
}
