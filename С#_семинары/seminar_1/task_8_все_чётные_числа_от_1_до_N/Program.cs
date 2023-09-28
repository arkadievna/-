// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;

Console.WriteLine("Введите число: ");
string? numberString = Console.ReadLine();

int numberInt = Convert.ToInt32(numberString);

for (int i = 2; i <= numberInt; i += 2)
{
    Console.Write(i + " ");
}

if (numberInt < 1)
{
    Console.WriteLine("По условию задачи программа показывает все чётные числа от 1. Ваше число меньше 1.");
}

if (numberInt == 1)
{
    Console.WriteLine("По условию задачи программа показывает все чётные числа от 1. В этом промежутке нет чётных чисел.");
}
