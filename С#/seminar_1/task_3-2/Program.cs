// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 9 -> Нет такого дня недели

using System;

Console.WriteLine("Введите номер дня недели: ");
string? numberString = Console.ReadLine();

int numberInt = Convert.ToInt32(numberString);

if (numberInt == 1)
{
Console.WriteLine("Понедельник");
}

if (numberInt == 2)
{
Console.WriteLine("Вторник");
}

if (numberInt == 3)
{
Console.WriteLine("Среда");
}

if (numberInt == 4)
{
Console.WriteLine("Четверг");
}

if (numberInt == 5)
{
Console.WriteLine("Пятница");
}

if (numberInt == 6)
{
Console.WriteLine("Суббота");
}

if (numberInt == 7)
{
Console.WriteLine("Воскресенье");
}

if (numberInt > 7 || numberInt < 1)
// знаки && и || отличаются действием
// в этой задаче знак && никак не работает

// В языке C# два знака && и || служат для логических операций "И" и "ИЛИ".

// 1. `&&` (И) - дает `true` только в том случае, если оба операнда вычисляются как `true`. Если хотя бы один операнд оценивается как `false`, то оператор вернет `false`. Пример:

// ```csharp
// bool a = true;
// bool b = false;
// bool result = a && b;
// Console.WriteLine(result); // output: False
// ```

// 2. `||` (ИЛИ) - дает `true`, если хотя бы один операнд является `true`. Оператор вернет `false`, только если оба операнда - `false`.

{
Console.WriteLine("Нет такго дня недели");
}
