﻿int ran = new System.Random().Next(100, 1000);
System.Console.WriteLine(ran);
char[] digitChar = ran.ToString().ToCharArray(); 
// ran.ToString() - Преобразует переменную `ran` в строковое представление
// Предполагается, что `ran` является числовым значением.
// ToCharArray() - Преобразует полученную строку в массив символов (`char[]`). 
// Каждый символ строки будет представлен элементом массива.
// char - это встроенный тип данных, используемый для хранения одного символа, такого как буква, цифра или специальный символ. 
// char[] - это тип данных, представляющий массив символов, где каждый элемент массива является отдельным символом.
// Массив символов `char[]` может содержать любое количество символов и обращаться к ним по индексу. 
// Таким образом, `digitChar` будет содержать массив символов, 
// где каждый элемент будет представлять отдельный символ из строкового представления переменной `ran`. 

System.Console.Write(digitChar[0]);
System.Console.Write(digitChar[2]);
