using System;
using System.Runtime.Remoting.Messaging;

namespace _14.genericcollection
{
    class genericdelegateex2
    {
        public static void Main()
        {
            Func<double, double, double> findArea = (l, b) => l * b;
            Console.WriteLine($"The area of reactangle is : {findArea.Invoke(4.5, 3.2)}");
        }
    }
}
