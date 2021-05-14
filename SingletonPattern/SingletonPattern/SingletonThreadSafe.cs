using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class SingletonThreadSafe
    {
        private SingletonThreadSafe() { }

        private static SingletonThreadSafe _instance;

        private static readonly object _lock = new object();

        public static SingletonThreadSafe GetInstance(string value)
        {
            if (_instance == null)
            {
                // Use a lock to prevent multiple threads from creating instances
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        // This value will be set by the first thread (when it creates the first instance)
        // we can then test that this value does not change when we attempt to create more instances 
        public string Value { get; set; }
    }
}
