using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<user> lst_backend = new ObservableCollection<user>();
        public MainWindow()
        {
            InitializeComponent();
            lst_backend.Add(new user("haiqa", "abs"));
            lst_backend.Add(new user("waleed", "abs"));
            lst_backend.Add(new user("ibrahim", "abs"));
            lst_frontend.ItemsSource = lst_backend;

        }

        private void btn_adduser_Click(object sender, RoutedEventArgs e)
        {
            lst_backend.Add(new user(Name = "amen", "abc"));

        }

        private void btn_deleteuser_Click(object sender, RoutedEventArgs e)
        {
            if (lst_frontend.SelectedItem != null)
            {
                lst_backend.Remove(lst_frontend.SelectedItem as user);
            }

        }

        private void btn_updateuser_Click(object sender, RoutedEventArgs e)
        {
            if (lst_frontend.SelectedItem != null)
            {
                (lst_frontend.SelectedItem as user).Name = "absss";


            }
        }
    }
}
