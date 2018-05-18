using System;
using System.Linq;

public class Kata
{
    public static string Battle(string x, string y) => x.Select(Power).Sum() > y.Select(Power).Sum() ? x : x.Select(Power).Sum() < y.Select(Power).Sum() ? y : "Tie!";

    private static int Power(char c) => char.IsUpper(c) ? (c - 'A') + 1 : 0;
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
