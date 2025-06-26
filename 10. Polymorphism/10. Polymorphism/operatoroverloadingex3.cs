using System;

namespace _10.Polymorphism
{
    public class Distance
    {
        public int feet, inch;

        public Distance() { }
        public Distance(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }

        //overload + two distance
        public static Distance operator +(Distance d1, Distance d2)
        {
            int total1 = d1.feet * 12 + d1.inch;
            int total2 = d2.feet * 12 + d2.inch;

            int add = total1 + total2;
            return new Distance(add / 12, add % 12);
        }

        //overload - two distance
        public static Distance operator -(Distance d1, Distance d2)
        {
            int total1 = d1.feet * 12 + d1.inch;
            int total2 = d2.feet * 12 + d2.inch;

            int sub = total1 - total2;
            if (sub < 0) sub = 0; //feet and inch are not in negative
            return new Distance(sub / 12, sub % 12);
        }
    }
    class operatoroverloadingex3
    {
        public static void Main()
        {
            Distance d1 = new Distance(7, 7);
            Distance d2 = new Distance(8, 5);
            Distance d3 = d1 + d2;
            Console.WriteLine("After Adding d1 and d2 Distance object");
            Console.WriteLine($"{d3.feet}ft {d3.inch}in");

            Distance d4 = d1 - d2;
            Console.WriteLine("After subtracting d1 and d2 Distance object");
            Console.WriteLine($"{d4.feet}ft {d4.inch}in");
        }
    }
}
