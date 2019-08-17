using System;

namespace MilitaryUnit
{
    class Personnel
    {
        protected readonly string rank;

        protected Personnel(string rank)
        {
            this.rank = rank;
        }

        public virtual void March()
        {
            Console.WriteLine($"The {rank} marches from place to place.");
        }

    }

    class NCO : 


}

 

