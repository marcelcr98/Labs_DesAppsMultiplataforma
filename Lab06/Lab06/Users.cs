using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }

    public class UserList : List<User>
    {
        public string Heading { get; set; }
        public List<User> Persons => this;
    }


}