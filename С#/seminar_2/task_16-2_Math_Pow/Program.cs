int GetNum() // обернуто в метод запрос
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int firstNum = GetNum();
int secondNum = GetNum();

bool firstPow = firstNum == Math.Pow(secondNum, 2);
bool secondPow = secondNum == Math.Pow(firstNum, 2);

Console.WriteLine(firstPow  || secondPow ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");

