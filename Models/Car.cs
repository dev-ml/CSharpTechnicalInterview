namespace MLewi.Models
{
    public class BMWCar : Car
    {
        public BMWCar() : base("BMW Car")
        { }

        public override int HowCoolAmI() => int.MaxValue;
    }

    public class Car
    {
        public ChassisType Chassis { get; set; }

        public int Doors { get; set; }

        public EngineType Engine { get; set; }

        public FuelType Fuel { get; set; }

        public string Name { get; }

        public Car(string name)
        {
            Name = name;
        }

        public virtual int HowCoolAmI() => 0;

        public override string ToString() => $"{Name}. {Engine} {Fuel} engine, {Chassis} chassis and {Doors} doors.";
    }

    public class SuzukiCar : Car
    {
        public SuzukiCar() : base("Suzuki Car")
        { }

        public override int HowCoolAmI() => int.MinValue;
    }
}