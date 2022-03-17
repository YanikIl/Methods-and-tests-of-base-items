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
        public void DivisibleNumbersTest(int a, int[] expected)
        {
            int[] actual = Cycles.DivisibleNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7)]
        [TestCase(-3)]
        [TestCase(0)]
        public void DivisibleNumbers_WhenArgumentsLessThanZero_ShouldThrowsException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.DivisibleNumbers(a));
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
        public void GreatestDivisorOfNumber_WhenArgumentsLessThanZero_ShouldThrowsException(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GreatestDivisorOfNumber(a));
        }
        #endregion

        #region 5 Тест
        #endregion

        #region 6 Тест
        #endregion

        #region 7 Тест
        #endregion

        #region 8 Тест
        #endregion

        #region 9 Тест
        #endregion

        #region 10 Тест
        #endregion

        #region 11 Тест
        #endregion

        #region 12 Тест
        #endregion
    }
}