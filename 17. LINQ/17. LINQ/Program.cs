using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LINQ
{
    class Program
    {
        static void Main()
        {
            List<int> lists = new List<int>();
            for(int i=1; i<=20; i++)
            {
                lists.Add(i);
            }

            //LINQ query
            var result = from num in lists where num % 2!= 0 select num;

            Console.WriteLine("Odd numbers between 1 to 20 are: ");
            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}
