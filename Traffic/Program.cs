using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic {
    internal class Program {
        static void Main(string[] args) {
            SUV passengerCar = new SUV();
            FreightTrain freightTrain = new FreightTrain();

            AddPassenger(passengerCar);
            // AddPassenger(freightTrain);  <- Doesn't work as freight train doesn't implement IPassengerCarrier
        }
        
        static void AddPassenger (IPassengerCarrier carrier) {
            carrier.LoadPassenger();
            Console.WriteLine(carrier.ToString());

        }
    }
}
