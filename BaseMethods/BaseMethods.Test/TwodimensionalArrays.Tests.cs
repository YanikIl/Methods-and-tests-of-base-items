using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BaseMethods;

namespace BaseMethods.Test
{
    public class TwodimensionalArraysTests
    {
        #region 1 Тест
        [TestCase(TwodimensionalArraysMockType.one, 1)]
        [TestCase(TwodimensionalArraysMockType.two, 0)]
        [TestCase(TwodimensionalArraysMockType.three, -47)]
        public void GetMinimumElementTwodimensionalArrayTest(TwodimensionalArraysMockType type, int expected)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            int actual = TwodimensionalArrays.GetMinimumElementTwodimensionalArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwodimensionalArraysMockType.empty)]
        public void GetMinimumElementTwodimensionalArray_WhenArrayIsEmpty_ThrowException(TwodimensionalArraysMockType type)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            Assert.Throws<ArgumentNullException>(() => TwodimensionalArrays.GetMinimumElementTwodimensionalArray(a));
        }
        #endregion

        #region 2 Тест
        [TestCase(TwodimensionalArraysMockType.one, 10)]
        [TestCase(TwodimensionalArraysMockType.two, 11)]
        [TestCase(TwodimensionalArraysMockType.three, 1007)]
        public void GetMaximumElementTwodimensionalArrayTest(TwodimensionalArraysMockType type, int expected)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            int actual = TwodimensionalArrays.GetMaximumElementTwodimensionalArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwodimensionalArraysMockType.empty)]
        public void GetMaximumElementTwodimensionalArray_WhenArrayIsEmpty_ThrowException(TwodimensionalArraysMockType type)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            Assert.Throws<ArgumentNullException>(() => TwodimensionalArrays.GetMinimumElementTwodimensionalArray(a));
        }
        #endregion

        #region 3 Тест
        [TestCase(TwodimensionalArraysMockType.one, new int[] { 0, 0 })]
        [TestCase(TwodimensionalArraysMockType.two, new int[] { 1, 2 })]
        [TestCase(TwodimensionalArraysMockType.three, new int[] { 2, 1 })]
        public void GetIndexOfTheMinimumElementTwodimensionalArrayTest(TwodimensionalArraysMockType type, int [] expected)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            int [] actual = TwodimensionalArrays.GetIndexOfTheMinimumElementTwodimensionalArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwodimensionalArraysMockType.empty)]
        public void GetIndexOfTheMinimumElementTwodimensionalArray_WhenArrayIsEmpty_ThrowException(TwodimensionalArraysMockType type)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            Assert.Throws<ArgumentNullException>(() => TwodimensionalArrays.GetIndexOfTheMinimumElementTwodimensionalArray(a));
        }
        #endregion

        #region 4 Тест
        [TestCase(TwodimensionalArraysMockType.one, new int[] { 2, 1 })]
        [TestCase(TwodimensionalArraysMockType.two, new int[] { 0, 0 })]
        [TestCase(TwodimensionalArraysMockType.three, new int[] { 4, 4 })]
        public void GetIndexOfTheMaximumElementTwodimensionalArrayTest(TwodimensionalArraysMockType type, int[] expected)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            int[] actual = TwodimensionalArrays.GetIndexOfTheMaximumElementTwodimensionalArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(TwodimensionalArraysMockType.empty)]
        public void GetIndexOfTheMaximumElementTwodimensionalArray_WhenArrayIsEmpty_ThrowException(TwodimensionalArraysMockType type)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            Assert.Throws<ArgumentNullException>(() => TwodimensionalArrays.GetIndexOfTheMaximumElementTwodimensionalArray(a));
        }
        #endregion

        #region 5 Тест
        [TestCase(TwodimensionalArraysMockType.one, 2)]
        [TestCase(TwodimensionalArraysMockType.two, 4)]
        [TestCase(TwodimensionalArraysMockType.four, 0)]
        [TestCase(TwodimensionalArraysMockType.empty, 0)]
        public void GetCountElementsLargerThanNeighborsTest(TwodimensionalArraysMockType type, int expected)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            int actual = TwodimensionalArrays.NumberOfArrayElementsThatAreLargerThanAllTheirNeighbors(a);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 6 Тест
        [TestCase(TwodimensionalArraysMockType.one, TwodimensionalArraysMockType.oneFlip)]
        [TestCase(TwodimensionalArraysMockType.two, TwodimensionalArraysMockType.twoFlip)]
        [TestCase(TwodimensionalArraysMockType.three, TwodimensionalArraysMockType.threeFlip)]
        [TestCase(TwodimensionalArraysMockType.four, TwodimensionalArraysMockType.four)]
        [TestCase(TwodimensionalArraysMockType.empty, TwodimensionalArraysMockType.empty)]
        public void FlipAnArrayRelativeToItsMainDiagonalTest(TwodimensionalArraysMockType type, TwodimensionalArraysMockType expectedtype)
        {
            int[,] a = TwodimensionalArraysMock.GetMock(type);
            int[,] actual = TwodimensionalArrays.FlipAnArrayRelativeToItsMainDiagonal(a);
            int[,] expected = TwodimensionalArraysMock.GetMock(expectedtype);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
