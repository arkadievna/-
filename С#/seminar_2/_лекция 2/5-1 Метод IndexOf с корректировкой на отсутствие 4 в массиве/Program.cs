//если поискать элемент, которого точно не существует,
//например, элемент 444, и запустить этот код, выйдет позиция 0. 
//Посмотрим, как обходить такие ситуации. 
 
//По умолчанию мы указывали позицию 0. 
//Очевидно, что нулевая позиция есть. 
//Если мы ищем какой-то элемент, то либо он будет равен 0, либо больше 0. 
//Но если не встречается ни одного элемента, то договоримся,
//что по умолчанию станет возвращаться значение -1. 
//Это искусственный приём. То есть, если элемента нет, значит, выйдет -1. 
//Таким образом, если запустить наш код, обнаружится значение позиции, равное -1. 
//Это значит, что такой элемент не найден. 

void FillArray(int[] collection) 
{ 
    int length = collection.Length;
    int index = 0; 
    while (index < length) 
    {          
        collection[index] = new Random().Next(1, 10);     
        index++; 
    } 
} 

void PrintArray(int[] col)
{
  int count = col.Length; 
  int position = 0;
    while (position < count)
    {
      Console.WriteLine(col[position]); 
      position++; 
    }
}

int IndexOf(int[] collection, int find) 
{ 
    int count = collection.Length; 
        int index = 0; 
        int position = -1; 
        while (index < count) 
        {
            if(collection[index] == find) 
            {
                position = index;
                break; 
            }
            index++;
        }
        return position; 
 } 

int[] array = new int[10]; 

FillArray(array); 
//деактивирую эти строки, чтобы исправить программу
//array [4] = 4; //принудительное добавление четвёрки в четвёртый индекс
//array [6] = 4; //ещё одно принудительное добавление
PrintArray(array); 

Console.WriteLine();
int pos = IndexOf(array, 4); //ищем число 4 в массиве

Console.WriteLine(pos);

