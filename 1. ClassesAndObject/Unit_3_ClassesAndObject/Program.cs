
using System;

namespace Unit_3_ClassesAndObject
{
    public class Box
    {
        int length, breadth, height;
        public void SetProperty(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }


        public int FindArea()
        {
            return 2 * (this.length * this.breadth + this.breadth * this.height + this.height * this.length);
        }

        public int FindVolume()
        {
            return this.length * this.breadth * this.height;
        }

    }

        class Program
        {
        static void Main()
        {
            Box b1 = new Box();
            b1.SetProperty(4, 5, 6);
            Console.WriteLine($"The Area of Box is {b1.FindArea()}");
            Console.WriteLine($"The Volume of Box is {b1.FindVolume()}");
        }
    }
}
