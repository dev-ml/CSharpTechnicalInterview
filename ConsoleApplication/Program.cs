using MLewi.DesignPatterns.Creational;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.SayHi("Maciej"));

            // Builder
            var manufacturer = new CarManufacturer();

            var ferrariBuilder = new FerrariBuilder();
            var ferrari = manufacturer.Construct(ferrariBuilder);
            Console.WriteLine($"{ferrari} constructed");

            var fiatBuilder = new FiatBuilder();
            var fiat = manufacturer.Construct(fiatBuilder);
            Console.WriteLine($"{fiat} constructed");

            Console.ReadKey();
        }
    }
}
