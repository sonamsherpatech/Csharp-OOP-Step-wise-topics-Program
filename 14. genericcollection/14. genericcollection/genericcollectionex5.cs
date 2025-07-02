using System;

namespace _14.genericcollection
{
    class genericcollectionex5
    {
        public static void Main()
        {
            Func<int, int, int> addNumber = (a, b) => a + b;
            int res = addNumber.Invoke(4, 6);

            Predicate<int> isEven = (num) => num % 2 == 0;
            bool resbool = isEven.Invoke(res);

            Action<bool> result = (rb) =>
            {
                if(rb)
                {
                    Console.WriteLine($"{res} is even");
                }else
                {
                    Console.WriteLine($"{res} is odd");
                }
            };

            result(resbool);

            
        }
    }
}
