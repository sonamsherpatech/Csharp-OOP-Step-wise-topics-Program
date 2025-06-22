using System;
using System.Collections.Generic;

namespace _9.Indexer
{
    //using string as indexer
    class Person
    {
        private Dictionary<string, string> email = new Dictionary<string, string>();

        public string this[string type]
        {
            get
            {
                if(email.ContainsKey(type))
                {
                    return email[type];
                }else
                {
                    return "Not Found";
                }
            }
            set
            {
                email[type] = value;
            }
        }
    }
    class IndexerEx2
    {
        public static void Main()
        {
            Person p = new Person();
            p["home"] = "home@gmail.com";
            p["work"] = "work@gmail.com";

            Console.WriteLine(p["home"]);
            Console.WriteLine(p["work"]);
            Console.WriteLine(p["other"]);
        }
    }
}
