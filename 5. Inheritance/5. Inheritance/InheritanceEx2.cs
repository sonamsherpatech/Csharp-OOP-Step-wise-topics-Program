using System;
using System.Security.Cryptography.X509Certificates;

namespace _5.Inheritance
{
    public class Vehicle
    {
        public string brand, model;
        
        public Vehicle(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
    }

    public class Car : Vehicle
    {
        public int noOfDoors;
        
        public Car(string brand, string model, int noOfDoors) : base(brand, model)
        {
            this.noOfDoors = noOfDoors;
        }
    }

    public class ElectricCar : Car
    {
        public double batteryCapacity;
        public ElectricCar(string brand, string model, int noOfDoors, double batteryCapacity) : base(brand, model, noOfDoors)
        {
            this.batteryCapacity = batteryCapacity;
        }
    }

    public class Bike : Vehicle
    {
        public bool hasCarrier;
        public Bike(string brand, string model, bool hasCarrier) : base(brand, model)
        {
            this.hasCarrier = hasCarrier;
        }
    }
    public class InheritanceEx2
    {
        public static void Main()
        {
            //Single Level Inheritance
            Car c1 = new Car("Honda", "Hn2025", 2);
            Console.WriteLine("...Car Detail...");
            Console.WriteLine($"{c1.brand}\t{c1.model}\t{c1.noOfDoors}");

            //Multi Level Inheritance
            ElectricCar e1 = new ElectricCar("Tesla", "Tx005", 4, 4500);
            Console.WriteLine("...Electric Car Details...");
            Console.WriteLine($"{e1.brand}\t{e1.model}\t{e1.noOfDoors}\t{e1.batteryCapacity}");

            //Hierarchical Inheritance
            Bike b1 = new Bike("Honda", "R15", true);
            Car c2 = new Car("Ferrari", "Red Wagon", 2);

            Console.WriteLine("..Bike Details...");
            Console.WriteLine($"{b1.brand}\t{b1.model}\t{b1.hasCarrier}");

            Console.WriteLine("...Car Detail...");
            Console.WriteLine($"{c2.brand}\t{c2.model}\t{c2.noOfDoors}");


        }
    }
}
