﻿// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 9 -> Нет такого дня недели

int day = int.Parse(Console.ReadLine()??"0");
// два вопросительных знака `??` используются для проверки и предоставления значения по умолчанию, 
// если результат выражения слева от `??` равен `null`
// `Console.ReadLine()` возвращает введенную строку с консоли. 
// Однако, если пользователь ничего не вводит и просто нажимает Enter, 
// то результат будет `null`. 
// Выражение `Console.ReadLine() ?? "0"` означает, что если `Console.ReadLine()` равно `null`, 
// то будет использовано значение "0" вместо ввода пользователя.
// Затем, полученное значение строкового типа парсится в целочисленное значение с помощью метода `int.Parse()`, 
// и результат сохраняется в переменную `numberDay`.

string[] dayOfWeek = new string [7];
// в этой строке создается новый массив строк (string array) с размером 7, 
// который будет использоваться для хранения названий дней недели.
// `string[]` указывает на то, что создается массив строковых значений.
// `dayOfWeek` - это имя переменной, которая будет ссылаться на этот массив.
// `new string[7]` создает новый экземпляр массива строк длиной 7 элементов. 
// это значит, что в данном массиве можно хранить 7 значений типа string.
// После создания массива, переменная `dayOfWeek` будет ссылаться на него, 
// и можно будет получать и изменять элементы массива с помощью индексов 
// (например: `dayOfWeek[0]`, `dayOfWeek[1]`, и т.д.)

dayOfWeek[0] = "Понедельник";

dayOfWeek[1] = "Вторник";

dayOfWeek[2] = "Среда";

dayOfWeek[3] = "Четверг";

dayOfWeek[4] = "Пятница";

dayOfWeek[5] = "Суббота";

dayOfWeek[6] = "Воскресенье";
// оператор присваивания значения элементу массива `dayOfWeek` с индексом `6`.
// В данном случае, `dayOfWeek` - это массив строк, а `[6]` - это индекс, 
// указывающий на элемент массива, которому будет присвоено значение "Воскресенье".
// Массивы в языках программирования обычно начинаются с индекса 0, 
// поэтому эта строка присваивает значение "Воскресенье" шестому элементу массива `dayOfWeek`.
// Теперь, шестой элемент массива `dayOfWeek` содержит значение "Воскресенье",
// и его можно получить, обратившись к этому элементу по индексу `[6]` (например, `dayOfWeek[6]`).

Console.WriteLine(dayOfWeek[day-1]);
// означает, что будет выведено на консоль значение элемента массива `dayOfWeek` с индексом, 
// указанным в выражении `day-1`.
// `day` предполагается переменная (`int day`), которая обозначает номер дня недели. 
// Выражение `day-1` используется для получения правильного индекса элемента массива, 
// так как массивы обычно начинаются с индекса 0. Например, если `day` равно 1, то `day-1` будет равно 0, 
// и будет получено значение первого элемента массива `dayOfWeek`.
// Функция `Console.WriteLine()` выводит значение элемента массива, 
// указанного в скобках, на консоль. 
// Таким образом, на консоль будет выведено значение элемента массива `dayOfWeek` с индексом `day-1`.