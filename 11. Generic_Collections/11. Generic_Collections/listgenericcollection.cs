using System;
using System.Collections.Generic;

//List <T> is generic collection where size of a List<T> automatically grows

namespace _11.Generic_Collections
{
    class listgenericcollection
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Sonam");
            list.Add("Rohan");
            list.Add("Milan");
            Console.WriteLine("Obedient Student of BCA 5th Sem");
            foreach(string name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Length of list: " + list.Count);

            list.Remove("Milan");
            Console.WriteLine("Length of list after removing Milan: " + list.Count);

            list.Clear();
            Console.WriteLine("Length of list clearing list: " + list.Count);

        }
    }
}
