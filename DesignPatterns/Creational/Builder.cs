using MLewi.Models;

namespace MLewi.DesignPatterns.Creational
{
    // ConcreteBuilder: Concrete classes that will create the complex Product.this will keep track
    //                  of what Product it has created i.e.assembled what parts and this will be
    //                  used by the client to get the Product object.
    // Builder: This is the interface for creating the actual products
    // Director: This is the Client code that will specify the parts needs to be put tegether to to
    //           create the actual concrete Product.
    // Product: This is the object that will be created by assembling many parts.

    public interface ICarBuilder
    {
        Car Car { get; }

        void BuildChassis();

        void BuildDoors();

        void BuildEngine();

        void BuildFuelTank();
    }

    public class CarManufacturer
    {
        public Car Construct(ICarBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildDoors();
            builder.BuildEngine();
            builder.BuildFuelTank();
            return builder.Car;
        }
    }

    public class FerrariBuilder : ICarBuilder
    {
        public Car Car { get; }

        public FerrariBuilder()
        {
            Car = new Car("Ferrari");
        }

        public void BuildChassis()
        {
            Car.Chassis = ChassisType.Aluminium;
        }

        public void BuildDoors()
        {
            Car.Doors = 2;
        }

        public void BuildEngine()
        {
            Car.Engine = EngineType.V12;
        }

        public void BuildFuelTank()
        {
            Car.Fuel = FuelType.Benzine;
        }
    }

    public class FiatBuilder : ICarBuilder
    {
        public Car Car { get; }

        public FiatBuilder()
        {
            Car = new Car("Fiat");
        }

        public void BuildChassis()
        {
            Car.Chassis = ChassisType.Iron;
        }

        public void BuildDoors()
        {
            Car.Doors = 5;
        }

        public void BuildEngine()
        {
            Car.Engine = EngineType.V4;
        }

        public void BuildFuelTank()
        {
            Car.Fuel = FuelType.Diesel;
        }
    }
}