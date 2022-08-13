Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов от 1 до N:");
for (int i = 1; i <= N; i++)
{
 Console.WriteLine(Math.Pow(i,3));  
}