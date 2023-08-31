// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

        Console.WriteLine("Элементы массива:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}