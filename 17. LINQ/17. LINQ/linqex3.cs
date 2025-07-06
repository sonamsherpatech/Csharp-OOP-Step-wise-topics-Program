using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LINQ
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }
    class linqex3
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student{Name="Ram", Marks=45},
                new Student{Name="Shyam", Marks=75},
                new Student{Name = "Hari", Marks=78}
            };

            var result = from student in students where student.Marks > 70 select student;

            Console.WriteLine("Students whith marks more than 70");
            foreach(var s in result)
            {

            Console.WriteLine(s.Name + "\t" + s.Marks);
            }
        }
    }
}
