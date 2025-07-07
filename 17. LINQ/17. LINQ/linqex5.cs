using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LINQ
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; } 
    }
    class linqex5
    {
        public static void Main() {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> fruits = new List<string> { "apple", "banana", "apple", "cherry" };
            List<Person> people = new List<Person>
            {
                new Person {Name="Sonam Sherpa", Age=35},
                new Person{Name="Rohan Shrestha", Age=75},
                new Person{Name="Milan Khanal", Age=25}
            };

            //Filtering
            var even = numbers.Where(number => number % 2 == 0);
            var stringOnly = new List<object> { 1, "two", 3, "four" }.OfType<string>();

            Console.WriteLine("Even Numbers");
            foreach(int e in even)
            {
                Console.Write(e + "\t");
            }
        
            Console.WriteLine("\nStrings Only");
            foreach (string s in stringOnly)
            {
                Console.Write(s + "\t");
            }

            //Sorting
            var ordered = numbers.OrderBy(n => n);
            var desc = numbers.OrderByDescending(n => n);
            var thenBy = people.OrderBy(p => p.Age).ThenBy(p => p.Name);
            numbers.Reverse();

            Console.WriteLine("\nAscending order Numbers");
            foreach (int o in ordered)
            {
                Console.Write(o + "\t");
            }

            Console.WriteLine("\nDescending Order Numbers");
            foreach (int d in desc)
            {
                Console.Write(d + "\t");
            }

            Console.WriteLine("\nThen By Operator");
            foreach (var t in thenBy)
            {
                Console.Write(t.Name + "\t" + t.Age+ "\n");
            }

            Console.WriteLine("\nReversed Numbers");
            foreach (int r in numbers)
            {
                Console.Write(r + "\t");
            }
            numbers.Reverse();


            //Aggregation
            var sum = numbers.Sum();
            var count = numbers.Count();
            var min = numbers.Min();
            var max = numbers.Max();
            var avg = numbers.Average();
            var aggregate = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine($"\nThe Sum of all numbers is: {sum}");
            Console.WriteLine($"The total count of all numbers is: {count}");
            Console.WriteLine($"The minimum from all numbers is: {min}");
            Console.WriteLine($"The maximum from all numbers is: {max}");
            Console.WriteLine($"The average of all numbers is: {avg}");
            Console.WriteLine($"The aggregate of all numbers is: {aggregate}");

            //Quantifiers
            var allEven = numbers.All(n => n % 2 == 0);
            var anyEven = numbers.Any(n => n % 2 == 0);
            var containsFive = numbers.Contains(5);

            Console.WriteLine("All operaotr for all even in numbers " + allEven);
            Console.WriteLine("All operaotr for any even in numbers " + anyEven);
            Console.WriteLine("Numbesr contains five " + containsFive);

            //Set 
            var union = numbers.Union(new List<int> { 11, 5, 7 });
            var intersection = numbers.Intersect(new List<int> { 5, 6,12 });
            var distinct = new List<int> { 1, 1, 2, 3, 1, 5, 6, 3, 4, 8, 2, 3 }.Distinct();
            var except = numbers.Except(new List<int> { 3, 5, 7 });

            Console.WriteLine("Union");
            foreach (int u in union)
            {
                Console.Write(u + "\t");
            }
            Console.WriteLine("\nIntersect");
            foreach (int i in intersection)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\nDistinct");
            foreach (int d in distinct)
            {
                Console.Write(d + "\t");
            }
            Console.WriteLine("\nExcept");
            foreach (int e in except)
            {
                Console.Write(e + "\t");
            }

            //Grouping
            var groupByAge = people.GroupBy(p => p.Age);
            var lookup = people.ToLookup(p => p.Age);

            Console.WriteLine("\nGroup By Operator");
            Console.WriteLine(groupByAge);
            foreach (var g in groupByAge)
            {
                Console.Write(g.Key + "\t" + g.Count());
            }



        }


    }
}
