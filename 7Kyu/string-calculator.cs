using System;
using System.Linq;

public static class Kata
{
    public static int AddStrings(string numbers) => numbers.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Sum(s => int.Parse(s));
}

namespace Solution
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void LessThan10()
        {
            Assert.AreEqual(5, Kata.AddStrings("2, 3"));
        }

        [Test]
        public void Over50()
        {
            Assert.AreEqual(60, Kata.AddStrings("20, 20, 20"));
        }
    }
}
