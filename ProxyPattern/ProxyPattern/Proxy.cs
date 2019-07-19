using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy : IAdminStuff
    {
        private readonly User _user;
        private readonly IAdminStuff _adminStuff;

        public Proxy(User user)
        {
            _user = user;
            _adminStuff = new Admin();
        }

        public void DeleteUser()
        {
            if (_user.UserType != "ADMIN")
                Console.WriteLine("You must be an admin to perform this action.");
            else
                this._adminStuff.DeleteUser();
        }
    }
}
