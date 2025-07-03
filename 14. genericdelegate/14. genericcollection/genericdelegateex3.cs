using System;

namespace _14.genericcollection
{
    class genericdelegateex3
    {
        public static void Main()
        {
            Func<string, string, string> fullName = (first, last) => first + last;
            Console.WriteLine($"Full Name: {fullName.Invoke("Sonam", "Sherpa")}");
        }
    }
}
