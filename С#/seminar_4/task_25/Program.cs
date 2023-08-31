// Напишите функцию, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// что такое Math.Pow()
// Math.Pow(x, y) - это функция в C#, которая возводит число x в степень y и возвращает результат. В данном случае Math.Pow(3, 5) вернет 243 (3 в пятой степени).

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































// Console.WriteLine("Введите число:" );
// string numberString1 = Console.ReadLine();

// Console.WriteLine("Напишите цифру, в какую степень возвести число:" );
// string numberString2 = Console.ReadLine();

// int A = Convert.ToInt32(numberString1);
// int B = Convert.ToInt32(numberString2);

// {
//     int result = 1;

//     for (int i = 0; i < B; i++)
//     {
//         result *= A;  // знак * в этой строке - это сокращенная форма записи операции умножения с присваиванием. 
//         // Он умножает значение переменной result на значение переменной A и присваивает результат переменной result.
//         // то же самое result = result * A;

//     }

//     return result; // означает, что функция вернет значение переменной result. 
//     // После выполнения всех операций и вычислений функция возвратит итоговое значение, 
//     // которое будет являться результатом возведения числа A в степень B.

// }

// Console.WriteLine("А в степени В =" + result); // Знак + в этой строке используется для объединения строк. 
// // для конкатенации (объединения) текста и значения переменной result. 
// // код `Console.WriteLine("A в степени B = " + result);` 
// // будет выводить текст "A в степени B =" и значение переменной result на консоль, объединяя их в одну строку.

// static int Power(int A, int B)
//     {
//         int result = 1;

//         for (int i = 0; i < B; i++)
//         {
//             result *= A;
//         }

//         return result;
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число:");
//         string numberString1 = Console.ReadLine();

//         Console.WriteLine("Напишите цифру, в какую степень возвести число:");
//         string numberString2 = Console.ReadLine();

//         int A = Convert.ToInt32(numberString1);
//         int B = Convert.ToInt32(numberString2);

//         int result = Power(A, B);

//         Console.WriteLine($"Число {A} в степени {B} = " + result);
//     }
// }