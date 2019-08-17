using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Dozer : Vehicle
    {
        public Dozer()
          : base("Dozer", 2, 988.6)
        { }

        public void Broke()
        {
            Console.WriteLine($"{vehicleName} brokes after 8000 hours");
        }
    }

}
