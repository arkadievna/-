// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 9 -> Нет такого дня недели

using System;

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

string dayName;

switch (day) 
{
    case 1:
        dayName = "Понедельник";
        break;
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
    case 6:
        dayName = "Суббота";
        break;
    case 7:
        dayName = "Воскресенье";
        break;
    default:
        dayName = "Нет такого дня недели";
        break;
}

Console.WriteLine(dayName);