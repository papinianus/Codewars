using System;

public class Kata
{
    private static Random _random = new Random();

    public int GenerateRandomNumber() => _random.Next(0, 1000);
}

namespace Solution
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class MyTest
    {
        [Test]
        public void FirstTest()
        {
            Kata kata1 = new Kata();
            Kata kata2 = new Kata();
            Assert.AreNotEqual(kata1.GenerateRandomNumber(), kata2.GenerateRandomNumber());
        }
    }
}
