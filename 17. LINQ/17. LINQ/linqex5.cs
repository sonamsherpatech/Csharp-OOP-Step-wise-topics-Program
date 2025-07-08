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
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int DeptId { get; set; }
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
            foreach (var g in groupByAge)
            {
                Console.Write(g.Key);
                foreach(var p in g)
                {
                    Console.WriteLine(" - " + p.Name);
                }
            }

            Console.WriteLine("\nLook Up Operator");
            foreach(var l in lookup)
            {
                Console.WriteLine(l.Key);
                foreach(var p in l)
                {
                    Console.WriteLine(" - " + p.Name);
                }
            }

            //Elements
            var first = numbers.First();
            var firstOrDefault = numbers.FirstOrDefault();
            var last = numbers.Last();
            var lastOrDefault = numbers.LastOrDefault();
            var single = new List<int> { 100 }.Single();
            var singleOrDefault = new List<int> { }.SingleOrDefault();
            var elementAt = numbers.ElementAt(2);
            var elementAtOrDefault = numbers.ElementAtOrDefault(100);

            Console.WriteLine($"First Number is: {first}");
            Console.WriteLine($"FirstOrDefault Number is: {firstOrDefault}");
            Console.WriteLine($"Last Number is: {last}");
            Console.WriteLine($"LastOrDefault Number is: {lastOrDefault}");
            Console.WriteLine($"Single Number is: {single}");
            Console.WriteLine($"SingeOrDefault Number is: {singleOrDefault}");
            Console.WriteLine($"ElementAt 2 is: {elementAt}");
            Console.WriteLine($"ElementAtOrDefault 100 is: {elementAtOrDefault}");

            //Projection
            var squares = numbers.Select(n => n * n);
            var chars = fruits.SelectMany(f => f.ToCharArray());
            //var chars = numbers.SelectMany(n=>n);
            Console.WriteLine("Select Operator");
            foreach(var s in squares)
            {
                Console.Write(s + "\t");
            }

            Console.WriteLine("\nSelect Many Operator");
            foreach(var c in chars)
            {
                Console.Write(c + "\t");
            }

            //concatenation operator
            var concat = numbers.Concat(new List<int> { 11, 12 });
            Console.WriteLine("\nConcatenation Operator: ");
            foreach(var c in concat)
            {
                Console.Write(c + "\t");
            }

            //Partitioning
            var skip = numbers.Skip(5);
            var skipWhile = numbers.SkipWhile(n => n < 5);
            var take = numbers.Take(3);
            var takeWhile = numbers.TakeWhile(n => n < 5);

            Console.WriteLine("\nSkip Operator");
            foreach (var s in skip)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine("\nSkip While operator");
            foreach(var sw in skipWhile)
            {
                Console.Write(sw + "\t");
            }
            Console.WriteLine("\nTake Operator");
            foreach(var t in take)
            {
                Console.Write(t + "\t");
            }
            Console.WriteLine("\nTakeWhile Operator");
            foreach(var tw in takeWhile)
            {
                Console.Write(tw + "\t");
            }

            //Equality 
            var areEqual = numbers.SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 });
            Console.WriteLine(areEqual);

            // Generation
            var empty = Enumerable.Empty<int>();
            var range = Enumerable.Range(1, 5);
            var repeat = Enumerable.Repeat("hello", 3);
            var defaultIfEmpty = new List<string>().DefaultIfEmpty("none");

            Console.WriteLine("---- Generation ----");
            Console.WriteLine("Empty:");
            foreach (var e in empty)
                Console.WriteLine(e); // no output

            Console.WriteLine("Range:");
            foreach (var r in range)
                Console.WriteLine(r); // 1 2 3 4 5

            Console.WriteLine("Repeat:");
            foreach (var item in repeat)
                Console.WriteLine(item); // hello hello hello

            Console.WriteLine("DefaultIfEmpty:");
            foreach (var item in defaultIfEmpty)
                Console.WriteLine(item); // none

            // Conversion

            var array = numbers.ToArray();
            var list = numbers.ToList();
            var dict = people.ToDictionary(p => p.Name);
            var casted = new List<object> { "a", "b" }.Cast<string>();

            Console.WriteLine("\n---- Conversion ----");
            Console.WriteLine("ToArray:");
            foreach (var n in array)
                Console.WriteLine(n); // 10 20 30

            Console.WriteLine("ToList:");
            foreach (var n in list)
                Console.WriteLine(n); // 10 20 30

            Console.WriteLine("ToDictionary:");
            foreach (var kv in dict)
                Console.WriteLine($"Key: {kv.Key}, Value: DeptId={kv.Value.Name}");

            Console.WriteLine("Cast:");
            foreach (var str in casted)
                Console.WriteLine(str); // a b

            // Joining
            var departments = new List<Department>
            {
                new Department { Id = 1, Name = "HR" },
                new Department { Id = 2, Name = "IT" }
            };

            var employees = new List<Employee>
            {
                new Employee { Name = "Alice", DeptId = 1 },
                new Employee { Name = "Bob", DeptId = 2 }
            };

            var joined = employees.Join(departments,
                                        e => e.DeptId,
                                        d => d.Id,
                                        (e, d) => new { e.Name, Department = d.Name });

            var groupJoined = departments.GroupJoin(employees,
                                                    d => d.Id,
                                                    e => e.DeptId,
                                                    (d, es) => new { d.Name, Employees = es });

            Console.WriteLine("\n---- Join ----");
            Console.WriteLine("Inner Join:");
            foreach (var j in joined)
                Console.WriteLine($"{j.Name} works in {j.Department}");

            Console.WriteLine("Group Join:");
            foreach (var group in groupJoined)
            {
                Console.WriteLine($"Department: {group.Name}");
                foreach (var emp in group.Employees)
                    Console.WriteLine($" - {emp.Name}");
            }
        }


    }
}
