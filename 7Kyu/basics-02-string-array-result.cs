namespace smile67Kata
{
    using System;
    using System.Linq;

    public class Kata
    {
        static int r = 0;
        public string calculateArray(string stringArray) => $"{(int)Math.Round((double)stringArray.Split(';').Sum(x => (int.TryParse(x, out r) ? r : 0)) / stringArray.Split(';').Count(x => int.TryParse(x, out r)))},{((int)Math.Round((double)stringArray.Split(';').Sum(x => (int.TryParse(x, out r) ? r : 0)) / stringArray.Split(';').Count(x => int.TryParse(x, out r)))).ToString().Sum(char.GetNumericValue)},{((((int)Math.Round((double)stringArray.Split(';').Sum(x => (int.TryParse(x, out r) ? r : 0)) / stringArray.Split(';').Count(x => int.TryParse(x, out r)))).ToString().Sum(char.GetNumericValue) % 5 == 0) ? "TRUE" : "FALSE")}";
    }
}

namespace smile67Kata
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class smile67KataTest
    {
        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual("745277,32,FALSE", new Kata().calculateArray("1;2;4;7;11;100;15;451;662;774;2227;11;-120;14446451;662;774;342227;2311;123420;-14446"));
        }
        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual("422706,21,FALSE", new Kata().calculateArray("4wre51;645462;776774;-2227;16165;-456120;14446;5765671;882;477;766;141;100;18;645;dfg;;-100;200"));
        }
        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual("500,5,TRUE", new Kata().calculateArray("-500;500;1500;-;+;;;abc"));
        }
    }
}

