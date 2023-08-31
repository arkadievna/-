// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        double[] array = { 2.5, 1.0, 4.3, 3.7, 2.1, 5.2 };

        Console.WriteLine("Массив вещественных чисел:");
        PrintArray(array);

        double difference = FindDifference(array);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }

    public static void PrintArray(double[] array)
    {
        foreach (double number in array)
        {
            Console.WriteLine(number);
        }
    }

    public static double FindDifference(double[] array)
    {
        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            else if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max - min;
    }
}