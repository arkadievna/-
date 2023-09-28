using System;

class Program
{
    static void Main()
    {
        // ввод числа
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()?? "0");

        // вычисление суммы цифр в числе
        int sum = 0;
        int tempNumber = number;
        while (tempNumber > 0)
        {
            sum += tempNumber % 10;
            tempNumber /= 10;
        }

        // вывод суммы цифр на экран
        Console.WriteLine("Сумма цифр в числе: " + sum);

        // оценка времени 
        string timeMessage = "Время выполнения алгоритма: ";
        double startTime = DateTime.Now.Ticks / (double)TimeSpan.TicksPerSecond;
        string endTimeString = string.Empty;
        double endTime = DateTime.Now.Ticks / (double)TimeSpan.TicksPerSecond;
        double elapsedTime = endTime - startTime;
        timeMessage += elapsedTime.ToString("F6") + " сек.";
        Console.WriteLine(timeMessage);
    }
}

