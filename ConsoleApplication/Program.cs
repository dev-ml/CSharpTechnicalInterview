using MLewi.DesignPatterns.Creational;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            Console.WriteLine("/// Singleton");
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.SayHi("Maciej"));
            Console.WriteLine();

            // Builder
            Console.WriteLine("/// Builder");
            var manufacturer = new CarManufacturer();

            var ferrariBuilder = new FerrariBuilder();
            var ferrari = manufacturer.Construct(ferrariBuilder);
            Console.WriteLine($"{ferrari} constructed");

            var fiatBuilder = new FiatBuilder();
            var fiat = manufacturer.Construct(fiatBuilder);
            Console.WriteLine($"{fiat} constructed");
            Console.WriteLine();

            // AbstractFactory
            Console.WriteLine("/// Abstract Factory");
            var bmwFactory = new BMWFactory();
            var suzukiFactory = new SuzukiFactory();

            var bmwController = new VehiclesController(bmwFactory);
            Console.WriteLine($"Coolest BMW product is: {bmwController.GetCoolestProduct()}");

            var suzukiController = new VehiclesController(suzukiFactory);
            Console.WriteLine($"Coolest Suzuki product is: {suzukiController.GetCoolestProduct()}");
            Console.WriteLine();

            // Factory Method
            Console.WriteLine("/// Factory Method");
            var factories = new VehicleFactory[2];
            factories[0] = new BMWFactory();
            factories[1] = new SuzukiFactory();

            foreach (var factory in factories)
            {
                var carProduct = factory.CreateCar();
                Console.WriteLine($"Factory {factory.GetType().Name} produced: {carProduct.Name}");
            }
            Console.WriteLine();

            // Prototype
            Console.WriteLine("/// Prototype");
            var original = new ConcretePrototype("original");
            var copy = original.Clone() as ConcretePrototype;
            Console.WriteLine($"Original: {original.Id}. Clone: {copy.Id}.");
            Console.WriteLine();

            // END
            Console.ReadKey();
        }
    }
}
