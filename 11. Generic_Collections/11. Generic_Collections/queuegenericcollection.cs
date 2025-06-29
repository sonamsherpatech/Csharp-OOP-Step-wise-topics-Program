using System;
using System.Collections.Generic;

namespace _11.Generic_Collections
{
    class queuegenericcollection
    {
        public static void Main()
        {
            Queue<int> oddNumbers = new Queue<int>();
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                    oddNumbers.Enqueue(i);
            }

            Console.WriteLine("The odd Number between 1 and 20 is: ");
            foreach (int oddNum in oddNumbers)
            {
                Console.Write(oddNum + "\t");
            }
            Console.WriteLine($"\nLength of queue list : {oddNumbers.Count}");

            int num = oddNumbers.Dequeue();
            Console.WriteLine("The first oddNumber Dequeued: " + num);
            Console.WriteLine($"Length of queue list : {oddNumbers.Count}");

            if (oddNumbers.Contains(15))
                Console.WriteLine("15 is in the queue list");

            Console.WriteLine($"Last item in the queue : {oddNumbers.Peek()}");

            oddNumbers.Clear();
            Console.WriteLine($"Length of queue list after clearing all values: {oddNumbers.Count}");

        }
    }
}
