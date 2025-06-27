using System;

namespace _10.Polymorphism
{
    public class BankAccount
    {
        public double amount;

        public BankAccount() { }

        public BankAccount(double amount)
        {
            this.amount = amount;
        }

        public virtual double CalculateInterest()
        {
            return 0.0;
        }
    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double amount) : base(amount) { }

        public override double CalculateInterest()
        {
            return base.amount * 0.05;
        }
    }

    public class FixedDepositAmount : BankAccount
    {
        public FixedDepositAmount(double amount) : base(amount) { }

        public override double CalculateInterest()
        {
            return base.amount * 0.08;
        }
    }
    class methodoverridingex3
    {
        public static void Main()
        {
            SavingsAccount s1 = new SavingsAccount(50000);
            Console.WriteLine($"Interest in Saving Account {s1.CalculateInterest()}");

            FixedDepositAmount f1 = new FixedDepositAmount(45000);
            Console.WriteLine($"Interest in Fixed Deposite Amount {f1.CalculateInterest()}");
        }
    }
}
