Console.WriteLine("Введите число в десятичной системе");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int count=0;
while (number != 0)
{ 
    array[count] = number%2;
    count=count+1;
    number=number/2; 

}


for (int i = count-1; i>-1; i--)
{
    Console.Write(array[i]); 
}
Console.WriteLine();
