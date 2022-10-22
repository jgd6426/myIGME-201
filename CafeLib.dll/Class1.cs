using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib.dll
{
    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public interface IMood
    {
        string Mood { get;}
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public virtual byte AddSugar(byte amount)
        {
            return sugar;
        }
        public abstract string Steam(string brand);
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public override string Steam(string brand) : base(brand)
        {
            return brand;
        }
        public void TakeOrder()
        {

        }
    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public override string Steam(bool customerIsWealthy)
        {
            return customerIsWealthy.ToString();
        }
        public void TakeOrder()
        {

        }
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public string Source { set; }

        public override string Steam()
        {
            return source;
        }
        public override byte AddSugar(byte amount)
        {
            return amount;
        }
        public void TakeOrder()
        {

        }
    }

    public class Waiter : IMood
    {
        public string name;

        public string Mood { get; }
        public void ServeCustomer(HotDrink cup) { }
    }

    public class Customer: IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood { get; }
    }
}
