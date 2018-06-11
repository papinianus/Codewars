using System;
using System.Linq;

public static class Kata
{
  public static string GenerateShape(int n) => string.Join(Environment.NewLine, Enumerable.Repeat(string.Join(string.Empty, Enumerable.Repeat("+",n)), n));
}


namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("", Kata.GenerateShape(0));
      Assert.AreEqual("+", Kata.GenerateShape(1));
      Assert.AreEqual("++\n++", Kata.GenerateShape(2));
      Assert.AreEqual("+++\n+++\n+++", Kata.GenerateShape(3));
    }
  }
}
