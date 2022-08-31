void PrintArray (int [,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write($" | {inputMatrix[i,j]}");
        }
        Console.WriteLine();
    }
}


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

    }

}


PrintArray(matrix);
Console.WriteLine();

int temp=0;
for (int k = 0; k < rows; k++)
{

for (int i = 0; i < columns; i++)
{

for (int j = 0; j < columns - 1 - i; j++)
{

if (matrix[k,j] < matrix[k,j + 1])
 {

 temp=matrix[k,j];
 matrix[k,j]=matrix[k,j + 1];
 matrix[k,j + 1]=temp;

 }
  }
}
}
PrintArray(matrix);