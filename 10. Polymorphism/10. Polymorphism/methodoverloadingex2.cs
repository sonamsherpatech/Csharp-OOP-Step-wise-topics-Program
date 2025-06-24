using System;

namespace _10.Polymorphism
{
    public class TemperatureConverter
    {
        public double Convert(double c)
        {
            return ((c * 9 / 5) + 32);
        }

        public double Convert(double f, bool isFahrenheit)
        {
            if (isFahrenheit) return ((f - 32) * 5 / 9);
            else return f;
        }

        public double Convert(double c, string toScale)
        {
            if (toScale.ToLower() == "kelvin")
            {
                return c + 273.15;
            }else
            {
                return c;
            }
        }
    }
    class methodoverloadingex2
    {
        public static void Main()
        {
            TemperatureConverter t = new TemperatureConverter();
            Console.WriteLine($"The conversion of 3 deg Celsius to Fahrenhite is {t.Convert(3)}");
            Console.WriteLine($"The conversion of 45 def Fahrenhite to Celsius is {t.Convert(45, true)}");
            Console.WriteLine($"The conversion of 34 deg Celsius to Kelvin is {t.Convert(34, "kelvin")}");
        }
    }
}
