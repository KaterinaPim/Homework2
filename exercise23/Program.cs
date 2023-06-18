// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console. Clear();
Console.Write("Введите число N: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i=1;i<=a;i++)
{
    int b = i*i*i;
    Console.Write($"{b}, ");
}
