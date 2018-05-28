public class Kata
{
    public static bool NegationValue(string str, bool value) => (str.Length % 2 == 0) ? value : !value;
}
namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Z", Kata.Battle("AAA", "Z"));
            Assert.AreEqual("TWO", Kata.Battle("ONE", "TWO"));
            Assert.AreEqual("Tie!", Kata.Battle("ONE", "NEO"));
            Assert.AreEqual("FOUR", Kata.Battle("FOUR", "FIVE"));
        }
    }
}
