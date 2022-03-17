using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMethods
{
    // все вроде ок
    public class Variables
    {
        #region 1 задача
        /// <summary>
        /// a всегда >= 0 и b > 0
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="DivideByZeroException"></exception>
        public static int[] ResultAndRemainderOfTheDivision(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentOutOfRangeException("Введены отрицательные числа");
            if (b == 0)
                throw new DivideByZeroException("Деление на 0");
            int result = a / b;
            int remainder = a % b;
            int[] mas = new int[2] { result, remainder };
            return mas;
        }
        #endregion

        #region 2 задача
        /// <summary>
        /// a не может быть равно b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double GetTheAnswerToTheEquation(int a, int b)
        {
            if (a == b)
                throw new Exception("a==b");
            else
                return (double)(5 * a + b * b) / (b - a);
        }
        #endregion

        #region 3 задача
        //Проверить!
        // ошибка ввода: вводят инты а не стринги (ошибка аргумента?)
        public static void Swap(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
        #endregion

        #region 4 задача
        //Пользователь вводит 3 не равных 0 числа (A, B и С).
        //Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.

        /// <summary>
        /// a, b не равны 0 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>

        public static double SolvingLinearEquation(int a, int b, int c)
        {
            if ((a == 0) || (b == 0))
                throw new Exception("Введено значение a или b равное 0");
            else
                return (double)(c - b) / (a);
        }
        #endregion

        #region 5 задача
        // Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.
        // Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.

        public static string EquationOfStraightLineForGivenTwoPoints(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
                throw new Exception("x1 == x2");
            int k, b;
            k = (y1 - y2) / (x1 - x2);
            b = y2 - k * x2;
            return $"y= ({k})*x + ({b})";
        }
        #endregion
    }
}
