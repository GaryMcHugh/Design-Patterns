using System;

namespace IteratorPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAggregate aggr = new MyAggregate();
            foreach (var item in aggr.GetEvenNums())
            {
                Console.WriteLine(item);
            }

            Console.Read();
            aggr[0] = "1";
            aggr[1] = "2";
            aggr[2] = "3";
            aggr[3] = "4";
            aggr[4] = "5";
            aggr[5] = "6";
            aggr[6] = "7";
            aggr[7] = "8";
            aggr[8] = "9";
            aggr[9] = "10";

            IIterator iter = aggr.GetIterator();

            for (string s = iter.FirstItem; iter.IsDone == false; s = iter.NextItem)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
