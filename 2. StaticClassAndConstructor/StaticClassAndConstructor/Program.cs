using System;

///<summary>
/// Static class is a class with static keyword and cannot be instantiated
/// Static class contains static data member and member function
/// Static class is sealed meaning it cannot be inherited
/// We can access Static class property and method using <class_name>.(property/method)
///</summary>

namespace StaticClassAndConstructor
{
    public static class MathEx
    {
        public static double PI = 3.1415;

        public static int Cube(int n)
        {
            return n * n * n;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"PI = {MathEx.PI}");
            Console.WriteLine($"The Cube of 5 is {MathEx.Cube(5)}");
        }
    }
}
