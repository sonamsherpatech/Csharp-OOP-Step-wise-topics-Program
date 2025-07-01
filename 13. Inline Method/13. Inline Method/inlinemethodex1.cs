using System;

//Anonymous MEthod
namespace _13.Inline_Method
{
    class inlinemethodex1
    {
        public delegate int AddNumber(int x, int y);
        static void Main(string[] args)
        {
            AddNumber a1 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine($"The sum of two digit: {a1.Invoke(5, 4)}");
        }
    }
}
