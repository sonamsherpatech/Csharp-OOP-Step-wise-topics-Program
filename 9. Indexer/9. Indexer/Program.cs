using System;

namespace _9.Indexer
{
    public class Employee
    {
        private int e_id;
        private string name;
        private double salary;

        public object this[int index]
        {
            set
            {
                if (index == 0) this.e_id = (int)value;
                if (index == 1) this.name = (string)value;
                if (index == 2) this.salary = (double)value;
            }
            get
            {
                if (index == 0) return e_id;
                else if (index == 1) return name;
                else if (index == 2) return salary;
                else return null;
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1[0] = 225;
            e1[1] = "Sonam Sherpa";
            e1[2] = 4500.62;

            Console.WriteLine($"ID={e1[0]}\nName={e1[1]}\nSalary={e1[2]}");
        }
    }
}
