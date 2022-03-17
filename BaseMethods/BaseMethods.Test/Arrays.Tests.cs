using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BaseMethods;

namespace BaseMethods.Test
{
    public class ArraysTests
    {
        #region 1 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, -4)]
        [TestCase(new int[4] { 2, 3, 8, 4 }, 2)]
        [TestCase(new int[1] { 2 }, 2)]
        [TestCase(new int[2] { -7, 8 }, -7)]
        [TestCase(new int[2] { -4, -8 }, -8)]
        public void GetMinimumElementOfArrayTest(int[] mas, int expected)
        {
            int actual = Arrays.GetMinimumElementOfArray(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0] { })]
        public void GetMinimumElementOfArrayTest_WhenArrayEmpty_ShouldThrowsIndexOutOfRangeException(int[] mas)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Arrays.GetMinimumElementOfArray(mas));
        }

        #endregion

        #region 2 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, 8)]
        [TestCase(new int[4] { 2, 3, 8, 4 }, 8)]
        [TestCase(new int[1] { 2 }, 2)]
        [TestCase(new int[2] { -7, 8 }, 8)]
        [TestCase(new int[2] { -4, -8 }, -4)]
        public void GetMaximumElementOfArrayTest(int[] mas, int expected)
        {
            int actual = Arrays.GetMaximumElementOfArray(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0] { })]
        public void GetMaximumElementOfArrayTest_WhenArrayEmpty_ShouldThrowsIndexOutOfRangeException(int[] mas)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Arrays.GetMaximumElementOfArray(mas));
        }

        #endregion

        #region 3 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, 3)]
        [TestCase(new int[4] { 2, 3, 8, 4 }, 0)]
        [TestCase(new int[1] { 2 }, 0)]
        [TestCase(new int[2] { -7, 8 }, 0)]
        [TestCase(new int[2] { -4, -8 }, 1)]
        public void GetIndexOfTheMinimumElementOfArrayTest(int[] mas, int expected)
        {
            int actual = Arrays.GetIndexOfTheMinimumElementOfArray(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0] { })]
        public void GetIndexOfTheMinimumElementOfArrayTest_WhenArrayEmpty_ShouldThrowsIndexOutOfRangeException(int[] mas)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Arrays.GetIndexOfTheMinimumElementOfArray(mas));
        }

        #endregion

        #region 4 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, 2)]
        [TestCase(new int[4] { 2, 3, 8, 4 }, 2)]
        [TestCase(new int[1] { 2 }, 0)]
        [TestCase(new int[2] { -7, 8 }, 1)]
        [TestCase(new int[2] { -4, -8 }, 0)]
        public void GetIndexOfTheMaximumElementOfArrayTest(int[] mas, int expected)
        {
            int actual = Arrays.GetIndexOfTheMaximumElementOfArray(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0] { })]
        public void GetIndexOfTheMaximumElementOfArrayTest_WhenArrayEmpty_ShouldThrowsIndexOutOfRangeException(int[] mas)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Arrays.GetIndexOfTheMaximumElementOfArray(mas));
        }
        #endregion

        #region 5 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, -1)]
        [TestCase(new int[4] { 2, 3, 8, 4 }, 7)]
        [TestCase(new int[1] { 2 }, 0)]
        [TestCase(new int[2] { 2, 0 }, 0)]
        [TestCase(new int[2] { -7, 8 }, 8)]
        [TestCase(new int[2] { -4, -8 }, -8)]
        public void GetSumOfArrayElementsWithOddIndicesTest(int[] mas, int expected)
        {
            int actual = Arrays.GetSumOfArrayElementsWithOddIndices(mas);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 6 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, new int[5] { 0, -4, 8, 3, 2 })]
        [TestCase(new int[4] { 2, 3, 8, 4 }, new int[4] { 4, 8, 3, 2 })]
        [TestCase(new int[1] { 2 }, new int[1] { 2 })]
        [TestCase(new int[2] { 2, 0 }, new int[2] { 0, 2 })]
        [TestCase(new int[2] { -7, 8 }, new int[2] { 8, -7 })]
        [TestCase(new int[2] { -4, -8 }, new int[2] { -8, -4 })]
        [TestCase(new int[0] { }, new int[0] { })]
        public void GetReverseArrayTest(int[] mas, int[] expected)
        {
            int[] actual = Arrays.GetReverseArray(mas);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 7 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, 1)]
        [TestCase(new int[4] { 2, 3, 8, 4 }, 1)]
        [TestCase(new int[1] { 2 }, 0)]
        [TestCase(new int[2] { 2, 0 }, 0)]
        [TestCase(new int[2] { -7, 8 }, 1)]
        [TestCase(new int[2] { -4, -8 }, 0)]
        public void GetNumberOfOddElementsInArrayTest(int[] mas, int expected)
        {
            int actual = Arrays.GetNumberOfOddElementsInArray(mas);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 8 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, new int[5] { -4, 0, 8, 2, 3 })]
        [TestCase(new int[4] { 2, 3, 8, 4 }, new int[4] { 8, 4, 2, 3 })]
        [TestCase(new int[1] { 2 }, new int[1] { 2 })]
        [TestCase(new int[2] { 2, 0 }, new int[2] { 0, 2 })]
        [TestCase(new int[2] { -7, 8 }, new int[2] { 8, -7 })]
        [TestCase(new int[2] { -4, -8 }, new int[2] { -8, -4 })]
        [TestCase(new int[0] { }, new int[0] { })]
        public void SwapTheFirstAndSecondHalfOfTheArrayTest(int[] mas, int[] expected)
        {
            int[] actual = Arrays.SwapTheFirstAndSecondHalfOfTheArray(mas);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region 9 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, new int[5] { -4, 0, 2, 3, 8 })]
        [TestCase(new int[4] { 2, 3, 8, 4 }, new int[4] { 2, 3, 4, 8 })]
        [TestCase(new int[1] { 2 }, new int[1] { 2 })]
        [TestCase(new int[2] { 2, 0 }, new int[2] { 0, 2 })]
        [TestCase(new int[2] { -7, 8 }, new int[2] { -7, 8 })]
        [TestCase(new int[2] { -4, -8 }, new int[2] { -8, -4 })]
        [TestCase(new int[0] { }, new int[0] { })]
        public void BubbleSortTest(int[] mas, int[] expected)
        {
            int[] actual = Arrays.BubbleSort(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, new int[5] { -4, 0, 2, 3, 8 })]
        [TestCase(new int[4] { 2, 3, 8, 4 }, new int[4] { 2, 3, 4, 8 })]
        [TestCase(new int[1] { 2 }, new int[1] { 2 })]
        [TestCase(new int[2] { 2, 0 }, new int[2] { 0, 2 })]
        [TestCase(new int[2] { -7, 8 }, new int[2] { -7, 8 })]
        [TestCase(new int[2] { -4, -8 }, new int[2] { -8, -4 })]
        [TestCase(new int[0] { }, new int[0] { })]
        public void SelectionSortTest(int[] mas, int[] expected)
        {
            int[] actual = Arrays.SelectionSort(mas);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region 10 义耱
        [TestCase(new int[5] { 2, 3, 8, -4, 0 }, new int[5] { 8, 3, 2, 0, -4 })]
        [TestCase(new int[4] { 2, 3, 8, 4 }, new int[4] { 8, 4, 3, 2 })]
        [TestCase(new int[1] { 2 }, new int[1] { 2 })]
        [TestCase(new int[2] { 2, 0 }, new int[2] { 2, 0 })]
        [TestCase(new int[2] { -7, 8 }, new int[2] { 8, -7 })]
        [TestCase(new int[2] { -4, -8 }, new int[2] { -4, -8 })]
        [TestCase(new int[0] { }, new int[0] { })]
        public void SortDescendingTest(int[] mas, int[] expected)
        {
            int[] actual = Arrays.SortDescending(mas);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}