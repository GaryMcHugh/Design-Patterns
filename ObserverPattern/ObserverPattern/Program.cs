using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xbox Series X test");
            // Create Products and customers to notify
            var xbox = new XboxSeriesX("Xbox SeriesX", 649.99, 2);
            xbox.follow(new Customer("Gary"));
            xbox.follow(new Customer("Isabell"));

            // Sale's on items or changing stock numbers will notify customers
            xbox.Price = 629.99;
            xbox.StockCount = 4;

            xbox.Price = 599.99;
            xbox.StockCount = 2;


            Console.WriteLine("\nPlay Station 5 test");
            // Create Products and customers to notify
            var ps5 = new PlayStation5("PlayStation5", 499.99, 2);
            ps5.follow(new Customer("Roger"));
            ps5.follow(new Customer("Sarah"));

            // Sale's on items or changing stock numbers will notify customers
            ps5.Price = 449.99;
            ps5.StockCount = 2;

            ps5.Price = 474.99;
            ps5.StockCount = 1;

            Console.ReadLine();
        }
    }
}
