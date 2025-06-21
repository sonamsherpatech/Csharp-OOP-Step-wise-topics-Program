using System;

namespace _8.PropertiesAndTypes
{
    public class Employee {
        //Auto-Implemented Property
        public int EID { get; set; }

        private string name;
        private double salary;
        //Read-Only
        public string NameR
        {
            get { return name; }
        }

        //Write-Only
        public string NameW
        {
            set { name = value; }
        }


        //Read-Write
        public double Salary
        {
            set{ salary = value; }
            get { return salary;  }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.EID = 101;
            e1.NameW = "Sonam Sherpa";
            e1.Salary = 4500.65;

            Console.WriteLine("...Employee Details...");
            Console.WriteLine($"{e1.EID}\t{e1.NameR}\t{e1.Salary}");
        }
    }
}
