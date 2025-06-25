using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Polymorphism
{
    public class Vector
    {
        public double x, y;
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //overload *
        public static Vector operator *(Vector v, double k)
        {
            return new Vector(v.x * k, v.y * k);
        }

        //overload /
        public static Vector operator /(Vector v, double k)
        {
            return new Vector(v.x / k, v.y / k);
        }
    }
    class operatoroverloadingex2
    {
        public static void Main()
        {
            Vector v = new Vector(4, 3);
            Vector mul = v * 3;
            Console.WriteLine($"Resultant Vector V = ({mul.x},{mul.y})");

            Vector div = v / 3;
            Console.WriteLine($"Resultant Vector V = ({div.x},{div.y})");
        }
    }
}
