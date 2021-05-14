using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    class SingletonNotThreadSafe
    {
        private SingletonNotThreadSafe() { }

        private static SingletonNotThreadSafe instance = null;
        private static bool firstThread = true;
        public static SingletonNotThreadSafe GetInstance(string value)
        {
            if (instance == null)
            {
                if (firstThread)
                {
                    firstThread = false;

                    //no locking means there is a chance two threads can access this code simultaneously
                    //simulating this chance by sleeping the first thread
                    Thread.Sleep(500);
                }
                instance = new SingletonNotThreadSafe();
                instance.Value = value;
            }
            return instance;
        }

        public string Value { get; set; }
    }
}
