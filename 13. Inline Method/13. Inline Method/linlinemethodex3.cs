using System;

//lambda expression
namespace _13.Inline_Method
{
    class linlinemethodex3
    {
        public delegate double Area(double r);

        public static void Main()
        {
            Area a1 = (double r) => Math.PI * r * r;
            Console.WriteLine($"Area of circle with radius 4 : {a1.Invoke(6)}");
        }
    }
}
