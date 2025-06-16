using System;

namespace Constructor
{
    public class Circle
    {
        double radius;
        public Circle() { }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double FindCircumference()
        {
            return 2 * Math.PI * this.radius ;
        }

        public double FindArea()
        {
            return this.radius * this.radius * Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle(4.5);

            Console.WriteLine($"The Circumference of a circle is {c1.FindCircumference()}");
            Console.WriteLine($"The Area of Circle is {c1.FindArea()}");

            Console.WriteLine($"The Circumference of a circle is {c2.FindCircumference()}");
            Console.WriteLine($"The Area of Circle is {c2.FindArea()}");
        }
    }
}
