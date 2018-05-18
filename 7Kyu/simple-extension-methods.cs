static class SimpleExtensions
{
    internal static string SayHello(this string s) => $"Hello, {s}!";
    internal static string SayGoodbye(this string s) => $"Goodbye, {s}. See you again soon!";
}

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void ExampleTests()
        {
            const string name = "Alex";
            Assert.AreEqual("Hello, Alex!", name.SayHello());
            Assert.AreEqual("Goodbye, Alex. See you again soon!", name.SayGoodbye());
        }
    }
}
