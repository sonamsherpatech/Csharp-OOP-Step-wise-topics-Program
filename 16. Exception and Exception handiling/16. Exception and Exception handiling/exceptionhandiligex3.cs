using System;

namespace _16.Exception_and_Exception_handiling
{
    //1. Define user defined exception by extending ApplicationException class
    public class BalanceException : ApplicationException
    {
        public BalanceException(string msg) : base(msg) { }
    }
    class exceptionhandiligex3
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter your balance: ");
                double totalBalance = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the withdrawl amount: ");
                double withdrawlAmount = double.Parse(Console.ReadLine());

                if(withdrawlAmount < totalBalance)
                {
                    totalBalance -= withdrawlAmount;
                    Console.WriteLine($"Rs.{withdrawlAmount} has been withdrawn\nRemaining Balance: {totalBalance}");
                } else
                {
                    throw new BalanceException("Insufficent balance");
                }
            }catch(BalanceException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            } finally
            {
                Console.WriteLine("End of transaction");
            }
        }
    }
}
