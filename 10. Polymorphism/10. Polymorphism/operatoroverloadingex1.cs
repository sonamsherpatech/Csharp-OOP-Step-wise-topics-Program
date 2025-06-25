using System;

namespace _10.Polymorphism
{
    public class Complex
    {
        public double real, img;
        public Complex(double real, double img)
        {
            this.real = real;
            this.img = img;
        } 

        //overload +
         public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.img + c2.img);
        }

        //overload -
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.img - c2.img);
        }
    }
    class operatoroverloadingex1
    {
        public static void Main()
        {
            Complex a = new Complex(2, 3);
            Complex b = new Complex(3, 5);
            Complex sum = a + b;
            Complex diff = a - b;

            Console.WriteLine("addition of two complex eqution");
            Console.WriteLine($"{sum.real} + {sum.img}i");
            Console.WriteLine("subtraction of two complex eqution");
            Console.WriteLine($"{diff.real} + {diff.img}i");
        }
    }
}
