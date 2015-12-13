using MLewi.DesignPatterns.Creational;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.SayHi("Maciej"));

            Console.ReadKey();
        }
    }
}
