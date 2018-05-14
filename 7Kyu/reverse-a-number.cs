using System;
using System.Linq;
using NUnit.Framework;

public class Kata
{
    public int ReverseNumber(int n) => ((n < 0) ? -1 : 1) * int.Parse(string.Concat(n.ToString().TrimStart('-').ToCharArray().Reverse().ToArray()));
}

[TestFixture]
public class KataTestf
{
    [Test]
    public void _0_BasicTests()
    {
        var kata = new Kata();

        Assert.AreEqual(321, kata.ReverseNumber(123));
        Assert.AreEqual(-321, kata.ReverseNumber(-123));
        Assert.AreEqual(0, kata.ReverseNumber(0));
    }
}