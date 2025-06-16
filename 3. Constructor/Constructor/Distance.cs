using System;

namespace Constructor
{
    public class Distance
    {
        public int feet, inch;

        public Distance()
        {

        }

        public Distance(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }

        public Distance AddDistance(Distance d)
        {
            Distance temp = new Distance();
            //int feet = this.feet + d.feet;
            //int inch = this.inch + d.inch;

            int total1 = this.feet * 12 + this.inch;
            int total2 = d.feet * 12 + d.inch;
            int addDistance = total1 + total2;

            temp.inch = addDistance % 12;
            addDistance /= 12;
            temp.feet = addDistance;
            return temp;
        }



        public void DisplayDistance()
        {
            Console.WriteLine($"Feet: {this.feet} Inch: {this.inch}");
        }
    }



    class ConstructorEx
    {
        public static void Main()
        {
            Distance d1 = new Distance(4, 5);
            Distance d2 = new Distance(5, 8);

            Distance d3 = d1.AddDistance(d2);
            Console.WriteLine($"Distance after adding:");
            d3.DisplayDistance();
        }
    }
}
