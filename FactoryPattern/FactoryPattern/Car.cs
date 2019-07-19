using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Car : IJumper
    {
        public void Jump()
        {
            Console.WriteLine("The man jumps his car.");
        }
    }
}
