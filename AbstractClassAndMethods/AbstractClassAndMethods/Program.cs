using System;

namespace AbstractClassAndMethods
{
    public abstract class Shape {
        public double dim1, dim2;

        public Shape(double dim1, double dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }

        public abstract double FindArea();
    }

    public class Triangle : Shape
    {
        public Triangle(double dim1, double dim2) : base(dim1, dim2)
        {
        }

        public override double FindArea()
        {
            return 0.5 * base.dim1 * base.dim2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(4, 5);
            Console.WriteLine($"Area of Triangle is {t1.FindArea()}");
        }
    }
}
