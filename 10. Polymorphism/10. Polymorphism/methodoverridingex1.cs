using System;

namespace _10.Polymorphism
{
    class Shape
    {
        public virtual string Draw()
        {
            return "Nothing to be drawn";
        }
    }

    class Circle : Shape
    {
        public override string Draw()
        {
            return "Cricle has been drawn";
        }
    }

    class Rectangle :Shape
    {
        public override string Draw()
        {
            return "Rectangle has been drawn";
        }
    }

    class Triangle : Shape
    {
        public override string Draw()
        {
            return "Triangle has been drawn";
        }
    }
    class methodoverridingex1
    {
        public static void Main()
        {
            Shape s1 = new Shape();
            Circle c1 = new Circle();
            Triangle t1 = new Triangle();
            Rectangle r1 = new Rectangle();

            Console.WriteLine(s1.Draw());
            Console.WriteLine(c1.Draw());
            Console.WriteLine(t1.Draw());
            Console.WriteLine(r1.Draw());
        }
    }
}
