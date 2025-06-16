///<summary>
/// Class is the description of objects propety and behaviour.
/// Class is the collection of self contained independent variable(property) and method(member function) which works together to perform one or more specific tasks
/// 
/// 
/// Objec is the real world entity or instance of class and consumes memory
/// Once class is defined then object is created using new keyword
/// Then Object can access the property and method via (.) dot operator
/// </summary>
using System;

namespace Unit_3_ClassesAndObject
{
    public class Box
    {
        int length, breadth, height;
        public void SetProperty(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }


        public int FindArea()
        {
            return 2 * (this.length * this.breadth + this.breadth * this.height + this.height * this.length);
        }

        public int FindVolume()
        {
            return this.length * this.breadth * this.height;
        }

    }

        class Program
        {
        static void Main()
        {
            Box b1 = new Box();
            b1.SetProperty(4, 5, 6);
            Console.WriteLine($"The Area of Box is {b1.FindArea()}");
            Console.WriteLine($"The Volume of Box is {b1.FindVolume()}");
        }
    }
}
