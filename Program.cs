using System;
using System.Collections.Generic;

namespace MilitaryUnit
{
    class superClass
    {
        static void Main(string[] args)
        {
            Dozer car = new Dozer();
            Roller car1 = new Roller();
            Grader car2 = new Grader();

            JuniorEnlisted joe = new JuniorEnlisted();

            var vehicleList = new List<Vehicle> { car, car1, car2 };

            foreach (var vehicle in vehicleList)
            {
                vehicle.Fuel();
                vehicle.Run();
            }

            joe.March();

            
        }
    }
}
