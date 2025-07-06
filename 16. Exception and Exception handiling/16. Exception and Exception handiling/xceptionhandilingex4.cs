using System;
//User-defined exception handiling

namespace _16.Exception_and_Exception_handiling
{
    public class LengthException : ApplicationException
    {
        public LengthException(string msg) : base(msg) { }
    }
    class xceptionhandilingex4
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter Your College Name: ");
                string cName = Console.ReadLine();

                if(cName.Length < 15)
                {
                    Console.WriteLine($"Your College Name is {cName}");
                }else
                {
                    throw new LengthException("College Name has letter greater than 15 Character");
                }
            }catch (LengthException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }finally
            {
                Console.WriteLine("End of task");
            }
        }
    }
}
