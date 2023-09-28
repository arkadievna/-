﻿// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А. 
// 7 -> 28 
// 4 -> 10 
// 8 -> 36

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//1) вводим число от пользователя -> ReadData
//2) вычисляем сумму -> ?
//3) выводим результат -> PrintResult

// 1-5 1+2+3+4+5=

int SimpleSum(int numA)
{
    int sumOfNumber = 0; // можно положить 1
    for (int i = 1; i <= numA; i++) // и тут начать с 2
    {
        //sumOfNumber = sumOfNumber + i;
        sumOfNumber+=i;
    }
    return sumOfNumber;
}

int GausseSum(int numA)
{
    int sumOfNumber = 0;
    sumOfNumber=(numA*(numA+1))/2;
    return sumOfNumber;
}

int numberA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
int res1 = SimpleSum(numberA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int res2 = GausseSum(numberA);
Console.WriteLine(DateTime.Now-d2);

PrintResult("Сумма чисел от 1 до "+ numberA + " (простой)равна " + res1);
PrintResult("Сумма чисел от 1 до "+ numberA + " (Гаусса)равна " + res2); // Гаусс - крутой математик: сумма чисел от 1 до n = n * (n+1): 2 