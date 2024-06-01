using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.models
{
    class Passenger : IPassenger
    {
        public void BoardBus()
        {
            Console.WriteLine("Passenger boarded the bus");
        }

        public override string ToString()
        {
            return "Passenger";
        }
    }
}
