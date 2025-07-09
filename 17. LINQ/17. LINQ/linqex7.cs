using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LINQ
{
    public class Students
    {
        public int roll;
        public string name, college;
        public Students(int roll, string name, string college)
        {
            this.roll = roll;
            this.name = name;
            this.college = college;
        }
    }
    class linqex7
    {
        public static void Main()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students(101, "Sonam Sherpa", "RR Campus"));
            students.Add(new Students(102, "Rohan Shrestha", "PK Campus"));
            students.Add(new Students(103, "Milan Khanal", "RR Campus"));
            students.Add(new Students(104, "Nabin Khatri", "RR Campus"));

            //LINQ Method
            var result = students.OrderByDescending(s => s.name).Where(s => s.college == "RR Campus");

            //Display
            Console.WriteLine("Students from RR Campus:: ");
            foreach(var student in result)
            {
                Console.WriteLine($"{student.roll}\t{student.name}\t{student.college}");
            }
        }
    }
}
