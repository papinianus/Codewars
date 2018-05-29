using System;
using System.Linq;

public class Kata
{
    public static bool OnlyOne(params bool[] flags) => flags.Count(b => b) == 1;
}

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, Kata.OnlyOne(true, false));
        }
    }
}
