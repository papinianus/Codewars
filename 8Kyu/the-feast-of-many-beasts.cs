using System;
using System.Linq;

public class Kata
{
    public static bool Feast(string beast, string dish) => beast.First() == dish.First() && beast.Last() == dish.Last();
}

namespace Solution
{
    using NUnit.Framework;


    [TestFixture]
    public class Tests
    {
        [TestCase("great blue heron", "garlic naan")]
        [TestCase("chickadee", "chocolate cake")]
        public void BasicTestsTrue(string beast, string dish)
        {
            Assert.IsTrue(Kata.Feast(beast, dish));
        }

        [TestCase("brown bear", "bear claw")]
        public void BasicTestsFalse(string beast, string dish)
        {
            Assert.IsFalse(Kata.Feast(beast, dish));
        }
    }
}