Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[rows,columns];

//массив с случайными вещественными числами от -10 до 10
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j]  = Math.Round(new Random().Next(-11,11)*
                                new Random().NextDouble(),2);

        Console.Write($" | {matrix[i,j]}");
    }
    Console.WriteLine();
}