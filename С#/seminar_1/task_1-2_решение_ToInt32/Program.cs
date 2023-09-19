using System;

Console.WriteLine("Введите первое число: ");
string? numberString1 = Console.ReadLine();

// если убрать знак вопроса после string, появляется ошибка
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