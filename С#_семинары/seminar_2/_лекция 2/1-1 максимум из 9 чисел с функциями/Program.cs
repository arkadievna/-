﻿//Итак, вначале опишем некоторую функцию, назовём её max. 
//Так как мы работаем с целыми числами, то будем так же возвращать int: 

// int Max(int);

//Далее наша функция будет проделывать такую работу: 
//возьмёт три числа и найдёт из них максимальное. 
//Затем мы возьмём следующие три числа и найдём максимальное, 
//повторим это действие несколько раз, а потом устроим суперфинал. 
//Итак, возьмём некоторый аргумент 1, опишем некоторый аргумент 2 и 3. 

int Max(int arg1, int arg2, int arg3) // arg - argument - так назвали переменные

//После этого опишем тело метода: 
{ 
    int result = arg1; // result - это max из первой тройки чисел
    if(arg2 > result) result = arg2; 
    if(arg3 > result) result = arg3; 
    return result; // "return" в C# используется для возврата значения из метода или функции
    // Когда в методе встречается оператор "return", выполнение метода прекращается 
    // и управление возвращается в вызывающий код. 
    // При этом может быть возвращено определенное значение.
} 

//Определяем внутренний result, где будет храниться значение max. 
//Далее, если 

// arg2 > result, то в result надо положить arg2. 
// То же самое проделываем с третьей строчкой кода. 
// Теперь требуется, чтобы наш метод возвращал result. 
// Таким образом, у нас появляется вспомогательный механизм, который ищет максимум из трёх чисел. 

//Если в предыдущем примере мы писали 8 строчек кода, то теперь они не нужны. 
//Удаляем их: 
//If (b1 > max) max = b1; 
//If (c1 > max) max = c1;   
//If (a2 > max) max = a2; 
//If (b2 > max) max = b2; 
//If (c2 > max) max = c2;   
//If (a3 > max) max = a3; 
//If (b3 > max) max = b3; 
//If (c3 > max) max = c3; 

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

//Но у нас должно быть определено три финалиста. 
//Поэтому создадим переменную max1 и скажем, 
//что результатом работы функции max будет максимальная из трёх чисел: a1, b1 и c1: 

int max1 = Max(a1, b1, c1); 

//После того как отработает этот кусочек кода, мы получим максимум из первой тройки игроков. 
//Аналогичным образом проделаем эти действия для второй и третьей тройки игроков: 
 
int max2 = Max(a2, b2, c2); 
int max3 = Max(a3, b3, c3); 

//Поэтому заводим отдельные переменные, а после того как всё будет сделано, устроим окончательный финал. 
//Попросим max принять на вход max1, max2 и max3: 

int max = Max(max1, max2, max3); 

//Если возникает какая-то ошибка, то эту ошибку мы будем исправлять в одном месте, 
//а не бегать по всему коду и в каждой строке вносить правки. 
//Сейчас мы применяем промежуточные переменные, чтобы использовать их в конечном финале. 
//Но посмотрим, что может произойти на самом деле. 
//Закомментируем это код, чтобы не мешал: 
// int max1 = Max(a1, b1, c1); 
// int max1 = Max(a2, b2, c2); 
// int max1 = Max(a3, b3, c3); 
// int max1 = Max(max1, max2, max3); 

//Перепишем результирующий вариант. 
//Возьмём значение max переменной max и то, что посчитали. 
//Но вместо того, чтобы использовать дополнительные переменные, внутри аргумента передадим функцию. 

//int max = Max( Max(a1, b1, c1) Max(a2, b2, c2) Max(a3, b3, c3)); 

//Это небольшая ссылка к функциональному программированию. 
Console.WriteLine(max); 

