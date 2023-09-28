// Напишите функцию, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Math.Pow(x, y) - это функция, которая возводит число x в степень y и возвращает результат. 
// В данном случае Math.Pow(3, 5) вернет 243 (3 в пятой степени).

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        double result = Power(A, B);
        Console.WriteLine("A в степени B = " + result);
    }

    public static double Power(double A, int B)
    {
        if (B == 0)
        {
            return 1;
        }

        double result = A;
        int exponent = Math.Abs(B) - 1;

        while (exponent > 0)
        {
            result *= A;
            exponent--;
        }

        if (B < 0)
        {
            result = 1 / result;
        }

        return result;
    }
}