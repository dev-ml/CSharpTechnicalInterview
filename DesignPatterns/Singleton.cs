namespace DesignPatterns
{
    public class Singleton
    {
        #region Private Fields

        private static Singleton _instance;

        #endregion Private Fields

        #region Private Constructors

        private Singleton()
        {
        }

        #endregion Private Constructors

        #region Public Methods

        public static Singleton GetInstance()
        {
            return _instance = _instance ?? new Singleton();
        }

        public string SayHi(string name)
        {
            return $"Hi {name}";
        }

        #endregion Public Methods
    }
}