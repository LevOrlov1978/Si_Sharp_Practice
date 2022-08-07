Console.WriteLine("Введите два целых числа");
string a = Console.ReadLine();
string b = Console.ReadLine();
int aa = int.Parse(a);
int bb = int.Parse(b);
if (aa == bb) 
Console.WriteLine("Числа равны");
else
{
    if (aa > bb)
    {Console.Write("Max=");
    Console.WriteLine(aa);}
    else {
    Console.Write("Max=");
    Console.WriteLine(bb);
    }
}