using System;

//Lambda expression
namespace _13.Inline_Method
{
    class inlinemethodex4
    {
        public delegate int FactorialDelegate(int x);

        public static  void Main()
        {
            FactorialDelegate d1 = (int x) =>
            {
                int f = 1;
                for (int i = 1; i <= x; i++)
                {
                    f *= i;
                }
                return f;
            };

            Console.WriteLine($"The Factorial of 5 is {d1.Invoke(5)}");
        }
    }
}
