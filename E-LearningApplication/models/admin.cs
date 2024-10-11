using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Login.models
{
    public class admin
    {
        private string email;
        private string password;
        private string username;
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                { email = value; }
                else { Console.WriteLine("Inavlid email");
                }
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }

        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

           
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
