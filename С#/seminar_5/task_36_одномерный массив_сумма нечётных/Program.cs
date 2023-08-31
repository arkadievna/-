// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10);

        Console.WriteLine("Массив случайных чисел:");
        PrintArray(array);

        int sum = SumOddPositionElements(array);
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }

    public static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100);
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

    public static int SumOddPositionElements(int[] array)
    {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        return sum;
    }
}