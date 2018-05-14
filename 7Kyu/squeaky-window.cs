namespace myjinxin
{
    using System;
    using System.Linq;
    public class Kata
    {
        public int WhichBusToTake(string[] BusesColors, bool[] GoingToSchool) => BusesColors.Select((x, i) => new {Col = x, Idx = i}).Zip(GoingToSchool, (col, go) => new {Idx = col.Idx, Col = col.Col, IsSchool = go}).Where(x=> x.IsSchool == true).OrderBy(x=>x.Idx).FirstOrDefault(x=>x.Col == "red")?.Idx ?? BusesColors.Select((x, i) => new {Col = x, Idx = i}).Zip(GoingToSchool, (col, go) => new {Idx = col.Idx, Col = col.Col, IsSchool = go}).Where(x=> x.IsSchool == true).OrderBy(x=>x.Idx).First().Idx;
    }
}

namespace Solution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    [TestFixture]
    public class SlidingTest
    {
        [Test(Description = "Initial Tests")]
        public void Test1()
        {
            Assert.AreEqual(new[] { 3, 3, 5, 5, 6, 7 }, Kata.Sliding(new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3));
            Assert.AreEqual(new[] { 7, 7, 7, 7, 7 }, Kata.Sliding(new[] { -7, -8, 7, 5, 7, 1, 6, 0 }, 4));
            Assert.AreEqual(new[] { 7, 4 }, Kata.Sliding(new[] { 7, 2, 4 }, 2));
            Assert.AreEqual(new[] { 11 }, Kata.Sliding(new[] { 9, 11 }, 2));
            Assert.AreEqual(new[] { 9, 11, 12 }, Kata.Sliding(new[] { 9, 11, 12 }, 1));
            Assert.AreEqual(null, Kata.Sliding(Enumerable.Empty<int>().ToArray(), -1));
            Assert.AreEqual(null, Kata.Sliding(Enumerable.Empty<int>().ToArray(), 50));
            Assert.AreEqual(new[] { -1 }, Kata.Sliding(new[] { -1, -2, -3 }, 3));
            Assert.AreEqual(new[] { -1, -2, -3 }, Kata.Sliding(new[] { -1, -2, -3 }, 1));
        }
    }
}
