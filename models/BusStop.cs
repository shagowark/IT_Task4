using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.models
{
    class BusStop
    {
        public event Action BusStopped; 
        public void Arrive()
        {
            Console.WriteLine("Bus has arrived at the bus stop");
            OnBusStopped(); 
        }

        protected virtual void OnBusStopped()
        {
            BusStopped?.Invoke();
        }
    }
}
