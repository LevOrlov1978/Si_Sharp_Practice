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
Console.Write("Введите номер строки элемента:");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());

if (rowNumber<=rows && columnNumber<=columns)
{
    Console.WriteLine ($"Элемент массива:{matrix[rowNumber-1,columnNumber-1]}");   
}
else
{
    Console.WriteLine("Такого элемента нет");
}