using System;

namespace _4.StructureAndEnumeration
{
    public struct Rectangle
    {
        double length, breadth;

        public Rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }

        public double FindArea()
        {
            return length * breadth;
        }
    }
    class StructureEx2
    {
        public static void Main()
        {
            Rectangle r1 = new Rectangle(4.5, 7);
            Console.WriteLine($"The area of rectangle is {r1.FindArea()}");
        }
    }
}
