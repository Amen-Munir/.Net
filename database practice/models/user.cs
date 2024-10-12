using Microsoft.SqlServer.Server;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnectivityPractice.models
{
    public class user
    {
        private string name;
        private string password;
        private string v1;
        private string v2;

        
        public string Name
        {
            get { return name; }
            set
            {

                name = value;
            }
        }
        public string Password { get { return password; } set { password = value; } }

    }
}
