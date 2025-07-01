using System;

//Anonmous Method
namespace _13.Inline_Method
{
    class inlinemethodex2
    {
        public delegate void GreetDelegate(string name);
        public static void Main()
        {
            GreetDelegate gd1 = delegate (string name)
            {
                Console.WriteLine($"Namaste, {name}");
            };

            gd1.Invoke("Sonam");
        }
    }
}
