using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMethods
{
    public class VariableStructures
    {
        // вроде всё ок
        #region перегруженный метод для вывода массива (дабл)
        public static void Write(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        #endregion

        #region 1 задача
        // Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public static int ComparingNumbers(int a, int b)
        {
            int result;
            if (a > b)
                result = a + b;
            else if (a == b)
                result = a * b;
            else
                result = a - b;
            return result;
        }
        #endregion

        #region 2 задача
        // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X, Y).
        public static string GetQuarter(int x, int y)
        {
            string result;
            if (x > 0 && y > 0)
                result = "Принадлежит 1 четверти";
            else if (x < 0 && y > 0)
                result = "Принадлежит 2 четверти";
            else if (x < 0 && y < 0)
                result = "Принадлежит 3 четверти";
            else if (x > 0 && y < 0)
                result = "Принадлежит 4 четверти";
            else
                result = "Точка принадлежит прямой Ox или Oy";
            return result;
        }
        #endregion

        #region 3 задача
        // Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        public static int[] AscendingSort(int a, int b, int c)
        {
            int[] mas = new int[3]; ;
            if (a >= b && b >= c)
                mas = new int[3] { c, b, a };
            else if (a >= b && c >= b)
                mas = new int[3] { b, c, a };
            else if (b >= c && c >= a)
                mas = new int[3] { a, c, b };
            else if (b >= c && a >= c)
                mas = new int[3] { c, a, b };
            else if (c >= a && a >= b)
                mas = new int[3] { b, a, c };
            else if (c >= a && b >= a)
                mas = new int[3] { a, b, c };
            return mas;
        }
        #endregion

        #region 4 задача
        // Пользователь вводит 3 числа(A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида,
        // где AX2+BX+C=0.

        public static double[] SolvingQuadraticEquation(int a, int b, int c)
        {
            double[] mas;
            double d;
            double x, x1, x2;


            if (a == 0 && b == 0)
            {
                throw new Exception("Введено не уравнение");
            }


            else
            {
                if (a == 0)
                {
                    throw new Exception("При а = 0 происходит деление на 0");
                }
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    mas = new double[2] { x1, x2 };
                    return mas;
                }
                else if (d < 0)
                {
                    mas = new double[0];
                    return mas;
                }
                else
                {
                    x = -b / 2 * a;
                    mas = new double[1] { x };
                    return mas;
                }
            }

        }
        #endregion

        #region 5 задача
        // Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа.
        // Например при вводе “25” в консоль будет выведено “двадцать пять”.

        public static string GetNumberWrittenWords(int x)
        {
            string first = "";
            string second = "";

            if (x < 10 || x >= 100)
            {
                throw new Exception("Введено не двузначное число");
            }
            else
            {
                if (x < 20)
                {
                    switch (x)
                    {
                        case 10: first = "Десять"; break;
                        case 11: first = "Одиннадцать"; break;
                        case 12: first = "Двенадцать"; break;
                        case 13: first = "Тринадцать"; break;
                        case 14: first = "Четырнадцать"; break;
                        case 15: first = "Пятнадцать"; break;
                        case 16: first = "Шестнадцать"; break;
                        case 17: first = "Семнадцать"; break;
                        case 18: first = "Восемнадцать"; break;
                        case 19: first = "Девятнадцать"; break;
                    }
                }
                else if (x > 19)
                {
                    switch (x - (x % 10))
                    {
                        case 20: first = "Двадцать"; break;
                        case 30: first = "Тридцать"; break;
                        case 40: first = "Сорок"; break;
                        case 50: first = "Пятьдесят"; break;
                        case 60: first = "Шестьдесят"; break;
                        case 70: first = "Семьдесят"; break;
                        case 80: first = "Восемьдесят"; break;
                        case 90: first = "Девяносто"; break;
                    }
                }
                if (x % 10 != 0 && x >= 20)
                {
                    switch (x % 10)
                    {
                        case 1: second = " один"; break;
                        case 2: second = " два"; break;
                        case 3: second = " три"; break;
                        case 4: second = " четыре"; break;
                        case 5: second = " пять"; break;
                        case 6: second = " шесть"; break;
                        case 7: second = " семь"; break;
                        case 8: second = " восемь"; break;
                        case 9: second = " девять"; break;
                    }
                }

                return $"{first}{second}";
            }
        }
        #endregion


    }
}