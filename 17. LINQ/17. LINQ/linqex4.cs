using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LINQ
{
    public class CStudent
    {
        public string Name { get; set; }
        public int Marks { get; set; }

    }
    class linqex4
    {
        public static void Main()
        {
            List<CStudent> students = new List<CStudent>
            {
                new CStudent{Name = "Sonam Sherpa",Marks =  75 },
                new CStudent{Name="Rohan Sherstha", Marks = 72},
                new CStudent{Name= "Milan Khanal", Marks= 70}
            };

            //LINQ Method
            var result = from student in students
                         orderby student.Marks 
                         select student;

            Console.WriteLine("List of student is ascending marks: ");
            foreach(var s in result)
            {
                Console.WriteLine(s.Name + "\t" + s.Marks);
            }
            
        }
    }
}
