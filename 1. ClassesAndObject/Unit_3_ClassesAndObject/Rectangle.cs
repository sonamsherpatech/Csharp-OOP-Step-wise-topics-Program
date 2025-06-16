using System;

namespace Unit_3_ClassesAndObject
{
    public class Rectangle
    {
        int length, breadth;

        public void SetProperty(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int FindArea()
        {
            return length * breadth;
        }

        public int FindPerimeter()
        {
            return 2 * (length + breadth);
        }
    }
    class Test2
    {
        public static void Main()
        {
            Rectangle r1 = new Rectangle();
            r1.SetProperty(4, 5);
            Console.WriteLine($"The Perimeter of Rectangel is : {r1.FindPerimeter()}");
            Console.WriteLine($"The Area of Rectangle is : {r1.FindArea()}");
        }
    }
}
