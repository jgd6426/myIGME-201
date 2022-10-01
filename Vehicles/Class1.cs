using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public virtual void LoadPassenger() { }
    }
    public abstract class Car : Vehicle { }

    public interface PassengerCarrier
    {
        void LoadPassenger();
    }

    public interface HeavyLoadCarrier { }

    public abstract class Train : Vehicle { }

    public class Compact : Car
    {
        public override void LoadPassenger() { }
    }

    public class SUV : Car
    {
        public override void LoadPassenger() { }
    }

    public class Pickup : Car
    {
        public override void LoadPassenger() { }
        public interface HeavyLoadCarrier { }

    }

    public class PassengerTrain : Train
    {
        public override void LoadPassenger() { }
    }

    public class FreightTrain : Train
    {
        public interface HeavyLoadCarrier { }
    }

    public class _424DoubleBogey : Train
    {
        public interface HeavyLoadCarrier { }
    }

}
