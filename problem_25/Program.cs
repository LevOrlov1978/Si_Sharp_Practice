Console.WriteLine("Введите основание степени");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени");
int B = Convert.ToInt32(Console.ReadLine());
int Sum=1;
for (int i = 0; i < B; i++)
{
    Sum=Sum*A;
}
Console.WriteLine($"A в степени B = {Sum}");