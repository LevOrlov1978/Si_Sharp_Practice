Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

int NumbersSum (int Number)
{
int Sum=0;
while (Number>0)
{

Sum=Sum+Number%10;
Number=Number/10;
}
return Sum;
}
Console.WriteLine($"Сумма цифр {NumbersSum(N)}");