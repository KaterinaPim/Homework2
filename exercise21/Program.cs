// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Введите Х1: ");
double x1 = double.Parse(Console. ReadLine());
Console.Write("Введите Y1: ");
double y1 = double.Parse(Console. ReadLine());
Console.Write("Введите Z1: ");
double z1 = double.Parse(Console. ReadLine());
Console.Write("Введите Х2: ");
double x2 = double.Parse(Console. ReadLine());
Console.Write("Введите Y2: ");
double y2 = double.Parse(Console. ReadLine());
Console.Write("Введите Z2: ");
double z2 = double.Parse(Console. ReadLine());


double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Длинна отрезка {d:f1}");


