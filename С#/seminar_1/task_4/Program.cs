// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System;

Console.WriteLine("Введите первое число: ");
string? numberString1 = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? numberString2 = Console.ReadLine();

Console.WriteLine("Введите третье число: ");
string? numberString3 = Console.ReadLine();

int numberInt1 = Convert.ToInt32(numberString1);
int numberInt2 = Convert.ToInt32(numberString2);
int numberInt3 = Convert.ToInt32(numberString3);

int max = numberInt1;

if (numberInt2 > max)
{
max = numberInt2;
Console.WriteLine("Максимальное число: " + max);
}

if (numberInt3 > max)
{
max = numberInt3;
Console.WriteLine("Максимальное число: " + max);
}

else if (numberInt1 == numberInt2 && numberInt2 == numberInt3)
// знаки && и || отличаются действием
// в этой задаче при знаке && при любой последовательности чисел, если есть два одинаковых числа, выходит максимальное число
// при знаке || выходит и максимальное число и сообщение, что числа равны 

// В языке C# два знака && и || служат для логических операций "И" и "ИЛИ".

// 1. `&&` (И) - дает `true` только в том случае, если оба операнда вычисляются как `true`. 
// Если хотя бы один операнд оценивается как `false`, то оператор вернет `false`. Пример:

// ```csharp
// bool a = true;
// bool b = false;
// bool result = a && b;
// Console.WriteLine(result); // output: False
// ```

// 2. `||` (ИЛИ) - дает `true`, если хотя бы один операнд является `true`. Оператор вернет `false`, только если оба операнда - `false`.

{
Console.WriteLine("Числа равны");
}


