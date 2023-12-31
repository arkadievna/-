﻿// код содержал функцию `Length`, 
// которая вычисляет расстояние между двумя точками в двумерном пространстве. 
// необходимо создать новый метод `DistanceBetweenPoints`, 
// который будет вычислять расстояние между двумя точками в трехмерном пространстве. 

using System;

public class Answer
{
    private static double DistanceBetweenPoints(int[] pointA, int[] pointB)
    {
        double deltaX = pointB[0] - pointA[0];
        double deltaY = pointB[1] - pointA[1];
        double deltaZ = pointB[2] - pointA[2];

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

        return distance;
    }

    // Не удаляйте и не меняйте метод Main!
    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = DistanceBetweenPoints(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}

// Теперь метод `Main` вызывает новую функцию `DistanceBetweenPoints`, 
// которая вычисляет расстояние между двумя точками в трехмерном пространстве. 
