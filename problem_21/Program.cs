﻿Console.WriteLine("Введите координаты двух точек в пространстве");

Console.WriteLine("Введите X1");
//string X1 = Console.ReadLine();
int X1 = int.Parse(Console.ReadLine());
//Console.WriteLine(X1);
Console.WriteLine("Введите Y1");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1");
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X2");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2");
int Y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2");
int Z2 = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
Console.WriteLine($"расстояние между точками {Math.Round(distance,2)}");