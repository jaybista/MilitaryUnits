using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Grader : Vehicle
    {
        public Grader()
             : base("Grader", 2, 1102.5)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Grader grades from place to place");
        }
    }
}
