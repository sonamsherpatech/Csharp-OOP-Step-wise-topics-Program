using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{ 
    public class Time
    {
        public int hour, minute, second;

        public Time() { }
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public Time AddTime(Time t)
        {
            Time temp = new Time();
            int total1 = this.hour * 3600 + this.minute * 60 + this.second;
            int total2 = t.hour * 3600 + t.minute * 60 + t.second;
            int addTime = total1 + total2;

            temp.hour = addTime / 3600;
            addTime %= 3600;
            temp.minute = addTime / 60;
            temp.second = addTime %= 60;
            return temp;
        }


        public void DisplayTime()
        {
            Console.WriteLine($"H::M::S {this.hour}::{this.minute}::{this.second}");
        }



    }
    class ConstructorEx1
    {
        public static void Main()
        {
            Time t1 = new Time(4, 20, 20);
            Time t2 = new Time(2, 10, 30);

            Time t3 = t1.AddTime(t2);
            t3.DisplayTime();
        }
    }
}
