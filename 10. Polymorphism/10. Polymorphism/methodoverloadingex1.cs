using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Polymorphism
{
    public class Adder
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }
    }
    class methodoverloadingex1
    {
        static void Main(string[] args)
        {
            Adder a1 = new Adder();
            Console.WriteLine($"The sum of two integer is {a1.Add(1, 2)}");
            Console.WriteLine($"The sum of three integer is {a1.Add(1, 2,3)}");
            Console.WriteLine($"The sum of two double is {a1.Add(1.3, 2.7)}");
        }
    }
}
