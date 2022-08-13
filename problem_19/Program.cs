Console.WriteLine("Введите пятизначное положительное число");
string number = Console.ReadLine();
char[] array = number.ToCharArray();
if (array[0] == array[4] && array[1] == array[3])
Console.WriteLine("палиндром");
else
Console.WriteLine("не палиндром");