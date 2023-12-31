﻿//определим новый массив, дадим int имя array
//технически чисел в массиве может быть сколько угодно, 
//потому сейчас мы реализовываем задачу для любого количества элементов. 
//             0  1 2  3 4  5  6   7   8
int[] array = {1,12,31,4,15,16,17,18, 88888}; 
//Далее по алгоритму требуется n элементов. 
//Чтобы получить n, напишем: 
int n = array.Length; 
//Внутри массива есть информация о том, сколько элементов в нём содержится. 
//В частности, array.Length возвращает длину или количество элементов массива. 
//Выберем число 4: 
int find = 18; //нужно найти число 4 среди всех чисел массива
//по алгоритму требуется установить счётчик index  
//Индекс равный 0
//Помним, что элементы в нашем массиве начинаются с 0, то есть 1 стоит под нулевой позицией: 
int index = 0; 
//Далее нам потребуется цикл while, в котором будем проверять: 
//если index < n
//на каждом этапе надо увеличивать значение индекса: 
while (index < n) 
    { 
    //можно показать значение позиции
    //Обратите внимание, что понятие эквивалентно равенству левой части и правой. 
    //То есть элемент, находящийся по нужному индексу, равен элементу find.
      if(array[index] == find) //эту строку добавили, чтобы определить индекс искомого числа
      { 
        Console.WriteLine(index); //эту строку добавили, чтобы вывести в терминал  индекс искомого числа
        break; //для остановки поиска, когда нужное число найдётся. 
        //если будет несколько одинаковых чисел, из-за этой строки выйдет только одно - первое найденное число
      }
    //index = index + 1; //Программисты пишут это в более короткой форме:
      index++;
    } 
//Если array[index] совпал с find, то алгоритм завершает свою работу

//сли у нас будет несколько одинаковых элементов, наш алгоритм покажет их все: 
//int[] array = {1,12,31,4,18,15,16,17,18}; 

//Посмотрим, как он выглядит. 
//Если выполняется это условие, то просто добавляется break («прервать»): 
//if(array[index] == find) 
//{ 
//    Console.WriteLine(index);  
//} 
//Перезапустим программу и убедимся, что будет найден первый элемент. 
//Находим первый элемент и завершаем на этом свою работу. 
//Мы выполнили условие пункта 2 нашего алгоритма. 
//То есть, если array[index] совпал с find, 
//значит, алгоритм завершил работу успешно, мы узнали индекс и решили задачу. 