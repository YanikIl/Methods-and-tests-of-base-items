using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BaseMethods;

namespace BaseMethods.Test
{
    public class VariableStructuresTests
    {
        #region 1 Тест
        [TestCase(5, 3, 8)]
        [TestCase(-5, 5, -10)]
        [TestCase(5, 125, -120)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 7, -7)]
        [TestCase(0, -7, -7)]
        [TestCase(-8, -7, -1)]
        public void ComparingNumbersTest(int a, int b, int expected)
        {
            int actual = VariableStructures.ComparingNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 2 Тест
        [TestCase(3, 3, "Принадлежит 1 четверти")]
        [TestCase(-8, 3, "Принадлежит 2 четверти")]
        [TestCase(-5, -7, "Принадлежит 3 четверти")]
        [TestCase(1, -3, "Принадлежит 4 четверти")]
        [TestCase(0, 3, "Точка принадлежит прямой Ox или Oy")]
        [TestCase(0, 0, "Точка принадлежит прямой Ox или Oy")]
        [TestCase(-7, 0, "Точка принадлежит прямой Ox или Oy")]
        public void GetQuarterTest(int x, int y, string expected)
        {
            string actual = VariableStructures.GetQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 3 Тест
        [TestCase(-7, 0, 5, new int[3] { -7, 0, 5 })]
        [TestCase(7, 0, 5, new int[3] { 0, 5, 7 })]
        [TestCase(-5, 7, 5, new int[3] { -5, 5, 7 })]
        [TestCase(-7, -7, -7, new int[3] { -7, -7, -7 })]
        [TestCase(7, 7, 7, new int[3] { 7, 7, 7 })]
        public void AscendingSortTest(int a, int b, int c, int[] expected)
        {
            int[] actual = VariableStructures.AscendingSort(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 4 Тест
        [TestCase(1, -4, 4, new double[1] { 2 })]
        [TestCase(1, 4, 4, new double[1] { -2 })]
        [TestCase(4, -6, 0, new double[2] { 1.5, 0 })]
        [TestCase(-7, -5, -2, new double[0] { })]
        public void SolvingQuadraticEquationTest(int a, int b, int c, double[] expected)
        {
            double[] actual = VariableStructures.SolvingQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 0, -7)]
        public void SolvingQuadraticEquationTest_WhenFirstTwoParameters0_ShouldThrowsException(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => VariableStructures.SolvingQuadraticEquation(a, b, c));
        }

        [TestCase(0, 7, 0)]
        [TestCase(0, -4, 4)]
        [TestCase(0, 2, 2)]
        public void SolvingQuadraticEquationTest_WhenFirstParameter0_ShouldThrowsException(int a, int b, int c)
        {
            Assert.Throws<Exception>(() => VariableStructures.SolvingQuadraticEquation(a, b, c));
        }

        #endregion

        #region 5 Тест
        [TestCase(25, "Двадцать пять")]
        [TestCase(80, "Восемьдесят")]
        [TestCase(11, "Одиннадцать")]
        [TestCase(10, "Десять")]
        public void NumberWrittenWordsTest(int x, string expected)
        {
            string actual = VariableStructures.GetNumberWrittenWords(x);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123)]
        [TestCase(100)]
        [TestCase(9)]
        [TestCase(-5)]
        public void NumberWrittenWordsTest_WhenNonTwoDigitNumber_ShouldThrowsException(int x)
        {
            Assert.Throws<Exception>(() => VariableStructures.GetNumberWrittenWords(x));
        }

        #endregion
    }
}
