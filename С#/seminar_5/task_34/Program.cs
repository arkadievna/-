// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10);

        Console.WriteLine("Массив случайных трехзначных чисел:");
        PrintArray(array);

        int count = CountEvenNumbers(array);
        Console.WriteLine("Количество четных чисел: " + count);
    }

    public static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        return array;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
    }

    public static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}           