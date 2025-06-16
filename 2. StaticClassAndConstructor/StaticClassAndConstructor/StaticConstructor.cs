using System;
///<summary>
/// Static constructor is a special member function that is used to initialize the static property of object and is defined with static keyword
/// Static have no argument or modifier
/// Static constructor is invoked implicitly before first instance is created or any static member referenced
/// </summary>

namespace StaticClassAndConstructor
{
    public class Student
    {
        int roll;
        string name;
        static string college;

        public Student(int roll, string name)         {
            this.roll = roll;
            this.name = name;
        }

        static Student()
        {
            college = "Ratna Rajya Laxmi Campus";
        }
        public void DisplayDetail()
        {
            Console.WriteLine($"........Student Details.........");
            Console.WriteLine($"{this.roll}\t{this.name}\t{college}");
        }

    }
    class StaticConstructor
    {
        public static void Main()
        {
            Student s1 = new Student(101, "Sonam Sherpa");
            s1.DisplayDetail();
        }
    }
}
