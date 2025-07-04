using System;
// Nested try catch


namespace _16.Exception_and_Exception_handiling
{
    class exceptionhandilingex2
    {
        public static void Main() { 
            try
            {
                Console.WriteLine("Outer try block");
                try
                {
                    Console.WriteLine("Inner try block");
                    int[] arr = { 1, 2, 3 };
                    Console.WriteLine($"The element at 3rd index is {arr[3]}");
                }catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }finally
                {
                    Console.WriteLine("Inner try-catch block task complteted");
                }
                int n1 = 3;
                int n2 = 0;
                Console.WriteLine("The division between two number is " + n1 / n2);
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                Console.WriteLine("End of task for outer block");
            }
        }

    }
}
