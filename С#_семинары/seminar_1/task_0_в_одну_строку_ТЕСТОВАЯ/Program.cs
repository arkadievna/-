Console.WriteLine("Введите число: ");
string? inputNum = Console.ReadLine()!;
Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));