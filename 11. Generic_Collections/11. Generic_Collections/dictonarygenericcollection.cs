using System;
using System.Collections.Generic;

namespace _11.Generic_Collections
{
    class dictonarygenericcollection
    {
        public static void Main()
        {
            Dictionary<string, string> dataObj = new Dictionary<string, string>();

            dataObj.Add("CACS301", "MIS & EBusiness");
            dataObj.Add("CACS302", "Dot Net Technology");
            dataObj.Add("CACS303", "Computer Network");
            dataObj.Add("CACS304", "Introduction to Management");
            dataObj.Add("CACS305", "Computer Graphics");

            Console.WriteLine("BCA 5th sem");
            foreach(var data in dataObj)
            {
                Console.WriteLine(data.Key + " : " + data.Value);
            }
            Console.WriteLine($"The length of dataObj is {dataObj.Count}");

            dataObj.Remove("Introduction to Management");
            Console.WriteLine($"The length of dataObj after removing Introduction to Management is {dataObj.Count}");

            if(dataObj.ContainsKey("CACS301"))
            {
                Console.WriteLine("The BCA 5th sem contains MIS &EBusines Course");
            }

            dataObj.Clear();
            Console.WriteLine($"The length of dataObj after clearign all data is {dataObj.Count}");

        }
    }
}
