using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            JumpFactory jumpFactory = new JumpFactory();

            IJumper car = jumpFactory.getJump("car");
            car.Jump();

            IJumper horse = jumpFactory.getJump("horse");
            horse.Jump();

            IJumper parachuter = jumpFactory.getJump("parachuter");
            parachuter.Jump();

            Console.ReadLine();
        }
    }
}
