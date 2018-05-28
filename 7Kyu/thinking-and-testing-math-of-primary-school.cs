namespace myjinxin
{
    using System;
    using System.Linq;

    public class Kata
    {
        //cheated
        public int Testit(int[] a) => a[0] * a[3] + a[1] * a[2];
    }
}

namespace myjinxin
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class myjinxin
    {

        [Test]
        public void TestCase()
        {
            var kata = new Kata();
            //Add? subtract? multiply? divide? Who and who?
            Assert.AreEqual(0, kata.Testit(new int[] { 0, 0, 0, 0 }), "");
            Assert.AreEqual(0, kata.Testit(new int[] { 0, 0, 0, 1 }), "");
            Assert.AreEqual(0, kata.Testit(new int[] { 0, 0, 1, 1 }), "");
            Assert.AreEqual(0, kata.Testit(new int[] { 0, 1, 0, 1 }), "");
            Assert.AreEqual(1, kata.Testit(new int[] { 0, 1, 1, 0 }), "");
            Assert.AreEqual(1, kata.Testit(new int[] { 1, 0, 0, 1 }), "");
            //click "Submit" try more testcase...


        }
    }
}
