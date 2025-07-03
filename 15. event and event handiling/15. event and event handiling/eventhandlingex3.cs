using System;

namespace _15.event_and_event_handiling
{
    //1. Define Delegate
    public delegate void ExamResult();

    //2. Define Publisher
    public class ExamDepartment
    {
        public event ExamResult er;

        public void ResultAnnouncement()
        {
            Console.WriteLine("Result Triggered");
            er?.Invoke();
        }
    }
    //3 Define Subscriber
    public class Student
    {
        public void sendMessage()
        {
            Console.WriteLine("I will check my result now");
        }
    }

    public class Parent
    {
        public void sendMessage()
        {
            Console.WriteLine("How did you do?");
        }
    }


    class eventhandlingex3
    {
        public static void Main()
        {
            ExamDepartment ed = new ExamDepartment();
            Student s1 = new Student();
            Parent p1 = new Parent();

            ed.er += s1.sendMessage;
            ed.er += p1.sendMessage;

            ed.ResultAnnouncement();
        }
    }
}
