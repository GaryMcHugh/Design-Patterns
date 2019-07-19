using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Parachuter : IJumper
    {
        public void Jump()
        {
            Console.WriteLine("The parachuter jumps out of the plane");
        }
    }
}
