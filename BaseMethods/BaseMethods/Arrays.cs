using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMethods
{
    public class Arrays
    {
        #region 1 Задача
        //Найти минимальный элемент массива
        public static int GetMinimumElementOfArray(int[] mas)
        {
            if (mas == null)
            {
                throw new IndexOutOfRangeException("Пустой массив");
            }
            else
            {
                int min = mas[0];
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < min)
                        min = mas[i];
                }
                return min;
            }
        }
        #endregion

        #region 2 Задача
        //Найти максимальный элемент массива
        public static int GetMaximumElementOfArray(int[] mas)
        {
            if (mas == null)
            {
                throw new ArgumentNullException("Пустой массив");
            }
            else
            {
                int max = mas[0];
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > max)
                        max = mas[i];
                }
                return max;
            }
        }
        #endregion

        #region 3 Задача
        //Найти индекс минимального элемента массива
        public static int GetIndexOfTheMinimumElementOfArray(int[] mas)
        {
            if (mas == null)
            {
                throw new ArgumentNullException("Пустой массив");
            }
            else
            {
                int minindex = 0;
                int min = mas[0];
                for (int i = 0; i < mas.Length; i++)
                    if (mas[i] < min)
                    {
                        min = mas[i];
                        minindex = i;
                    }
                return minindex;
            }
        }
        #endregion

        #region 4 Задача
        //Найти индекс максимального элемента массива
        public static int GetIndexOfTheMaximumElementOfArray(int[] mas)
        {
            if (mas == null)
            {
                throw new ArgumentNullException("Пустой массив");
            }
            else
            {
                int maxindex = 0;
                int max = mas[0];
                for (int i = 0; i < mas.Length; i++)
                    if (mas[i] > max)
                    {
                        max = mas[i];
                        maxindex = i;
                    }
                return maxindex;
            }
        }
        #endregion

        #region 5 Задача
        //Посчитать сумму элементов массива с нечетными индексами
        public static int GetSumOfArrayElementsWithOddIndices(int[] mas)
        {
            int sum = 0;
            for (int i = 1; i < mas.Length; i = i + 2)
                sum += mas[i];
            return sum;
        }
        #endregion

        #region 6 Задача 
        //Сделать реверс массива(массив в обратном направлении)
        public static int[] GetReverseArray(int[] mas)
        {
            int tmp;
            for (int i = 0; i < mas.Length / 2; i++)
            {
                tmp = mas[i];
                mas[i] = mas[mas.Length - i - 1];
                mas[mas.Length - i - 1] = tmp;
            }
            return mas;
        }
        #endregion

        #region 7 Задача 
        //Посчитать количество нечетных элементов массива
        public static int GetNumberOfOddElementsInArray(int[] mas)
        {
            int k = 0;
            for (int i = 0; i < mas.Length; ++i)
                if (mas[i] % 2 != 0)
                    k += 1;
            return k;
        }
        #endregion

        #region 8 Задача
        //Поменять местами первую и вторую половину массива,
        //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public static int[] SwapTheFirstAndSecondHalfOfTheArray(int[] mas)
        {
            int half = mas.Length / 2;
            int step = mas.Length % 2 == 0 ? half : half + 1;
            for (int i = 0; i < half; i++)
            {
                int tmp = mas[i];
                mas[i] = mas[i + step];
                mas[i + step] = tmp;
            }
            return mas;
        }
        #endregion

        #region 9 Задача
        //Отсортировать массив по возрастанию одним из способов:
        //пузырьком(Bubble), выбором(Select) или вставками(Insert)) 

        #region метод для обмена элементов, использующийся в сортировках
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        #endregion

        //сортировка пузырьком
        public static int[] BubbleSort(int[] array)
        {
            int len = array.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }


        #region метод, использующий в сортировки выборки ( метод поиска позиции минимального элемента подмассива, начиная с позиции n)
        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }
        #endregion

        //сортировка выбором
        public static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }

        #endregion

        #region 10 Задача
        // Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании):
        // пузырьком(Bubble), выбором(Select) или вставками(Insert))

        public static int[] SortDescending(int[] mas)
        {
            int[] result = Copy(mas);
            for (int i = result.Length - 1; i >= 0; i--)
            {
                int max = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (result[j] < result[max])
                    {
                        max = j;
                    }
                }

                int tmp = result[i];
                result[i] = result[max];
                result[max] = tmp;
            }

            return result;
        }
        #endregion

        #region метод для вывода массива
        public static void Write(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        #endregion

        #region перегруженный метод для вывода массива (дабл)
        public static void Write(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        #endregion

        # region метод для копирования массива
        public static int[] Copy(int[] a)
        {
            int[] newArray = new int[a.Length];
            Array.Copy(a, newArray, a.Length);
            return newArray;
        }
        #endregion

    }
}
