// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Write first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Write third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.Write("Max number = " + max);