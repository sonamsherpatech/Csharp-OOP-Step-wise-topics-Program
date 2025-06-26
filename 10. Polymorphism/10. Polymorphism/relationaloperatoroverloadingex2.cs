using System;

namespace _10.Polymorphism
{
    public class Number
    {
        int num;
        public Number(int num)
        {
            this.num = num;
        }

        //overload ==
        public static bool operator ==(Number n1, Number n2)
        {
            if (n1.num == n2.num) return true;
            return false;
        }

        //overload !=
        public static bool operator !=(Number n1, Number n2)
        {
            if (n1.num != n2.num) return true;
            return false;
        }
    }
    class relationaloperatoroverloadingex2
    {
        public static void Main()
        {
            Number n1 = new Number(5);
            Number n2 = new Number(6);
            Number n3 = new Number(5);

            if(n1 == n2)
            {
                Console.WriteLine("n1 and n2 are equal");
            }

            if(n1 == n3)
            {
                Console.WriteLine("n1 and n3 are equal");
            }
            
            if(n1 != n2)
            {
                Console.WriteLine("n1 and n2 are not equal");
            }

            if(n2 != n3)
            {
                Console.WriteLine("n2 and n3 are not equal");
            }
        }
    }
}
