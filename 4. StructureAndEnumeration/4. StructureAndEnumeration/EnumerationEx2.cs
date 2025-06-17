using System;

///<summary>
/// Create an enum called OrderStatus with Pending, Processing, Shipped, Delivered.
/// Write a method PrintStatusMessage(OrderStatus status) that:
/// Prints a different message for each status.
/// In Main:
/// Call PrintStatusMessage with at least two different OrderStatus values.
/// </summary>


namespace _4.StructureAndEnumeration
{
    enum OrderStatus { Pending, Processing, Shipped, Delivered }
    class EnumerationEx2
    {
        public static void PrintStatusMessage(OrderStatus status)
        {
            switch(status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("Your order has been received");
                    break;
                case OrderStatus.Processing:
                    Console.WriteLine("Your order is being processing");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("Your order has been shipped");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Your order has been delivered");
                    break;
                default:
                    Console.WriteLine("Make a order!");
                    break;

            }

            //if(status == OrderStatus.Pending)
            //{
            //    Console.WriteLine($"Your order has been received");
            //}
        }

        public static void Main()
        {
            PrintStatusMessage(OrderStatus.Pending);
            PrintStatusMessage(OrderStatus.Processing);
            PrintStatusMessage(OrderStatus.Shipped);
            PrintStatusMessage(OrderStatus.Delivered);
        }
    }
}
