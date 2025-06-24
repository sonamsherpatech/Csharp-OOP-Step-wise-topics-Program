using System;

namespace _9.Indexer
{
    public class CMS
    {
        private string name;
        private string phoneNumber;

        public object this[int index]
        {
            get
            {
                if (index == 0) return name;
                else if (index == 1) return phoneNumber;
                else return null;
            }
            set
            {
                if (index == 0) name = (string)value;
                else if (index == 1) phoneNumber = (string)value;
            }
        }
    }
    class IndexerEx4
    {
        public static void Main()
        {
            CMS c1 = new CMS();
            c1[0] = "Sonam Sherpa";
            c1[1] = "984563214";

            Console.WriteLine("..Contacts..");
            Console.WriteLine($"{c1[0]}\t{c1[1]}");
        }
    }
}
