using System;

namespace _10.Polymorphism
{
    public class Shapes
    {
        public double dim1, dim2;
        public Shapes() { }

        public Shapes(double dim1, double dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }

        public virtual double findArea()
        {
            return 0.0;
        }
    }

    public class Triangles : Shapes
    {
        public Triangles(double b, double h) : base(b, h) { }

        public override double findArea()
        {
            return 0.5 * base.dim1 * base.dim2;
        }
    }
    class methodoverridingex2
    {
        public static void Main()
        {
            Triangles t1 = new Triangles(4, 5);
            Console.WriteLine($"The area of Triangle is {t1.findArea()}");
        }
    }
}
