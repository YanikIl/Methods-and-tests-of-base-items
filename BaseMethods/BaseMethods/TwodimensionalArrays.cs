using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMethods
{
    public class TwodimensionalArrays
    {
        #region 1 Задача
        //Найти минимальный элемент массива
        public static int GetMinimumElementTwodimensionalArray(int[,] mas)
        {
            if (mas.Length == 0)
            {
                throw new ArgumentNullException("Пустой массив");
            }
            else
            {
                int min = mas[0, 0];
                for (int i = 0; i < mas.GetLength(0); i++)
                    for (int j = 0; j < mas.GetLength(1); j++)
                        if (mas[i, j] < min)
                            min = mas[i, j];
                return min;
            }
        }
        #endregion

        #region 2 Задача
        //Найти максимальный элемент массива
        public static int GetMaximumElementTwodimensionalArray(int[,] mas)
        {
            if (mas.Length == 0)
            {
                throw new ArgumentNullException("Пустой массив");
            }
            else
            {
                int max = mas[0, 0];
                for (int i = 0; i < mas.GetLength(0); i++)
                    for (int j = 0; j < mas.GetLength(1); j++)
                        if (mas[i, j] > max)
                            max = mas[i, j];
                return max;
            }
        }
        #endregion

        #region 3 Задача
        //Найти индекс минимального элемента массива
        public static int[] GetIndexOfTheMinimumElementTwodimensionalArray(int[,] mas)
        {
            if (mas.Length == 0)
            {
                throw new ArgumentNullException("Пустой массив");
            }
            else
            {
                int min = mas[0, 0];
                int[] minIndex = new int[2];
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] < min)
                        {
                            min = mas[i, j];
                            minIndex[0] = i;
                            minIndex[1] = j;
                        }
                    }
                }
                return minIndex;
            }
        }
        #endregion

        #region 4 Задача
        //Найти индекс максимального элемента массива
        public static int[] GetIndexOfTheMaximumElementTwodimensionalArray(int[,] mas)
        {
            if (mas.Length == 0)
            {
                throw new ArgumentNullException("Пустой массив");
            }
            else
            {
                int max = mas[0, 0];
                int[] maxIndex = new int[2];
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i, j] > max)
                        {
                            max = mas[i, j];
                            maxIndex[0] = i;
                            maxIndex[1] = j;
                        }
                    }
                }
                return maxIndex;
            }
        }
        #endregion

        #region 5 Задача
        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public static int NumberOfArrayElementsThatAreLargerThanAllTheirNeighbors(int[,] array)
        {
            int numberElements = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (
                        (i == 0 || array[i, j] > array[i - 1, j])
                        && (i == array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j + 1])
                        )
                    {
                        numberElements++;
                    }
                }
            }

            return numberElements;
        }
        #endregion

        #region 6 Задача
        //Отразите массив относительно его главной диагонали

        public static int[,] FlipAnArrayRelativeToItsMainDiagonal(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = i + 1; j < mas.GetLength(1); j++)
                {
                    int tmp = mas[i, j];
                    mas[i, j] = mas[j, i];
                    mas[j, i] = tmp;
                }
            }
            return mas;
        }
        #endregion

    }
}
