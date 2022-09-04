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
Console.Write("Введите количество строк(столбцов) двух квадратных матриц: ");
int rows = Convert.ToInt32(Console.ReadLine());


int [,] matrixOne = new int[rows,rows];
int [,] matrixTwo = new int[rows,rows];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        matrixOne[i,j]  = new Random().Next(-11,11);
        matrixTwo[i,j]  = new Random().Next(-11,11);
    }

}
PrintArray(matrixOne);
Console.WriteLine();
Console.WriteLine();
PrintArray(matrixTwo);
Console.WriteLine();
Console.WriteLine();

int [,] matrixResult = new int[rows,rows];
for (int k = 0; k < rows; k++)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
         matrixResult[i,j]=matrixResult[i,j]+matrixOne[i,k]*matrixTwo[k,j];
        }
    }
}
Console.WriteLine("Произведение матриц: ");
PrintArray(matrixResult);