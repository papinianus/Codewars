using System;
using System.Linq;

public static class Kata
{
    public static string ReverseWords(string str) => string.Join(" ", str.Split().Select(w => string.Concat(w.Reverse())));
}

namespace Solution
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual("sihT si na !elpmaxe", Kata.ReverseWords("This is an example!"));
        }
    }
}