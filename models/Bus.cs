using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.models
{
    class Bus
    {
        public event Action<IPassenger> PassengerBoarded; 
        public event Action Overcrowded;

        public int Capacity { get; } 
        public int PassengerCount { get; private set; } 

        public Bus(int capacity)
        {
            Capacity = capacity;
        }

        public void BoardPassenger(IPassenger passenger)
        {
            if (PassengerCount < Capacity)
            {
                PassengerCount++;
                Console.WriteLine("Пассажир сел на автобус");
                PassengerBoarded?.Invoke(passenger); 
            }
            else
            {
                Console.WriteLine("Автобус переполнен!");
                OnOvercrowded(); 
            }
        }

        protected virtual void OnOvercrowded()
        {
            Overcrowded?.Invoke();
        }
    }
}
