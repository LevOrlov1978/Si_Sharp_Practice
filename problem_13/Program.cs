Console.WriteLine("Введите целое положительное число");
string number = Console.ReadLine();
char[] array = number.ToCharArray();
if (array.Length < 3)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine(array[2]);