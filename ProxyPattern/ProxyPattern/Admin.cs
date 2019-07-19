using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Admin : IAdminStuff
    {
        public void DeleteUser()
        {
            Console.WriteLine("Deleted User");
        }
    }
}
