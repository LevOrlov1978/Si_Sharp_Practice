Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество этажей: ");
int floors = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[rows, columns, floors];

for (int i = 0; i < rows; i++)
{ 
    for (int j = 0; j < columns; j++)    
    {
       for (int k = 0; k < floors; k++)
       {
       Console.WriteLine("Введите двузначное число. Числа не должны повторяться!");
        matrix[i,j,k] = Convert.ToInt32(Console.ReadLine());
    
       }
    }

}
Console.WriteLine("Вывод трехмерной матрицы");
for (int k = 0; k < floors; k++)
{
    for (int i = 0; i < rows; i++)    
    {
       Console.WriteLine();
       for (int j = 0; j < columns; j++)
       {
      
        Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
       }
    }

}
 Console.WriteLine();