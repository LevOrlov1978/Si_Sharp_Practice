Console.WriteLine("Введите номер дня недели от 1 до 7");
string weekDay = Console.ReadLine();
int weekDayNumber = int.Parse(weekDay);
if (weekDayNumber == 6 | weekDayNumber == 7)
Console.WriteLine("выходной");
else
Console.WriteLine("будний");