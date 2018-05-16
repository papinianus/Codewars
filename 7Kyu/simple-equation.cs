namespace Equation
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Kata
    {
        public static string SolveTheEquation(string equation) => $"x = {CalcRetro(equation.Split()[1], double.Parse(equation.Split()[2]), double.Parse(equation.Split()[4])),0:0.##}";

        private static double CalcRetro(string ope, double part, double answer)
        {
            switch (ope)
            {
                case "-":
                    return answer + part;
                case "/":
                    return answer * part;
                case "*":
                    return answer / part;
                case "+":
                default:
                    return answer - part;
            }
        }
    }
}

namespace Equation
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;
    using System;

    [TestFixture]
    public class EquationTest
    {
        [Test]
        public void TestPlus()
        {
            StringAssert.AreEqualIgnoringCase("x = 17", Kata.SolveTheEquation("x + 85 = 102"),
                "Plus operator test failed");
        }

        [Test]
        public void TestMultiply()
        {
            StringAssert.AreEqualIgnoringCase("x = 68.15", Kata.SolveTheEquation("x * 1358 = 92548"),
                "Multiply operator test failed");
        }

        [Test]
        public void TestMinus()
        {
            StringAssert.AreEqualIgnoringCase("x = 6553", Kata.SolveTheEquation("x - 1003 = 5550"),
                "Minus operator test failed");
        }

        [Test]
        public void TestDivide()
        {
            StringAssert.AreEqualIgnoringCase("x = 63250", Kata.SolveTheEquation("x / 5 = 12650"),
                "Divide operator test failed");
        }
    }
}
