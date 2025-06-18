using System;

///<summary>
/// Inheritance is a process of acquring property of one object into another object.
/// It is the process of creating new class from existing class
/// It maintains IS-A relationship or parent-child relationship
/// 
/// USES: -> code resuability and to perform runtime polymorphism
/// 
/// Base Class: Class whose propeties are inherited are known as base or parent class
/// Derived Class: Class who inherits the properties from parent/base class are known as derived class/ child class
/// 
/// 
/// TYPES OF INHERITANCE:
/// i) Single Level Inheritance: In single level inheritance, a child class inherits the properties and methods from a parent class.
///     SYNTAX:
///     <access_modifier> class <parent_name> {
///         //property and method
///     }
///     
///     <access_modifier> class <child_class> : <parent_class> {
///         //inherits property and method from parent class
///         //its own property and method
///     }
///     
/// ii) Multi Level Inheritance: In multi level inheritance, a child class inherits the properties and methods from a parent class which in turns inherits properties and methods from a grand parent class
///     SYNTAX:
///     
///     <access_modifier> class <grandparent_class> {
///         //property and method
///     }
///     
///     <access_modifier> class <parent_class> : <grandparent_class> {
///         //inherits property and method from grandparent class
///         //its own property and method
///     }
///     
///     <access_modifier> class <child_class> : <parent_class> {
///         //inherits property and method from parent and grandparent class
///         //its own property and method
///     }
///    
/// iii) Hierarchical Inheritance: In heirarchical inheritance, a parent class property and methods are inherited by one or more child class
///     SYNTAX: 
///     
///     <access_modifier> class <parent_name> {
///         //property and method
///     }
///     
///     <access_modifier> class <child_class1> : <parent_class> {
///         //inherits property and method from parent class
///         //its own property and method
///     }
/// 
///     <access_modifier> class <child_class2> : <parent_class> {
///         //inherits property and method from parent class
///         //its own property and method
///     }
/// 
///     <access_modifier> class <child_classn> : <parent_class> {
///         //inherits property and method from parent class
///         //its own property and method
///     }
/// </summary>

namespace _5.Inheritance
{
    public class Person
    {
        public string name, address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }

    public class Student : Person
    {
        public int roll;
        public Student(int roll, string name, string address) : base(name, address)
        {
            this.roll = roll;
        }
    }

    public class CStudent : Student
    {
        public string cName;
        public CStudent(int roll, string name, string address, string cName) : base(roll,name,address)
        {
            this.cName = cName;
        }
    }

    public class Employee : Person
    {
        public double salary;
        public Employee(string name, string address, double salary) : base(name, address)
        {
            this.salary = salary;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Single Level Inheritance
            Student s1 = new Student(101, "Sonam Sherpa", "Pasikot");
            Console.WriteLine("....Student Detail....");
            Console.WriteLine($"{s1.roll}\t{s1.name}\t{s1.address}");

            //Mulit level Inheritance
            CStudent c1 = new CStudent(102, "Rohan Shrestha", "Kalanki", "RR Campus");
            Console.WriteLine("....College Student Detail...");
            Console.WriteLine($"{c1.roll}\t{c1.name}\t{c1.address}\t{c1.cName}");

            //Hierarchical Inheritance
            Employee e1 = new Employee("Milan Khanal", "Kritipur", 4500.50);
            Student s2 = new Student(103, "Ujjwol Subedi", "Thimi");
            Console.WriteLine("...Employee Detail...");
            Console.WriteLine($"{e1.name}\t{e1.address}\t{e1.salary}");

            Console.WriteLine("....Student Detail....");
            Console.WriteLine($"{s2.roll}\t{s2.name}\t{s2.address}");

        }
    }
}
