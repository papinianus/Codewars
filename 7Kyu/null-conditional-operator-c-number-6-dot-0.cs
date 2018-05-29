using System;
using System.Linq;

public static class CarInformation
{
    public static int GetNumberOfGears(this Car car) => car?.Engine?.GearBox?.NumberOfGears ?? -1;
}

namespace Solution
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestGears()
        {
            var car = new Car
            {
                Engine = new Engine
                {
                    GearBox = new GearBox
                    {
                        NumberOfGears = 5
                    }
                }
            };
            Assert.AreEqual(5, car.GetNumberOfGears());
        }

        [Test]
        public void TestNullEngine()
        {
            var car = new Car();
            Assert.AreEqual(-1, car.GetNumberOfGears());
        }
    }
}
