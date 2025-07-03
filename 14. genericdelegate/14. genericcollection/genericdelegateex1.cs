using System;

//Action delegate
namespace _14.genericcollection
{
    class genericdelegateex1
    {
        static void Main(string[] args)
        {
            Action<string> greet = (name) => Console.WriteLine("Welcome " + name);
            greet.Invoke("Sonam");
        }
    }
}
