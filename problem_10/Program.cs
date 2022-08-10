Console.WriteLine("Введите трехзначное число");
string threeDigits = Console.ReadLine();
int threeDigitNumber = int.Parse(threeDigits);
int twoDigits = threeDigitNumber/10;
Console.WriteLine($"второй знак: {twoDigits %10}");