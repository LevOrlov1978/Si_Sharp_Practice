Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows,columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j]  = new Random().Next(-11,11);

        Console.Write($" | {matrix[i,j]}");
    }
    Console.WriteLine();
    
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам:");
for (int j = 0; j < columns; j++)
{
    double tempSum=0; //сумма столбца, обнуляется после подсчета и вывода среднего

    for (int i = 0; i < rows; i++)
   
    {
        tempSum=tempSum+matrix[i,j];

    }
   double average = Math.Round(tempSum/rows,2);
   Console.Write($" | {average}");
}
Console.WriteLine();
