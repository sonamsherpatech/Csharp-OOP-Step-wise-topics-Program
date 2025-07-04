using System;
//System Exception

namespace _16.Exception_and_Exception_handiling
{
    class NullReference
    {
        public static void Main()
        {
            try
            {
                string name = null;
                Console.WriteLine("The length of name is " + name.Length);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }finally
            {
                Console.WriteLine("End of task");
            }
            
        }
    }
    public class Format
    {
        public static void Main()
        {
            try
            {
                string name = "Sonam";
                int nameNumber = int.Parse(name);
                Console.WriteLine("My name in number is: " + nameNumber);
            }catch(FormatException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }finally
            {
                Console.WriteLine("End of an Exception");
            }
            
        }
    }
  

    class IndexOutOfRange
    {
        public static void Main()
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine($"The element at index 4 in array is{arr[3]}");
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }finally
            {
                Console.WriteLine("Task Completed");
            }
        }
    }


    class DivideByZero
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 5;
                int num2 = 5;
                double div = num1 / num2;
                Console.WriteLine($"The division of two numbers is {div}");
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Task Completed");
            }
        }
    }
}
