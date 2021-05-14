using System;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing threadsafe Singleton\n=========================================");
            TestThreadSafe();

            Console.WriteLine("\nTesting non threadsafe Singleton\n=========================================");
            TestNotThreadSafe();

            Console.ReadLine();
        }

        private static void TestThreadSafe()
        {
            var process1 = new Thread(() => { TestThreadSafeSingleton("foot"); });

            var process2 = new Thread(() => { TestThreadSafeSingleton("ball"); });

            Console.WriteLine("which ever thread creates the instance first will set the value \nthread output should have the word foot or ball, this means that the singleton is working \n");

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestThreadSafeSingleton(string value)
        {
            var singleton = SingletonThreadSafe.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        private static void TestNotThreadSafe()
        {
            var process1 = new Thread(() => { TestNotThreadSafeSingleton("apple"); });

            var process2 = new Thread(() => { TestNotThreadSafeSingleton("pie"); });

            Console.WriteLine("words will differ as two threads created the singleton at the same time \n");

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestNotThreadSafeSingleton(string value)
        {
            var singleton = SingletonNotThreadSafe.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
