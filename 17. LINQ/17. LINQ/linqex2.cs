using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LINQ
{
    class linqex2
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 45, 60 };

            //LINQ QUERY
            var result = from num in numbers where num >= 30 select num;

            Console.WriteLine("The number that is greater than 30 is");
            foreach (int n in result)
                Console.Write(n + " ");
        }
    }
}
