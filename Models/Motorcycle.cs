namespace MLewi.Models
{
    public class BMWMotorcycle : Motorcycle
    {
        public BMWMotorcycle() : base("BMW Motorcycle")
        { }

        public override int HowCoolAmI() => int.MinValue;
    }

    public class Motorcycle
    {
        public ChassisType Chassis { get; set; }

        public EngineType Engine { get; set; }

        public FuelType Fuel { get; set; }

        public string Name { get; }

        public Motorcycle(string name)
        {
            Name = name;
        }

        public virtual int HowCoolAmI() => 0;

        public override string ToString() => $"{Name}. {Engine} {Fuel} engine, {Chassis} chassis.";
    }

    public class SuzukiMotorcycle : Motorcycle
    {
        public SuzukiMotorcycle() : base("Suzuki Motorcycle")
        { }

        public override int HowCoolAmI() => int.MaxValue;
    }
}