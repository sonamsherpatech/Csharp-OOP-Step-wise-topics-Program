using System;

//overloading < and >
namespace _10.Polymorphism
{
    public class Distances
    {
        public int feet, inch;

        public Distances() { }

        public Distances(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }

        //overload > 
        public static bool operator >(Distances d1, Distances d2)
        {
            int total1 = d1.feet * 12 + d1.inch;
            int total2 = d2.feet * 12 + d2.inch;

            if (total1 > total2) return true;
            return false;
        }

        public static bool operator <(Distances d1, Distances d2)
        {
            int total1 = d1.feet * 12 + d1.inch;
            int total2 = d2.feet * 12 + d2.inch;

            if (total1 < total2) return true;
            return false;
        }
    }
    class relationaloperatoroverloadingex1
    {
        public static void Main()
        {
            Distances d1 = new Distances(4, 3);
            Distances d2 = new Distances(4, 3);

            if(d1 > d2)
            {
                Console.WriteLine("d1 is greater");
            }
            else if(d1 < d2)
            {
                Console.WriteLine("d2 is greater");
            }else
            {
                Console.WriteLine("Both d1 and d2 are equal");
            }
        }
    }
}
