using MLewi.Models;

namespace MLewi.DesignPatterns.Creational
{
    public class BMWFactory : VehicleFactory
    {
        public override Car CreateCar() => new BMWCar();

        public override Motorcycle CreateMotorCycle() => new BMWMotorcycle();
    }

    public class SuzukiFactory : VehicleFactory
    {
        public override Car CreateCar() => new SuzukiCar();

        public override Motorcycle CreateMotorCycle() => new SuzukiMotorcycle();
    }

    public abstract class VehicleFactory
    {
        public abstract Car CreateCar();

        public abstract Motorcycle CreateMotorCycle();

        public string WhichVehicleIsTheCoolest()
        {
            var car = CreateCar();
            var motorcycle = CreateMotorCycle();

            return car.HowCoolAmI() > motorcycle.HowCoolAmI() ?
                car.Name :
                motorcycle.Name;
        }
    }

    /// <summary>
    /// Will play the role of Client which uses abstract factory to handle different types of vehicles
    /// </summary>
    public class VehiclesController
    {
        private VehicleFactory _factory;

        private Car _car { get; }
        private Motorcycle _motorcycle { get; }

        public VehiclesController(VehicleFactory factory)
        {
            _car = factory.CreateCar();
            _motorcycle = factory.CreateMotorCycle();

            _factory = factory;
        }

        public string GetCoolestProduct() => _factory.WhichVehicleIsTheCoolest();
    }
}