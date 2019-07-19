using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class JumpFactory
    {
        public IJumper getJump(String JumperType)
        {
            if (JumperType == null)
            {
                return null;
            }

            if (JumperType.Equals("car", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Car();

            }

            if (JumperType.Equals("horse", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Horse();

            }

            if (JumperType.Equals("parachuter", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Parachuter();

            }

            return null;
        }
    }
}
