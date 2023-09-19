int numN = int.Parse(Console.ReadLine()??"0");
int startNumN = (-1)*numN;
while (startNumN < numN)
{
    Console.Write(startNumN + ", ");
    startNumN++;
}
Console.Write(numN);