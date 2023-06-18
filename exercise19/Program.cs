// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
int a, b, sum = 0, c;
Console.Write("Введите пятизначное число: ");
a = int.Parse(Console.ReadLine());
if(a > 9999 && a < 100000)
{
   for(c = a; a!= 0; a = a / 10)
{
   b = a % 10;
   sum = sum * 10 + b;
}
if(c == sum)
Console.Write($"{c} является палиндромом.");
else
Console.Write($"{c} не является палиндромом.");
} else
Console.Write("Введите пятизначное число! ");
