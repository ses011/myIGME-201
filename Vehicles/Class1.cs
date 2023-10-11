using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles {
    public class AVehicle {
        public AVehicle() { }

        public virtual void LoadPassenger() { }
    }

    public interface IPassengerCarrier {
        void LoadPassenger();
    }

    public interface IHeavyLoadCarrier {

    }

    public class ACar : AVehicle {
        public ACar() { }
    }

    public class ATrain : AVehicle {
        public ATrain() { }
    }

    public class Compact : ACar, IPassengerCarrier {
        public Compact() { }
    }

    public class SUV : ACar, IPassengerCarrier {
        public SUV() { }
    }

    public class Pickup : ACar, IHeavyLoadCarrier {
        public Pickup() { }
    }

    public class PassengerTrain : ATrain, IPassengerCarrier {
        public PassengerTrain() { }
    }

    public class FreightTrain : ATrain, IHeavyLoadCarrier {
        public FreightTrain() { }
    }

    public class DoubleBogey424 : ATrain, IHeavyLoadCarrier {
        public DoubleBogey424() { }
    }
}
