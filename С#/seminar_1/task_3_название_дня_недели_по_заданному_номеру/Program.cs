﻿// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 9 -> Нет такого дня недели

using System;

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

string dayName; // это объявление переменной `dayName` типа `string`
// В этой переменной будет сохраняться название дня недели, 
// соответствующее введенному числу.

switch (day) // выбор вариантов внутри переменной 
// switch является конструкцией языка программирования, 
// которая позволяет выбирать один из нескольких блоков кода для выполнения, 
// в зависимости от значения выражения в `switch`. 
// В данном коде, `day` - это выражение, которое выбирает соответствующий блок кода, 
// основываясь на введенном числе.
{
    case 1: // это оператор в блоке `switch`, который определяет случаи, 
    // для которых будет выполняться определенный блок кода. 
    // В данном коде, каждый `case` определяет числа от 1 до 7, 
    // которые соответствуют дням недели. 
    // Когда `day` принимает значение определенного `case`, выполнение кода продолжается с этого `case`.
        dayName = "Понедельник";
        break; // оператор `break` используется для выхода из блока `switch`, 
        // после выполнения соответствующего `case`. 
        // Без `break` код будет продолжать выполняться в следующих `case`, 
        // что может привести к непредсказуемым результатам. 
    case 2:
        dayName = "Вторник";
        break;
    case 3:
        dayName = "Среда";
        break;
    case 4:
        dayName = "Четверг";
        break;
    case 5:
        dayName = "Пятница";
        break;
    case 6: dayName = "Суббота"; break;
    // в одну строку тоже можно
    case 7: dayName = "Воскресенье"; break;
    default: dayName = "Нет такого дня недели"; break;
}

Console.WriteLine(dayName);