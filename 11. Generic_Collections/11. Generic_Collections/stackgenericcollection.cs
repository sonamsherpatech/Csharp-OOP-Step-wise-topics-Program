using System;
using System.Collections.Generic;

namespace _11.Generic_Collections
{
    class stackgenericcollection
    {
        public static void Main()
        {
            Stack<int> oddNumbers = new Stack<int>();
            for(int i =1; i<=20;i++)
            {
                if(i % 2 != 0)
                oddNumbers.Push(i);
            }

            Console.WriteLine("The odd Number between 1 and 20 is: ");
            foreach(int oddNum in oddNumbers)
            { 
                Console.Write(oddNum + "\t");
            }
            Console.WriteLine($"\nLength of stack list : {oddNumbers.Count}");

            int num = oddNumbers.Pop();
            Console.WriteLine("The first oddNumber Poped: " + num);
            Console.WriteLine($"Length of stack list : {oddNumbers.Count}");

            if (oddNumbers.Contains(15))
                Console.WriteLine("15 is in the stack list");

            Console.WriteLine($"Last item in the stack : {oddNumbers.Peek()}");

            oddNumbers.Clear();
            Console.WriteLine($"Length of stack list after clearing all values: {oddNumbers.Count}");

        }
    }
}
