using System;
using System.Linq;

public class Kata
{
    public short expressionsMatter(short a, short b, short c) => (new[] { a * b * c, (a + b) * c, a * (b + c), a + b + c }).Max();
}


namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class ExpressionsMatter
  {
    Kata solution = new Kata();
    [Test]
    public void checkSmallValues()
    {
      Assert.AreEqual(solution.expressionsMatter(2,1,2), 6);
      Assert.AreEqual(solution.expressionsMatter(1,1,1), 3);
      Assert.AreEqual(solution.expressionsMatter(2,1,1), 4);
      Assert.AreEqual(solution.expressionsMatter(1,2,3), 9);
      Assert.AreEqual(solution.expressionsMatter(1,3,1), 5);
      Assert.AreEqual(solution.expressionsMatter(2,2,2), 8);   
    }
    [Test]
    public void checkIntermediateValues()
    {
      Assert.AreEqual(solution.expressionsMatter(5,1,3), 20);
      Assert.AreEqual(solution.expressionsMatter(3,5,7), 105);
      Assert.AreEqual(solution.expressionsMatter(5,6,1), 35);
      Assert.AreEqual(solution.expressionsMatter(1,6,1), 8);
      Assert.AreEqual(solution.expressionsMatter(2,6,1), 14);
      Assert.AreEqual(solution.expressionsMatter(6,7,1), 48);   
    }
    [Test]
    public void checkMixedValues()
    {
      Assert.AreEqual(solution.expressionsMatter(2,10,3), 60);
      Assert.AreEqual(solution.expressionsMatter(1,8,3), 27);
      Assert.AreEqual(solution.expressionsMatter(9,7,2), 126);
      Assert.AreEqual(solution.expressionsMatter(1,1,10), 20);
      Assert.AreEqual(solution.expressionsMatter(9,1,1), 18);
      Assert.AreEqual(solution.expressionsMatter(10,5,6), 300);   
      Assert.AreEqual(solution.expressionsMatter(1,10,1), 12); 
    }
  }
}