using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Horse : IJumper
    {
        public void Jump()  
        {
            Console.WriteLine("The horse jumps over the fence");
        }
    }
}
