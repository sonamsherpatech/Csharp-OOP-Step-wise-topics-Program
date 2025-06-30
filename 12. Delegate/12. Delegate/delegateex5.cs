using System;

namespace _12.Delegate
{
    class delegateex5
    {
        //1. Create method
        public static void LogToFile()
        {
            Console.WriteLine("Logging to file...");
        }

        public static void LogToDatabase()
        {
            Console.WriteLine("Logging to database...");
        }

        //2. Create delegate
        public delegate void Logger();

        public static void Main()
        {
            //3. Create instance of delegate
            Logger l1 = new Logger(LogToFile);

            //4. Invoke delegate
            l1();
            l1 += LogToDatabase;
            l1();
        }
    }
}
