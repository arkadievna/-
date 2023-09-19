Console.WriteLine("Введите номер дня недели: ");
int dayNum = int.Parse(Console.ReadLine());

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum-1));

Console.WriteLine(outDayOfWeek);