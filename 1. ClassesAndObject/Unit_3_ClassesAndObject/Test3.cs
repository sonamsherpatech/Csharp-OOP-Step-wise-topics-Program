using System;

namespace Unit_3_ClassesAndObject
{
    public class Circle
    {
        double radius;
        public void SetProperty(double r)
        {
            this.radius = r;
        }
        public double FindCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double FindArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class Test3
    {
        public static void Main()
        {
            Circle c1 = new Circle();
            c1.SetProperty(4.5);
            Console.WriteLine($"The Circumference of Circle is: {c1.FindCircumference()}");
            Console.WriteLine($"The Area of Circel is: {c1.FindArea()}");
            
        }
    }
}
