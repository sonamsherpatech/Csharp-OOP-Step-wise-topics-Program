using System;
//MultiCast Delgate

namespace _12.Delegate
{
    class delegateex4
    {
        //1. Create Method
        public static void Add(int x, int y)
        {
            Console.WriteLine($"The sum of {x} and {y} is {x + y}");
        }

        public static void Multiply(int x, int y)
        {
            Console.WriteLine($"The product of {x} and {y} is {x * y}");
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine($"The difference of {x} and {y} is {x - y}");
        }

        public static void Divide(int x, int y)
        {
            Console.WriteLine($"The division of {x} and {y} is {x / y}");
        }

        //2. Define Delegate
        public delegate void CalculatorDelegate(int x, int y);
    
    public static void Main()
        {
            //3. Create instance of delegate
            CalculatorDelegate cd1 = new CalculatorDelegate(Add);
            CalculatorDelegate cd2 = new CalculatorDelegate(Subtract);
            CalculatorDelegate cd3 = new CalculatorDelegate(Multiply);
            CalculatorDelegate cd4 = new CalculatorDelegate(Divide);

            CalculatorDelegate cd = cd1 + cd2 + cd3 + cd4;

            //4. Call the delegate 
            cd.DynamicInvoke(16, 4);
        }
    }
}
