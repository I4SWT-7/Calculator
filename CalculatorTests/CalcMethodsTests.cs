using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalcMethodsTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(3, 4, 7)]
        [TestCase(4, 4, 8)]
        public void AddTest(int a, int b, int c)
        {
            CalcMethods cal = new CalcMethods();
            Assert.That(cal.Add(a, b), Is.EqualTo(c));
        }

        [TestCase(1, 4, -3)]
        [TestCase(5, 2, 3)]
        [TestCase(2, 1, 1)]

        public void SubtractTest(int a, int b, int c)
        {
            CalcMethods cal = new CalcMethods();
            Assert.That(cal.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(1, 4, 4)]
        [TestCase(5, 2, 10)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 2, 6)]
        public void MultiplyTest(int a, int b, int c)
        {
            CalcMethods cal = new CalcMethods();
            Assert.That(cal.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(1, 4, 1)]
        [TestCase(5, 2, 25)]
        [TestCase(2, 1, 2)]
        public void PowerTest(int a, int b, int c)
        {
            CalcMethods cal = new CalcMethods();
            Assert.That(cal.Power(a, b), Is.EqualTo(c));
        }

        [TestCase(4, 2, 2)]
        [TestCase(6, 3, 2)]
        [TestCase(2, 1, 2)]
        public void DivideTest(int a, int b, int c)
        {
            CalcMethods cal = new CalcMethods();
            Assert.That(cal.Divide(a, b), Is.EqualTo(c));
        }

        [TestCase(9, 3)]
        [TestCase(4, 2)]
        [TestCase(25, 5)]
        public void SquarerootTest(int a, int c)
        {
            CalcMethods cal = new CalcMethods();
            Assert.That(cal.squareroot(a), Is.EqualTo(c));
        }
    }
}