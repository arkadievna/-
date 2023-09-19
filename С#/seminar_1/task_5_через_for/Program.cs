int a = int.Parse(Console.ReadLine()); // int a = int.Parse(Console.ReadLine()??"0"); 
// с вопросительными знаками и нулём не будет жёлтого оповщения в терминале о null 
if (a < 0) a = -a;
for (int i = -a; i <= a; i++)
{
    Console.Write(i);
    Console.Write(", ");
}