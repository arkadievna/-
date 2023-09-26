﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// точка входа
public class Program 
{
    // основной метод, выполняется при старте программы
    public static void Main(string[] args) // на вход аргумент в виде массива строк "string[] args"
    {
        // создание массива целых чисел
        // значения попадают в массив из метода GenerateRandomArray, который генерирует случайные числа 
        int[] array = GenerateRandomArray(10); // 10 случайных чисел

        
        Console.Write("Массив случайных чисел: "); // вывод на консоль текста
        PrintArray(array); // метод PrintArray выводит на консоль содержимое массива array

        int sum = SumOddPositionElements(array); // создание переменной sum, в которую записывается результат метода SumOddPositionElements (суммирует числа на нечетные позициях в массиве)
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum); // вывод на консоль текста
    }

    // создание метода для генерации случайного массива заданного размера
    public static int[] GenerateRandomArray(int size) // метод принимает на вход параметр size типа int
    {
        Random random = new Random(); // создание экземпляра класса Random с именем "random"
        int[] array = new int[size]; // создание пустого массива "array" типа int, размер задаётся параметром "size"

        for (int i = 0; i < size; i++) // цикл выполняется от 0 до size-1
        {
            array[i] = random.Next(1, 100); // каждой ячейке массива присвоено случайное число от 1 до 100 с помощью метода random.Next()
        }

        return array; // возвращает сгенерированный массив
    }

    // метод принимает на вход параметр array типа int
    // public static void PrintArray(int[] array) // используется для вывода элементов массива на консоль
    // {
    //     foreach (int number in array) // цикл выполняется для каждого элемента массива array
    //     {
    //         Console.WriteLine(number); // вывод на консоль
    //     }
    // }
      public static void PrintArray(int[] array)
    {
        // вывод на консоль всех элементов массива в строку через запятую и пробел
        // метод string.Join объединяет элементы массива в одну строку, ставит между ними указанный разделитель
        Console.WriteLine(string.Join(", ", array));
    }

    // создание метода, принимает на вход параметр array типа int
    public static int SumOddPositionElements(int[] array) // метод для суммирования элементов массива на нечетных позициях
    {
        // переменная для хранения суммы элементов массива
        int sum = 0; // создание переменной sum типа int, присвоение ей значения 0

        for (int i = 1; i < array.Length; i += 2) // цикл выполняется для каждого нечетного индекса i от 1
        {
            sum += array[i]; // каждый элемент массива array с нечетным индексом суммируется с переменной sum
        }

        return sum; // возврат суммы элементов массива на нечетных позициях
    }
}