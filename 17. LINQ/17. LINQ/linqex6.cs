using System;
using System.Collections.Generic;
using System.Linq;

namespace _17.LINQ
{
    class Employees
    {
        //public int EId { get; set; }
        //public string Name { get; set; }
        //public string Department { get; set; }
        //public double Salary { get; set; }
        public int eid;
        public string name, department;
        public double salary;

        public Employees(int eid, string name, string deparment, double salary)
        {
            this.eid = eid;
            this.name = name;
            this.department = deparment;
            this.salary = salary;
        }
    }
    class linqex6
    {
        public static void Main ()
        {
            List<Employees> employees = new List<Employees>();
            employees.Add(new Employees(101, "Sonam Sherpa", "CEO", 5500));
            employees.Add(new Employees(102, "Rohan Shretha", "Project Manager", 3500));
            employees.Add(new Employees(103, "Milan Khanal", "sales", 1500));
            employees.Add(new Employees(104, "Ujjwol Subedi", "sales", 5500));


            var result = employees.Where(e => e.department == "sales" && e.salary > 5000);

            Console.WriteLine("The Employee with greater than 5000 Salary and  in sales departement are: ");
            foreach(var r in result)
            {
                Console.WriteLine($"{r.eid} \t {r.name} \t {r.department} \t {r.salary}");
            }


        }
    }
}
