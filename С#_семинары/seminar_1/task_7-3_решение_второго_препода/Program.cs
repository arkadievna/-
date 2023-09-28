int num = int.Parse(Console.ReadLine()??"0"); 
// if (num ToString()Length == 3); // проверка длинны строки с помощью ToString не очень хороший метод, т.к. он очень медленный
// ниже быстрее
if(num > 100 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine("Последняя цифра " + num + " это: " + lastDigit);
}
else
{
Console.WriteLine("Число не трёхзначное.");
}


