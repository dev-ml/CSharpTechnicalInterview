using System;

namespace MLewi.DesignPatterns.Creational
{
    // Now lets see what each class in the above class diagram is meant for

    // ConcreteBuilder: Concrete classes that will create the complex Product.this will keep track
    //                  of what Product it has created i.e.assembled what parts and this will be
    //                  used by the client to get the Product object.
    // Builder: This is the interface for creating the actual products
    // Director: This is the Client code that will specify the parts needs to be put tegether to to
    //           create the actual concrete Product.
    // Product: This is the object that will be created by assembling many parts.

    #region Product Part Types

    public enum EngineType
    {
        V4,
        V6,
        V8,
        V12
    }

    public enum FuelType
    {
        Benzine,
        Diesel,
        Gas
    }

    public enum ChassisType
    {
        Iron,
        Magnesium,
        Aluminium,
        CarbonFibre
    }

    #endregion

    #region Concrete Product

    public class Car
    {
        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public EngineType Engine { get; set; }
        public ChassisType Chassis { get; set; }
        public FuelType Fuel { get; set; }
        public int Doors { get; set; }

        public override string ToString()
        {
            return $"{Name}. {Engine} {Fuel} engine, {Chassis} chassis and {Doors} doors.";
        }
    }

    #endregion

    #region Builder interface and Concrete Builders

    public interface ICarBuilder
    {
        void BuildEngine();
        void BuildFuelTank();
        void BuildChassis();
        void BuildDoors();
        Car Car { get; }
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

    #endregion

    #region Director Manufacture class

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

    #endregion
}