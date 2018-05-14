public class LinFunc
{
  public double M { get; set; }
  public double B { get; set; }
  
  public double GetY(double x) => M * x + B;
  
  public double CalcIntegral(int from, int to) => (M / 2.0) * to * to - (M / 2.0) * from * from + B * to - B * from;
  //cheeted
}

namespace Solution
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
    [Test]
    [TestCase(0,1,0,1,Result=1)]
    [TestCase(0,1,0,10,Result=10)]
    [TestCase(1,0,0,4,Result=8)]
    [TestCase(2,0,2,4,Result=12)]
    public static double FixedTest(double m, double b, int from, int to)
    {
        LinFunc f = new LinFunc();
        f.M = m;
        f.B = b;
        return f.CalcIntegral(from, to);
    }
    }
}