using System;

namespace _15.event_and_event_handiling
{
    // 1. Define delegate
    public delegate void PriceChange(string name, double op, double np);

    // 2. Define Publisher and event within it
    public class StockTicker
    {
        public event PriceChange pc;
        public string Name { get; set; }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                var oldPrice = price;
                price = value;

                pc?.Invoke(Name, oldPrice, price); //Raise the event
            }
        }
    }

    // Define Subscriber class and method that is triggerd when evnt is created
    public class Person
    {
        public void SendMessage(string name, double op, double np)
        {
            Console.WriteLine($"The price of {name} is changed from {op} to {np}");
        }
    }


    class eventhandlingex1
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            StockTicker st = new StockTicker { Name = "NABIL", Price = 500 };
            st.pc += p1.SendMessage;
            st.Price = 600;
            st.Price = 400;
        }
    }
}
