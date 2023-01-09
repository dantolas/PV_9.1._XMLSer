using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserDatabase
    {
        List<User> userList;

        public UserDatabase(List<User> userList)
        {
            this.userList = userList;
        }

        public UserDatabase()
        {
            this.userList = new List<User>();
        }
    }
}
