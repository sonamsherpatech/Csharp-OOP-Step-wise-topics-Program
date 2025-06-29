using System;
using System.Collections.Generic;

namespace _11.Generic_Collections
{
    public class DataStore<T>
    {
        T data;
        public DataStore(T data)
        {
            this.data = data;
        }

        public void DisplayData(T parameter)
        {
            Console.WriteLine("Class Property: " + data);
            Console.WriteLine("Local Parameter: " + parameter);
        }
    }
    class userdefinedgenericcollectionex1
    {
        static void Main(string[] args)
        {
            DataStore<int> ds1 = new DataStore<int>(100);
            ds1.DisplayData(500);

            Console.WriteLine("....................");
            DataStore<string> ds2 = new DataStore<string>("Sonam Sherpa");
            ds2.DisplayData("BCA 5th Sem");
        }
    }
}
