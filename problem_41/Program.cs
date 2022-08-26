Console.WriteLine("Введите необходимое количество чисел");
int M = Convert.ToInt32(Console.ReadLine());
int countPositive = 0;
 
for (int i = 1; i <= M; i++)
{
    Console.WriteLine($"Введите число {i}");
    double temporaryNumber = Convert.ToDouble(Console.ReadLine());
   
    if (temporaryNumber>0)
    {
        countPositive=countPositive+1;  
    }
}
Console.WriteLine($"Чисел больше нуля -  {countPositive}");