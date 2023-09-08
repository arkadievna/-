// int numberA = new Random().Next(1,10); // 1 2 3 4 … 9
// int numberB = new Random().Next(1,10); // 1 2 3 4 … 9
// int result = numberA + numberB; 
// Console.WriteLine(result);
// добавляю в этот код строки, чтобы в терминале было показано 
// какие цифры программа рандомно выбрала для сложения
// для этого нужно задать команду вывода выбранного числа в терминал

int numberA = new Random().Next(1, 10); // 1 2 3 4 … 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10); // 1 2 3 4 … 9
Console.WriteLine(numberB);
int result = numberA + numberB; 
Console.WriteLine(result);