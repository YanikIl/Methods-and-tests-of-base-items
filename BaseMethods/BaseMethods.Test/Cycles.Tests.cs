using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BaseMethods;

namespace BaseMethods.Test
{
    public class CyclesTests
    {
        #region 1 Тест
        [TestCase(2, 3, 8)]
        [TestCase(5, 0, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(-1, 5, -1)]
        [TestCase(5, -1, 0.2)]
        public void DegreeOfNumberTest(int a, int b, double expected)
        {
            double actual = Cycles.DegreeOfNumber(a, b);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 2 Тест
        [TestCase(227, new int[] {227, 454, 681, 908 })]
        [TestCase(504, new int[] {504})]
        public void GetDivisibleNumbersTest(int a, int[] expected)
        {
            int[] actual = Cycles.GetDivisibleNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7)]
        [TestCase(-3)]
        [TestCase(0)]
        [TestCase(1001)]
        public void DivisibleNumbers_WhenArgumentsLessThanZeroAndMoreThan1000_ShouldThrowsException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetDivisibleNumbers(a));
        }
        #endregion

        #region 3 Тест
        [TestCase(8, 2)]
        [TestCase(10, 3)]
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        public void SquareOfPositiveNumberLessThanSpecifiedNumberTest(int a, int expected)
        {
            double actual = Cycles.SquareOfPositiveNumberLessThanSpecifiedNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7)]
        [TestCase(-3)]
        public void SquareOfPositiveNumberLessThanSpecifiedNumber_WhenArgumentsLessThanZero_ShouldThrowsArgumentOutOfRangeException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.SquareOfPositiveNumberLessThanSpecifiedNumber(a));
        }
        #endregion

        #region 4 Тест
        [TestCase(227, 1)]
        [TestCase(504, 252)]
        [TestCase(2, 1)]
        public void GreatestDivisorOfNumberTest(int a, int expected)
        {
            int actual = Cycles.GreatestDivisorOfNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7)]
        [TestCase(-3)]
        [TestCase(0)]
        [TestCase(1)]
        public void GreatestDivisorOfNumber_WhenArgumentsLessThanOne_ShouldThrowsException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GreatestDivisorOfNumber(a));
        }
        #endregion

        #region 5 Тест
        [TestCase(5, 7, 7)]
        [TestCase(1, 15, 21)]
        public void GetSumOfNumbersDivisibleBy7Test(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfNumbersDivisibleBy7(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-5, -8)]
        [TestCase(-5, 9)]
        [TestCase(5, -9)]
        public void GetSumOfNumbersDivisibleBy7_WhenArgumentsLessThanZero_ShouldThrowsException(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.GetSumOfNumbersDivisibleBy7(a, b));
        }
        #endregion

        #region 6 Тест
        [TestCase(3, 2)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(4, 3)]
        public void GettingFibonacciNumberTest(int n, int expected)
        {
            int actual = Cycles.GettingFibonacciNumber(n);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-5)]
        [TestCase(0)]
        public void GettingFibonacciNumber_WhenArgumentsLessThanOrEqualsZero_ShouldThrowsException(int n)
        {
            Assert.Throws<Exception>(() => Cycles.GettingFibonacciNumber(n));
        }
        #endregion

        #region 7 Тест
        [TestCase(4, 1, 1)]
        [TestCase(8, 4, 4)]
        [TestCase(10, 4, 2)]
        public void FindingLeastCommonDivisorTest(int a, int b, int expected)
        {
            int actual = Cycles.FindingLeastCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(0, -2)]
        [TestCase(-2, -7)]
        public void FindingLeastCommonDivisor_WhenArgumentsLessThanZero_ShouldThrowsException(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.FindingLeastCommonDivisor(a, b));
        }
        #endregion

        #region 8 Тест
        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(1, 1)]
        public void GetNumberByHalfDivisionTest(int a, int expected)
        {
            int actual = Cycles.GetNumberByHalfDivision(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-2)]
        [TestCase(0)]
        public void GetNumberByHalfDivision_WhenArgumentsLessThanZero_ShouldThrowsException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetNumberByHalfDivision(a));
        }
        #endregion

        #region 9 Тест
        [TestCase(35, 2)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(-4, 0)]
        [TestCase(4, 0)]
        public void GetNumberOfOddDigitsOfThisNumberTest(int n, int expected)
        {
            int actual = Cycles.GetNumberOfOddDigitsOfThisNumber(n);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 10 Тест
        [TestCase(123, 321)]
        [TestCase(12, 21)]
        [TestCase(4, 4)]
        [TestCase(0, 0)]
        [TestCase(1222, 2221)]
        public void GetNumberMirroringTest(int a, int expected)
        {
            int actual = Cycles.GetNumberMirroring(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7)]
        public void DivisibleNumbers_WhenArgumentsLessThanZero_ShouldThrowsException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetNumberMirroring(a));
        }
        #endregion

        #region 11 Тест

        #endregion

        #region 12 Тест

        #endregion
    }
}