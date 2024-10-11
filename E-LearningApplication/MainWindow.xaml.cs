using Login.models;
using System.Data.SqlTypes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;


namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin ad = new admin
            {
                Username = usernameTextBox.Text,
                Password = passwordBox.Password,
                Email = emailTextBox.Text
            };

            try
            {
                string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Project01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;";


                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    string query = "INSERT into dbo.admin(email,username,password) Values(@Email, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar) { Value = ad.Email });
                        cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar) { Value = ad.Username });
                        cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar) { Value = ad.Password });

                        int num = cmd.ExecuteNonQuery();
                        if (num > 0)
                        {
                            MessageBox.Show($"{num} row(s) inserted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Insert failed.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)  
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window1 loginWindow = new Window1();

             
            loginWindow.Show();

            
            this.Close();

        }
    }
}