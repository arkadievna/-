﻿// просьба ввести в консоль первое число
Console.WriteLine("Первое число: ");
// считывание из консоли первого числа, конвертация строки в целое число, присвоение к number1
int firstNum = int.Parse(Console.ReadLine());

// просьба ввести в консоль второе число
Console.WriteLine("Второе число: ");
// считывание из консоли второго числа, конвертация строки в целое число, присвоение к number2
int secondNum = int.Parse(Console.ReadLine());

// условие-сравнение, если число1 равно квадрату второго числа
if (firstNum == Math.Pow(secondNum, 2));
{
    // то вывести в консоль этот вариант ответа
    Console.WriteLine("Первое число является квадратом второго");
}

// при методе Math.Pow else уже не работает, терминал выдаёт ошибку
// строки ниже не рабочии в этом варианте решения
// и как вывести в терминал сообщение, что "Первое число не является квадратом второго"
// не понятно
// else
// {
//     // в других вариантах вывести в консоль этот вариант ответа
//     Console.WriteLine("Первое число не является квадратом второго");
// }