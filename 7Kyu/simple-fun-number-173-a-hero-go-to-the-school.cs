namespace myjinxin
{
    using System;
    using System.Linq;
    public class Kata
    {
        public int WhichBusToTake(string[] BusesColors, bool[] GoingToSchool) => BusesColors.Select((x, i) => new {Col = x, Idx = i}).Zip(GoingToSchool, (col, go) => new {Idx = col.Idx, Col = col.Col, IsSchool = go}).Where(x=> x.IsSchool == true).OrderBy(x=>x.Idx).FirstOrDefault(x=>x.Col == "red")?.Idx ?? BusesColors.Select((x, i) => new {Col = x, Idx = i}).Zip(GoingToSchool, (col, go) => new {Idx = col.Idx, Col = col.Col, IsSchool = go}).Where(x=> x.IsSchool == true).OrderBy(x=>x.Idx).First().Idx;
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
        public void BasicTests()
        {
            var kata=new Kata();
      
            Assert.AreEqual(0,kata.WhichBusToTake(new string[]{"red","red","blue"},new bool[]{true, true, true}));

            Assert.AreEqual(3,kata.WhichBusToTake(new string[]{"blue","blue","blue","red","red"},new bool[]{false, true, true, true, false}));

            Assert.AreEqual(5,kata.WhichBusToTake(new string[]{"blue","red","red","red","blue","red","blue"},new bool[]{true, false, false, false, true, true, false}));

            Assert.AreEqual(3,kata.WhichBusToTake(new string[]{"red","red","red","blue"},new bool[]{false, false, false, true}));
        }
    }
}
