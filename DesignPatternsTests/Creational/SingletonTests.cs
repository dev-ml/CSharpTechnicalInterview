using NUnit.Framework;

namespace MLewi.DesignPatterns.Creational.Tests
{
    [TestFixture()]
    public class SingletonTests
    {
        [Test()]
        public void GetInstance_ReturnsNotNullSingleton()
        {
            var singleton = Singleton.GetInstance();
            Assert.That(singleton, Is.Not.Null);
        }
        
        [Test()]
        public void GetInstance_CallingItTwiceReturnsTheSameObject()
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            Assert.That(singleton1, Is.EqualTo(singleton2));
        }
    }
}