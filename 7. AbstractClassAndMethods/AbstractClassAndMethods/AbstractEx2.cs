using System;


namespace AbstractClassAndMethods
{
    public abstract class Employee
    {
        public int id;
        public string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public abstract double CalculateSalary();

        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{name}\nID:{id}\nSalary:{CalculateSalary()}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public double monthlySalary;
        public FullTimeEmployee(int id, string name,double monthlySalary):base(id,name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return monthlySalary;
        }
    }

    public class PartTimeEmployee : Employee
    {
        public double hourlyRate, hoursWorked;
        public PartTimeEmployee(int id, string name, double hourlyRate, double hoursWorked) : base(id,name)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }
    }

    class AbstractEx2
    {
        public static void Main()
        {
            FullTimeEmployee f1 = new FullTimeEmployee(4500, "Sonam Sherpa", 4500.63);
            f1.DisplayInfo();

            PartTimeEmployee p1 = new PartTimeEmployee(6500, "Rohan Shrestha", 12.50, 6);
            p1.DisplayInfo();
        }
    }
}
