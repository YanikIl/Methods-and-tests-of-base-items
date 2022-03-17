using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMethods
{
    public class Cycles
    {
        #region 1 Задача
        // Пользователь вводит 2 числа(A и B). Возвести число A в степень B.
        public static double DegreeOfNumber(int a, int b)
        {
            double result = 1;
            int i = 0;

            if (b > 0)
            {
                while (i != b)
                {
                    result *= a;
                    i++;
                }
            }
            else if (b == 0)
                result = 1;
            else
            {
                while (i != Math.Abs(b))
                {
                    result *= a;
                    i++;
                }
                result = 1 / result;
            }
            return result;
        }
        #endregion

        //можно в А раз быстрее
        #region 2 Задача
        //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
        public static int[] DivisibleNumbers(int a)
        {
            if (a > 0)
            {
                int[] mas = new int[1000 / a];
                for (int i = 1; i <= 1000; i += 1)
                    if (i % a == 0)
                        mas[(i / a) - 1] = i;
                return mas;
            }
            else
                throw new Exception("Введено отрицательное число или 0");
        }
        #endregion

        #region 3 Задача
        //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static int SquareOfPositiveNumberLessThanSpecifiedNumber(int a)
        {
            int k = 0;
            for (int i = 1; i * i < a; ++i)
            {
                k = k + 1;
            }
            return k;
        }
        #endregion

        #region 4 Задача
        //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        public static int GreatestDivisorOfNumber(int a)
        {
            if (a > 0)
            {
                int divisior = 0;
                for (int i = a - 1; i < a; --i)
                {
                    if (a % i == 0)
                    {
                        divisior = i;
                        break;
                    }
                }
                return divisior;
            }
            else
                throw new Exception("Введено отрицательное число или 0");
        }
        #endregion

        // не работает
        // не надо отбивать отрицательные
        #region 5 Задача
        //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B,
        //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

        public static int SumOfNumbersDivisibleBy7(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new Exception("Введено отрицательное число");
            }
            else
            {
                int sum = 0;
                int tmp;

                if (a > b)
                {
                    tmp = a;
                    a = b;
                    b = tmp;
                }
                else
                {
                    for (int i = a; i <= b; ++i)
                    {
                        if (i % 7 == 0)
                            sum += i;
                    }
                }
                return sum;
            }
        }
        #endregion

        #region 6 Задача

        //Пользователь вводит 1 положительное число(N). Выведите N-ое число ряда фибоначчи.
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих.Первое и второе считаются равными 1.
        // Если вводит то выводит 0, ане ошибку, по другому никак
        public static int GettingFibonacciNumber(int n)
        {
            if (n > 0)
            {
                int result;
                if (n == 0)
                    result = 0;
                else if (n == 1)
                    result = 1;
                else
                    result = GettingFibonacciNumber(n - 1) + GettingFibonacciNumber(n - 2);
                return result;
            }
            else
                throw new Exception("Введено отрицательное число");
        }
        #endregion

        // Переделать
        // для отрицательных чисел, модуль брать или как?
        #region 7 Задача 
        //Проверить!
        //Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.
        public static int FindingLeastCommonDivisor(int a, int b)
        {
            int remainder;
            int result;
            int tmp;
            if (a <= 0 || b <= 0)
                throw new Exception("Введено отрицательное значение или 0");
            else
            {
                if (b < a)
                {
                    tmp = a;
                    a = b;
                    b = tmp;
                }
                while (b != 0)
                {
                    remainder = a;
                    a = b;
                    b = a % remainder;
                }
                result = a;
                return result;
            }
        }
        #endregion

        //Сделать  
        #region 8 Задача
        //Проверить!
        //Пользователь вводит целое положительное число, которое является кубом целого числа N.
        //Найдите число N методом половинного деления. (проверяются числа меньше половины этого числа).
        #endregion

        #region 9 Задача

        // для отрицательных чисел отбработать
        //Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
        public static int NumberOfOddDigitsOfThisNumber(int n)
        {
            if (n >= 0)
            {
                int k = 0;
                while (n > 0)
                {
                    if ((n % 10) % 2 != 0)
                        k += 1;
                    n = n / 10;
                }
                return k;
            }
            else
                throw new Exception("Введено отрицательное число");
        }
        #endregion

        #region 10 Задача

        //Пользователь вводит 1 число.Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
        //например, задано число 123, вывести 321.

        public static int NumberMirroring(int a)
        {
            int result = 0;
            if (a < 0)
                throw new Exception("Введено число меньше 0");
            else
            {
                while (a > 0)
                {
                    result = result * 10 + a % 10;
                    a /= 10;
                }
                return result;
            }
        }
        #endregion

        // Не работает?
        #region 11 Задача
        //Проверить!
        //Дописать! для 0 и отрицательных
        //Пользователь вводит целое положительное  число (N).
        //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.

        public static int[] NumbersSumEvenDigitsIsGreaterThanSumOddDigits(int n)
        {
            int[] mas = new int[n / 2];

            for (int i = 1; i < n; ++i)
            {
                int sumeven = 0;
                int sumodd = 0;
                while (i > 0)
                {
                    if (i % 2 == 0)
                        sumeven += i % 10;
                    else
                        sumodd += i % 10;
                    i /= 10;
                }
                if (sumeven > sumodd)
                {
                    for (int j = 0; j < n / 2; ++j)
                        mas[j] = i;
                }
            }
            return mas;
        }
        #endregion

        //Доработать
        // лучше бульку вернуть
        #region 12 Задача
        //Проверить!
        //Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        //Не работает на 0 и 1450, 14450 и 0, переделывать с конвертацией int в string ?

        public static string PresenceOfSameDigitsInTwoNumbers(int a, int b)
        {
            if (a == 0 && b == 0)
                return "Да";
            else
            {
                if (a < 0 && b > 0)
                    a = (-1) * a;
                else if (b < 0 && a > 0)
                    b = (-1) * b;
                else if (a < 0 && b < 0)
                {
                    a = (-1) * a;
                    b = (-1) * b;
                }
                // a = 0, b = 140
                string result = "Нет";
                int d, c;
                while (a > 0)
                {
                    d = a % 10;
                    a = a / 10;
                    c = b;
                    while (c > 0)
                    {
                        if (c % 10 == d)
                        {
                            result = "Да";
                            break;
                        }
                        c = c / 10;
                    }
                    if (result == "Да")
                        break;
                }
                return result;
            }
        }
        #endregion

    }
}
