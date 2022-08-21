Console.WriteLine("Введите количество элементов массива");
int ArrayLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X (границы случайных  значений от -Х до +Х)");
int RandomBorder = Convert.ToInt32(Console.ReadLine());

double DiffMaxMin (int Length, int Border)
{
double Diff=0;

double[] array = new double[Length];
double Max=array[0];
double Min=array[0];
for (int i = 0; i < Length; i++)
{
   //Console.WriteLine($"Введите элемент массива {i}");
   //array[i] = Convert.ToDouble(Console.ReadLine());
   array[i] = new Random().Next((-1*Border-1),(Border+1));  
    if (array[i]>Max)
    {
       Max=array[i];
    }
    else if (array[i]<Min)
    {
      Min=array[i];  
    }
}
Diff=Max-Min;
Console.WriteLine($"Массив: [{String.Join(";",array)}]");
return Diff;
}
Console.WriteLine($"Разность большего и меньшего: {DiffMaxMin(ArrayLength, RandomBorder)}");
