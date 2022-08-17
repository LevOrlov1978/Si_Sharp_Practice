int[] array = new int[8];

for (int i = 0; i <= 7; i++)
{
Console.WriteLine ($"Введите элемент массива №{i+1}"); 
array[i] = Convert.ToInt32(Console.ReadLine()); 
}
Console.WriteLine($"Массив: [{String.Join(";",array)}]");