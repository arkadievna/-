Console.WriteLine("Введите номер дня недели: ");
int dayNum = int.Parse(Console.ReadLine());

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum-1));
// 1. `System.Globalization.CultureInfo.GetCultureInfo("ru-Ru")` 
// - получает информацию о культуре, в данном случае - русскую культуру (`ru-Ru`).
// 2. `DateTimeFormat` 
// - получает информацию о формате даты и времени для данной культуры.
// 3. `GetDayName()` 
// - получает название дня недели на основе переданного значения перечисления `DayOfWeek`.
// 4. `Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum-1)` 
// - получает все значения перечисления `DayOfWeek` и затем получает значение с индексом `dayNum-1`.
// 5. `(DayOfWeek)` - приводит полученное значение к типу `DayOfWeek`.
// 6. Все вышеупомянутые шаги объединяются и результат присваивается переменной `outDayOfWeek`, 
// которая будет содержать название дня недели на русском языке, основываясь на переданном индексе `dayNum`.

Console.WriteLine(outDayOfWeek);