using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public Boolean instant;
        public Boolean milk;
        public byte sugar;
        public String size;
        public Customer customer;

        public HotDrink() { }

        public HotDrink(String brand) { }

        public void AddSugar(byte amount)
        {
            this.sugar += amount;
        }

        public abstract void Steam();
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public interface IMood
    {
        String Mood
        {
            get;
        }
    }

    public class Customer : IMood 
    {
        public String name;
        public String creditCardNumber;

        public String Mood
        {
            get { return this.name; }
        }
    }

    public class Waiter : IMood
    {
        public String name;
        public String Mood
        {
            get { return this.name; }
        }

        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public String beanType;

        public CupOfCoffee(String brand) : base(brand) { }

        public override void Steam() { }

        public void TakeOrder() { }
    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public String leafType;

        public CupOfTea(bool customerIsWealthy) { }

        public override void Steam() { }

        public void TakeOrder() { }
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups;
        public Boolean marchmallows;
        private String source;

        public CupOfCocoa() { }

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand") { }

        public String Source { set { this.source = value; } }

        public override void Steam() { }

        public void AddSugar(byte amount) { base.AddSugar(amount); }

        public void TakeOrder() { }
    }
}
