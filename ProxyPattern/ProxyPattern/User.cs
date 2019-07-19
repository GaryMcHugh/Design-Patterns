using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class User
    {
        public string UserType { get; set; }

        public User(string type)
        {
            this.UserType = type;
        }
    }
}
