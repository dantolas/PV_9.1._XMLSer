using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
        public string name { get; set; }
        public string password { get; set; }
        
        public string email { get; set; }

        public int phoneNumber { get; set; }


        public User(string name, string password, string email, int phoneNumber)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }



    }
}
