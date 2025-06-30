
using System;
//Single Cast Delegate
namespace _12.Delegate
{
    class delegateex1
    {
        // 1. Define Mehtod
        public static int FindSquare(int n)
        {
            return n * n;
        }

        //2. Define Delegate
        public delegate int SquareDelegate(int n);

        static void Main(string[] args)
        {
            //3. Create instanceof Delegate
            SquareDelegate sd1 = new SquareDelegate(FindSquare);

            //4. Invoke or Call the delegate
            Console.WriteLine($"The square of 4 is {sd1(4)}");
        }
    }
}
