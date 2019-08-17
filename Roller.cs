using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{


    class Roller : Vehicle
    {
        public Roller()
             : base("Roller", 1101.5)
        {
        }


        public override void Fuel()
        {
            base.Fuel();
            Console.WriteLine($"{vehicleName} digests fuelwith 8 \"hours\"");
        }
    }
}
