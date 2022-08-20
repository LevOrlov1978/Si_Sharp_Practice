Console.WriteLine("Введите количество элементов массива");
int ArrayLength = Convert.ToInt32(Console.ReadLine());

int EvenSum (int Length)
{
int Count=0;
int[] array = new int[Length];

for (int i = 0; i < Length; i++)
{
    array[i] = new Random().Next(100,1000);  
    if (array[i]%2==0)
    {
        Count=Count+1;
    }
}
Console.WriteLine($"Массив: [{String.Join(";",array)}]");
return Count;
}
Console.WriteLine($"Количество четных {EvenSum(ArrayLength)}");