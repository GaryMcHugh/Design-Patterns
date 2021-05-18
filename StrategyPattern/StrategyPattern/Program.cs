using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //definition
            //Strategy is a behavioral design pattern that lets you define a family of algorithms,
            //put each of them into a separate class, and make their objects interchangeable.

            //description
            //we defined a RouteBuilder interface, and 3 concrete classes that implement it (car, cycle and walk)
            //we then defined Navigator, which allows us to change the context of the strategy we want to use
            //we can then have different behaviours based on the strategy by using the strategy pattern


            Console.WriteLine("Car: ");
            var navigator = new Navigator(new CarRoute());
            Console.WriteLine(navigator.Navigate("bamboo cafe", "home"));

            Console.WriteLine("Bicycle: ");
            navigator = new Navigator(new CycleRoute());
            Console.WriteLine(navigator.Navigate("Shopping center", "Starbucks"));

            Console.WriteLine("Pedestrian: ");
            navigator = new Navigator(new WalkingRoute());
            Console.WriteLine(navigator.Navigate("Work", "Train Station"));

            Console.ReadLine();
        }
    }
}
