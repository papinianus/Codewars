using System;
using System.Linq;

public class CodeWars
{
  private static double i;
  public static bool IsDigit(string s) => string.IsNullOrWhiteSpace(s) ? false : double.TryParse(s.Trim(), out i);
}


namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test, Sequential]
    public void BasicTests(
      [Values("s2324", "-234.4")] string input, 
      [Values(false, true)] bool expectedResult)
    {
      Assert.IsTrue(CodeWars.IsDigit(input) == expectedResult);
    }
  }
}
