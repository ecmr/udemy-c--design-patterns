using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.cs
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void RestoreState(UserMemento userMemento)
        {
            UserID = userMemento.UserID;
            Name = userMemento.Name;
            UserName = userMemento.UserName;
            Password = userMemento.Password;
        }

        public UserMemento SaveState()
        {
            return new UserMemento(UserID, Name, UserName, Password);
        }
    }
}
