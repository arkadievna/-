Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(num > 99 && num < 1000 ? num % 10 : "Число не трёхзначное");