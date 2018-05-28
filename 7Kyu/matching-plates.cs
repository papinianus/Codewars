using System;
using System.Linq;

class Kata
{
    public static bool matchingPlates(char[] meals, char[] stack) => meals.SequenceEqual(stack.Take(meals.Count()));
}


namespace Solution
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    class KataTest
    {

        [Test]
        public void KataTests()
        {
            Assert.AreEqual(true, Kata.matchingPlates(new char[] { 'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b' }, new char[] { 'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b' }));
            Assert.AreEqual(false, Kata.matchingPlates(new char[] { 'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b' }, new char[] { 'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b' }));
        }
    }
}
