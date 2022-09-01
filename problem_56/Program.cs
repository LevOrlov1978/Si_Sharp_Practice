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


int minRowNumber=0;
int minSum=100000;// не получается вызвать maxvalue
for (int i = 0; i < rows; i++)
{
  int sum=0;
  
  for (int j = 0; j < columns; j++)
  {
    sum=sum+matrix[i,j];
  }
//Console.WriteLine(sum);
if (sum<minSum)
{ minSum=sum;
  minRowNumber=i+1; //первая строка - №1
  }

}
Console.WriteLine($"Строка с наименьшей суммой: №{minRowNumber}"); 