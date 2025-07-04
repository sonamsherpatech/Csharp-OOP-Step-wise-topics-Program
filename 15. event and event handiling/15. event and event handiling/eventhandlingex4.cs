using System;

namespace _15.event_and_event_handiling
{
    //1. Create Delegate
    public delegate void DoorBellHandler();

    //2. Create Publisher Calss
    public class DoorBell
    {
        public event DoorBellHandler db1;

        public void BellRing()
        {
            Console.WriteLine("Bell is runged");
            db1?.Invoke();
        }
    }

    //3. Create Subscriber Class
    public class Resident { 
        public void sendMessage()
        {
            Console.WriteLine("Let me open the door");
        }
    }

    public class Dog
    {
        public void sendMessage()
        {
            Console.WriteLine("Bark");
        }
    }
    class eventhandlingex4
    {
        public static void Main()
        {
            Resident r1 = new Resident();
            Dog d1 = new Dog();
            DoorBell db = new DoorBell();
            db.db1 += r1.sendMessage;
            db.db1 += d1.sendMessage;

            db.BellRing();
        }
    }
}
