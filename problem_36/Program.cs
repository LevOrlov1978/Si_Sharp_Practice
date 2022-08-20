Console.WriteLine("Введите количество элементов массива");
int ArrayLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X (границы случайных  значений от -Х до +Х)");
int RandomBorder = Convert.ToInt32(Console.ReadLine());

int NotEvenSum (int Length, int Border)
{
int Sum=0;
int[] array = new int[Length];

for (int i = 0; i < Length; i++)
{
    array[i] = new Random().Next((-1*Border-1),(Border+1));  
    if (i%2!=0)
    {
       Sum=Sum+array[i];
    }
}
Console.WriteLine($"Массив: [{String.Join(";",array)}]");
return Sum;
}
Console.WriteLine($"Сумма на нечетных позициях: {NotEvenSum(ArrayLength, RandomBorder)}");
