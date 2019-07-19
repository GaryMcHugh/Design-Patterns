using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Regular User");
            IAdminStuff car = new Proxy(new User("Regular"));
            car.DeleteUser();


            Console.WriteLine();
            Console.WriteLine("Admin User");
            car = new Proxy(new User("ADMIN"));
            car.DeleteUser();

            Console.ReadLine();
        }
    }
}
