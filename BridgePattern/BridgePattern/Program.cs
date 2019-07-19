using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Remote regularTv = new TvRemote(new TV(1, 200));
            Remote smartTv = new smartTvRemote(new TV(1, 200));
            Remote theDvd = new DVDRemote(new DVD(1, 14));


            Console.WriteLine("**Regular Tv**");

            regularTv.ArrowRightButtonPressed();
            regularTv.MiddleButtonPressed();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**Smart Tv**");
            smartTv.ArrowRightButtonPressed();
            smartTv.ArrowRightButtonPressed();
            smartTv.MiddleButtonPressed();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**Dvd Player**");

            theDvd.ArrowRightButtonPressed();
            theDvd.ArrowRightButtonPressed();
            theDvd.MiddleButtonPressed();
            theDvd.MiddleButtonPressed();

            Console.ReadLine();
        }
    }
}
