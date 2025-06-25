using System;

namespace _10.Polymorphism
{
    public class Greeting
    {
        public string SayHello(string name)
        {
            return $"Good Morning! {name}";
        }

        public string SayHello(string name, int age)
        {
            return $"Congratulation {name}, you've turned {age} years old";
        }

        public string SayHello(string name, string title)
        {
            return $"Good Afternoon {name}, {title} of the XYZ Company";
        }
    }
    class methodoverloadingex3
    {
        public static void Main()
        {
            Greeting g1 = new Greeting();
            Console.WriteLine(g1.SayHello("Sonam Sherpa"));
            Console.WriteLine(g1.SayHello("Rohan Sherestha", 32));
            Console.WriteLine(g1.SayHello("Milan Khanal", "Plumber"));
        }
    }
}
