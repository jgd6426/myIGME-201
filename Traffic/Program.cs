using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    static internal class Program
    {
        interface IPassengerCarrier
        {
            void LoadPassenger();
        }
        static void Main(string[] args)
        {

        }

        static void AddPassenger(IPassengerCarrier vehicleObject) 
        {
            vehicleObject.LoadPassenger();

            Console.WriteLine(vehicleObject.ToString());
        }
    }
}
