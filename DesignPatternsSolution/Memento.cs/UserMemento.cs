using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.cs
{
    public class UserMemento
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserMemento(int userID, string name, string userName, string password)
        {
            UserID = userID;
            Name = name;
            UserName = userName;
            Password = password;
        }
    }
}