using System;
///<summary>
/// Interface in C# defines what a class must do but not how it does it.
/// It contains method signature, properties, events or indexer -- but no implementation
/// A class or struct that implements an interface must provide the actual behavior for all its memeber
/// 
/// KEY POINTS:
/// interface keyword is used.
/// Cannot have fields or constructors
/// supports multiple interitance
/// provides abstraction
/// 
/// SYNTAX:
/// interface <interface_name> {
///     <return_type> method1();
///     <return_type> method2();
///     .
///     .
///     .
/// }
/// </summary>

namespace _6.Interface
{
    interface Area {
        int findArea();
    }

    interface Perimeter
    {
        int findPerimeter();
    }

    public class Rectangle : Area, Perimeter{
        public int length, breadth;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int findArea()
        {
            return length * breadth;
        }
        
        public int findPerimeter()
        {
            return 2 * (length + breadth);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2, 3);
            Console.WriteLine($"Area of Rectangle: {r1.findArea()}");
            Console.WriteLine($"Perimeter of Rectangle: {r1.findPerimeter()}");
        }
    }
}
