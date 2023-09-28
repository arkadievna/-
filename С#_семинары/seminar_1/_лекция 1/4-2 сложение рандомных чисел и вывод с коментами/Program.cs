int numberA = new Random().Next(1,10);
Console.Write("Первое число: "); // Write без Line означает, что курсор останется на строке с текстом "Первое число: "
Console.WriteLine(numberA); // WriteLine означает, что курсор перейдёт на следующую строку после вывода рандомного числа
int numberB = new Random().Next(1,10);
Console.Write("Второе число: ");
Console.WriteLine(numberB);
int result = numberA + numberB; 
Console.Write("Сумма чисел: ");
Console.WriteLine(result);
