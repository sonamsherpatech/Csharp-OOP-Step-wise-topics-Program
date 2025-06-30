using System;
//MultiCast Delegate
namespace _12.Delegate
{
    class delegateex3
    {
        //1. Define method
        public static int square(int n)
        {
            return n * n;
        }

        public static int factorial(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }

        //2. Define Delegate 
        public delegate int MultiCastDelegate(int n);

        public static void Main()
        {
            //3. Create instance of delegate
            MultiCastDelegate mcd = new MultiCastDelegate(square);

            //4. Call or Invoke delegate
            Console.WriteLine($"The square of 5 is {mcd(5)}");

            mcd += factorial;
            Console.WriteLine($"The factorial of 5 is {mcd(5)}");

            mcd -= factorial;
            Console.WriteLine($"The square of 7 is {mcd(7)}");

        }
    }
}
