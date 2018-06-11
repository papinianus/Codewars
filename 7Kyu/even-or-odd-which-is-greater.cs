using System;
using System.Linq;
public class EvenOrOddKata
{
	public static string EvenOrOdd(string str) => (str.Select(c => char.GetNumericValue(c)).Where(i => i % 2 == 0).Sum() > str.Select(c => char.GetNumericValue(c)).Where(i => i % 2 == 1).Sum())
        ? "Even is greater than Odd"
        : (str.Select(c => char.GetNumericValue(c)).Where(i => i % 2 == 0).Sum() < str.Select(c => char.GetNumericValue(c)).Where(i => i % 2 == 1).Sum())
            ? "Odd is greater than Even"
            : "Even and Odd are the same";
}

namespace Solution {
  using NUnit.Framework;
  using System;

  // TODO: Replace examples and use TDD development by writing your own tests

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    [TestCase("123", "Odd is greater than Even")]
    [TestCase("12", "Even is greater than Odd")]
    [TestCase("112", "Even and Odd are the same")]
    public void BasicTests(string input, string expectedResult)
    {
      Assert.AreEqual(expectedResult, EvenOrOddKata.EvenOrOdd(input));
    }
  }
}

