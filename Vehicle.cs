using System;
using System.Collections.Generic;

namespace MilitaryUnit
{
    abstract class Vehicle
    {
        protected readonly int engines = 2;
        protected readonly double engineTemperature;
        protected readonly string vehicleName;
        protected readonly int wheels = 4;

        public Vehicle() { }
        protected Vehicle(string vehicleName, double engineTemperature)
        {
            this.vehicleName = vehicleName;
            this.engineTemperature = engineTemperature;
        }


        protected Vehicle(string vehicleName, int engines, double engineTemperature)
        {
            this.vehicleName = vehicleName;
            this.engines = engines;
            this.engineTemperature = engineTemperature;
        }

        public virtual void Fuel()
        {
            Console.WriteLine($"{vehicleName} fuels");
        }
        public virtual void Body()
        {
            Console.WriteLine($"{vehicleName} bodys");
        }
        public virtual void Landscaping()
        {
            Console.WriteLine($"{vehicleName} landescapes");
        }
        public virtual void Run()

        {
            Console.WriteLine($"{vehicleName} runs on {wheels} wheels");
        }

      
    }
    
}

 

