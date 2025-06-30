using System;
//Single Cast Delegate

namespace _12.Delegate
{
    class delegateex2
    {
        //1. Define method
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        //2. Define Delegate
        public delegate void GreetDelegate(string name);

        public static void Main()
        {
            //3. Create an instance of Delegate
            GreetDelegate gd1 = new GreetDelegate(SayHello);

            //4. Invoke or Call Delegate
            gd1("Sonam");
        }
    }
}
