namespace MLewi.DesignPatterns.Creational
{
    // Seal the class to protect from initiating multiple instances via inheritance
    public sealed class Singleton
    {
        // Can also be initialized in static constructor. Both methods are Thread-safe,
        // Initializing in protected constructor would need extra effort to make it thread safe
        private readonly static Singleton _instance = new Singleton();

        // Private constructor so that no default constructor is created and make it possible to create multiple instances
        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return _instance;
        }

        // Hello World function
        public string SayHi(string name)
        {
            return $"Hi {name}";
        }
    }
}