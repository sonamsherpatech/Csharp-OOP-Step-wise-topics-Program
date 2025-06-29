using System;
using System.Collections.Generic;

namespace _11.Generic_Collections
{
    public class ShoppingCart<T>
    {
        T[] items = new T[5];
        int i = 0;
        public void AddItems(T item)
        {
            if (i < 5)
            {
                items[i] = item;
                i++;
            }else
            {
                Console.WriteLine("Can't Add more than 5 item");
            }
        }

        public void GetItem(int index)
        {
            Console.WriteLine($"Item at index {index} is {items[index]}");
        }

        public void DisplayItem()
        {
                Console.WriteLine("Shopping Cart Item");
            //foreach(T item in items)
            //{
            //    Console.WriteLine(item);
            //}
            for(int k = 0; k < i; k++)
            {
                Console.WriteLine(items[k]);
            }
        }
    }
    class userdefinedgenericcollectionex2
    {
        public static void Main()
        {
            ShoppingCart<string> sc1 = new ShoppingCart<string>();
            sc1.AddItems("Milk");
            sc1.AddItems("Curd");
            sc1.AddItems("Corn");
            sc1.AddItems("Pepsi");
            sc1.AddItems("Cello Tape");

            sc1.GetItem(3);

            sc1.DisplayItem();
        }
    }
}
