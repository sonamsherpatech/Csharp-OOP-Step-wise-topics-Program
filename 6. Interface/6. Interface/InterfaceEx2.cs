using System;

namespace _6.Interface
{
    interface IPayment
    {
        void Pay(double amount);
        void PaymentDetails();
    }

    public class CreditCardPayment : IPayment
    {
        public int cardNumber;
        public string cardHolderName;

        public CreditCardPayment(int cardNumber, string cardHolderName)
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card");
        }

        public void PaymentDetails()
        {
            Console.WriteLine($"Card Number: {cardNumber}\n Card Holder Name: {cardHolderName}");
        }
    }

    public class UPIPayment : IPayment
    {
        public string uppid;

        public UPIPayment(string uppid)
        {
            this.uppid = uppid;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using UPI");
        }

        public void PaymentDetails()
        {
            Console.WriteLine($"Card UPPID: {uppid}");
        }
    }

    class InterfaceEx2
    {
        public static void Main()
        {
            Console.WriteLine("Credit Card");
            CreditCardPayment c1 = new CreditCardPayment(12500, "Sonam Sherpa");
            c1.Pay(500);
            c1.PaymentDetails();

            Console.WriteLine("UPI");
            UPIPayment u1 = new UPIPayment("06rr054");
            u1.Pay(450);
            u1.PaymentDetails();
        }
    }
}
