Console.Write("Введите целое неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое неотрицательное число n, n>m: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum (int number1, int number2)
{
if (number2-number1 == 1) return number1+number2;

 return (number1+Sum(number1+1, number2));

 
 }
Console.WriteLine(Sum(m,n));