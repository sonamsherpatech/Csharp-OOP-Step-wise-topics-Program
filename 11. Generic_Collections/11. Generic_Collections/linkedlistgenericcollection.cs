using System;
using System.Collections.Generic;

namespace _11.Generic_Collections
{
    class linkedlistgenericcollection
    {
        public static void Main()
        {
            LinkedList<string> student = new LinkedList<string>();
            student.AddLast("Rohan");
            student.AddLast("Milan");
            student.AddFirst("Sonam");


            Console.WriteLine("Student of Bca 5th sem");
            foreach(string name in student)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"The length of students list: {student.Count}");

            LinkedListNode<string> rohanNode = student.Find("Rohan");
            student.AddAfter(rohanNode, "Raj");
            Console.WriteLine($"The length of students list after adding raj: {student.Count}");

            LinkedListNode<string> sonamNode = student.Find("Sonam");
            student.AddBefore(sonamNode, "Ujjwol");
            Console.WriteLine($"The length of students list after adding ujjwol: {student.Count}");

            student.RemoveFirst();
            Console.WriteLine($"The length of students list removin first node: {student.Count}");

            student.RemoveLast();
            Console.WriteLine($"The length of students list removin last node: {student.Count}");
            Console.WriteLine("Student of Bca 5th sem");
            foreach (string name in student)
            {
                Console.WriteLine(name);
            }

            if(student.Contains("Sonam"))
            {
                Console.WriteLine("Node contains Sonam");
            }

            student.Clear();
            Console.WriteLine($"The length of students list after removing all node: {student.Count}");

        }
    }
}
