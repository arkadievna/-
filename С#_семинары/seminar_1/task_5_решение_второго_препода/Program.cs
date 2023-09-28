int numberN = int.Parse(Console.ReadLine()??"0");
int startNumN = (-1)*numberN;
while (startNumN < numberN)
{
Console.Write(startNumN+", "); // пробел в кавычках после запятой, чтоб пробел был после запятой
// а пробелы между '+' и остальным не имеют значения, без ошибки
startNumN = startNumN+1; // не имеет значения есть пробелы в 'startNumN+1' или нет 
// 'startNumN + 1' или так 'startNumN +1' или так 'startNumN+ 1' во всех случаях без ошибки 
}
Console.WriteLine(numberN);


