Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann (int number1, int number2)
{    
// Базовый случай    

if (number1 == 0) return number2+1;
if (number2 == 0 && number1>0) return Ackermann(number1-1,1);
// Рекурсивный случай   
 return Ackermann(number1-1,Ackermann(number1, number2-1));
}
Console.WriteLine($"Функция Аккермана от {m} и {n} = {Ackermann(m,n)}");

