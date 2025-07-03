using System;

namespace _15.event_and_event_handiling
{
    //1. Define Delegate
    public delegate void TempearatureMonitor();

    //2. Define Publisher Class with event within it
    public class TemperatureSensor
    {
        public event TempearatureMonitor tm;
        private double temp = 35;
        public double Temp
        {
            get { return temp; }
            set
            {
                temp = value;
                if(temp > 40)
                {
                    tm?.Invoke();
                }
            }
        }   
    }

    //Subscriber class
    public class Fan
    {
        public void sendMessage()
        {
            Console.WriteLine("Do you need Fan? Since Temperature has exceeded 40 deg Celsius");
        }
    }

    public class AC
    {
        public void sendMessage()
        {
            Console.WriteLine("Do you need AC? Since Temperature has exceeded 40 deg Celsius");
        }
    }


    class eventhandlingex2
    {
        public static void Main()
        {
            AC a1 = new AC();
            Fan f1 = new Fan();
            TemperatureSensor ts = new TemperatureSensor ();
            
            ts.tm += a1.sendMessage;
            ts.tm += f1.sendMessage;

            ts.Temp = 45;
        }
    }
}
