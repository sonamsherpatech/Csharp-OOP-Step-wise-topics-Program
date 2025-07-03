using System;

namespace _14.genericcollection
{
    class genericdelegateex4
    {
        public static void Main()
        {
            Predicate<string> country = (c) => c.Length > 6;
            bool value = country.Invoke("Nepal");
            Console.WriteLine(value);
        }
    }
}
