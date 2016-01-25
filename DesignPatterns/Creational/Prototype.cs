namespace MLewi.DesignPatterns.Creational
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class ConcretePrototype : Prototype
    {
        public string Id { get; set; }

        public ConcretePrototype(string id)
        {
            Id = id;
        }

        public override Prototype Clone()
        {
            return MemberwiseClone() as Prototype;
        }
    }
}
