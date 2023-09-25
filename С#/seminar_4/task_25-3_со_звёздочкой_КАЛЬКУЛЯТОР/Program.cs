// using statement позволяет использовать классы и методы из пространства имен System, в том числе класс Console, который используется в коде для работы с консолью
using System;
class Calculator
{
    static void Main() // точка начала выполнения программы
    {
        // приветствие
        Console.WriteLine("Здравствуйте, Андрей! Добро пожаловать в калькулятор!");

        // ввод числа A
        Console.Write("Введите число A:");
        // // преобразование строки в число 
        // double a = double.Parse(Console.ReadLine() ?? "0"); // "double" для работы с числами с десятичной частью
        double a;
        if (!double.TryParse(Console.ReadLine(), out a))
        {
            a = 0;
        }

        // ввод числа B
        Console.Write("Введите число B:");
        // // преобразование строки в число 
        // double b = double.Parse(Console.ReadLine() ?? "0");
        double b;
        if (!double.TryParse(Console.ReadLine(), out b)) // восклицательный знак для инверсии результата метода TryParse() -> преобразование строки в число -> возврат булевое значение
        // успешное преобразование -> true + результат преобразования сохраняется в переменной b
        // если не успешное -> false + инструкции внутри условия if
        // инвертирование -> если TryParse() возвращает true, то результат условия false, и инструкции внутри if не выполняются
        // инвертирование false -> результат условия true + инструкции внутри условия выполняются
        // если преобразование строки в число b не удалось -> вернет true + присвоение значения по умолчанию 0 переменной b
        {
            b = 0;
        }

        // выбор операции
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("+ - Сложение");
        Console.WriteLine("- - Вычитание");
        Console.WriteLine("* - Умножение");
        Console.WriteLine("/ - Деление");
        Console.WriteLine("^ - Возведение в степень");

        // // преобразование строки в символ типа"char"
        // char operation = char.Parse(Console.ReadLine() ?? "+"); // "char" для работы и хранения одиночных символов = - * и т.д.
        // // переменная "result" для хранения результата вычисления по умолчанию равна 0
        // double result = 0;

        char operation;
        if (!char.TryParse(Console.ReadLine(), out operation))
        {
            operation = '+';
        }

        double result = 0;
        // выполнение выбранной операции
        switch (operation) // выбор одной из веток операции, в зависимости от выбора пользователя
        {
            case "+":
                // сложение
                result = a + b;
                Console.Write("Результат: " + result);
                break; // прерывание выполнения и выход из текущей ветки
            case "-":
                // вычитание
                result = a - b;
                Console.Write("Результат: " + result);
                break;
            case "*":
                // умножение
                result = a * b;
                Console.Write("Результат: " + result);
                break;
            case "/":
                // деление
                if (b != 0)
                {
                    result = a / b;
                    Console.Write("Результат: " + result);
                }
                else
                {
                    Console.WriteLine("Ошибка! Деление на ноль невозможно.");
                }
                break;
            case "^":
                // возведение в степень
                result = Math.Pow(a, b);
                Console.Write("Результат: " + result);
                break;
            default: // если ни одно из значений веток case не совпадает с выбором
                // вывод сообщения об ошибке при вводе некорректной операции
                Console.WriteLine("Ошибка! Введена некорректная операция.");
                break;
        }

        // завершение программы после нажатия любой клавиши
        Console.WriteLine("Нажмите любую клавишу, чтобы закрыть калькулятор.");
        Console.ReadKey(); // метод ожидания нажатия любой клавиши для выхода
    }
}





