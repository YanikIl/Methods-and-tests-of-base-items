using NUnit.Framework;
using BaseMethods;
using System;

namespace TestsForBaseMethods
{
    public class VariablesTests
    {

        #region 1 Задача
        [TestCase(5, 7, new int[2] { 0, 5 })]
        [TestCase(0, 7, new int[2] { 0, 0 })]
        [TestCase(4, 2, new int[2] { 2, 0 })]

        public void ResultAndRemainderOfTheDivisionTest(int a, int b, int[] expected)
        {
            int[] actual = BaseMethods.Variables.ResultAndRemainderOfTheDivision(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7, 2)]
        [TestCase(4, -2)]
        [TestCase(-3, -3)]

        public void ResultAndRemainderOfTheDivision_WhenArgumentsLessThanZero_ShouldThrowsArgumentOutOfRangeException(int a, int b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Variables.ResultAndRemainderOfTheDivision(a, b));
        }

        [TestCase(4, 0)]
        [TestCase(9, 0)]
        [TestCase(0, 0)]
        public void ResultAndRemainderOfTheDivision_WhenSecondArgument0_ShouldThrowsDivideByZeroException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => Variables.ResultAndRemainderOfTheDivision(a, b));
        }
        #endregion

        #region 2 задача
        [TestCase(5, 7, 37)]
        [TestCase(5, 0, -5)]
        [TestCase(0, 7, 7)]
        [TestCase(-5, -2, -7)]
        [TestCase(2, 5, 11.66)]

        public void GetTheAnswerToTheEquationTest(int a, int b, double expected)
        {
            double actual = BaseMethods.Variables.GetTheAnswerToTheEquation(a, b);
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(7, 7)]
        [TestCase(0, 0)]
        [TestCase(-7, -7)]
        public void GetTheAnswerToTheEquationTest_WhenTheOperatorsMatch_ShouldThrowsException(int a, int b)
        {
            Assert.Throws<Exception>(() => Variables.GetTheAnswerToTheEquation(a, b));
        }
        #endregion

        #region 3 Задача
        [TestCase("rft", "sdf")]
        [TestCase("YRE", "k")]
        [TestCase("", "sdl")]
        [TestCase("ðâ", "ëí")]
        [TestCase("sdf", "")]

        public void SwapTest(ref string a, ref string b)
        {
            string a1 = a;
            string b1 = b;
            Variables.Swap(ref a, ref b);
            Assert.AreEqual(b, a1);
        }
        #endregion

        #region 4 Задача
        [TestCase(5, 7, 3, -0.8)]
        [TestCase(1, 7, 7, 0)]
        [TestCase(-2, 4, 6, -1)]
        [TestCase(-2, -4, -6, 1)]

        public void SolvingLinearEquationTest(int a, int b, int c, double expected)
        {
            double actual = BaseMethods.Variables.SolvingLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 7, 7)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 0, -5)]
        public void SolvingLinearEquation_WhenOneOfOperatorsIs0_ShouldThrowsException(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => Variables.SolvingLinearEquation(a, b, c));
        }
        #endregion

        #region 5 Задача
        [TestCase(4, 3, 2, 5, "y= (-1)*x + (7)")]
        [TestCase(2, 3, 1, 6, "y= (-3)*x + (9)")]
        [TestCase(-2, 5, 11, -8, "y= (-1)*x + (3)")]
        [TestCase(0, 7, -5, 0, "y= (1)*x + (5)")]

        public void EquationOfStraightLineForGivenTwoPointsTest(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = BaseMethods.Variables.EquationOfStraightLineForGivenTwoPoints(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 7, 7, 7)]
        [TestCase(0, 0, 0, 5)]
        [TestCase(-5, 3, -5, -3)]
        [TestCase(6, 1, 6, 3)]
        public void EquationOfStraightLineForGivenTwoPoints_WhenTheOperatorsMatch_ShouldThrowsException(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<Exception>(() => Variables.EquationOfStraightLineForGivenTwoPoints(x1, y1, x2, y2));
        }
        #endregion
    }
}