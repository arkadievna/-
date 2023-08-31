// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

using System;

Console.WriteLine("Введите первое число: ");
string? numberString1 = Console.ReadLine();

// если убрать знак вопроса после string, появляется ошибка
// D:\Юлия\С#\seminar_1\task_1\Program.cs(10,24): warning CS8600: Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не до 
// пускающий значение NULL. [D:\Юлия\С#\seminar_1\task_1\task_1.csproj]
// D:\Юлия\С#\seminar_1\task_1\Program.cs(13,24): warning CS8600: Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не до 
// пускающий значение NULL. [D:\Юлия\С#\seminar_1\task_1\task_1.csproj]
// НО ПРОГА РАБОТАЕТ

Console.WriteLine("Введите второе число: ");
string? numberString2 = Console.ReadLine();

int numberInt1 = Convert.ToInt32(numberString1);
int numberInt2 = Convert.ToInt32(numberString2);

if (numberInt2 * numberInt2 == numberInt1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}