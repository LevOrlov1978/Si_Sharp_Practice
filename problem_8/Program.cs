Console.WriteLine("Введите целое положительное число");
string a = Console.ReadLine();
int aa = int.Parse(a);
int count = 1;
while (count<aa+1)
{if ((count %2) == 0) Console.WriteLine(count);
count=count+1;}
