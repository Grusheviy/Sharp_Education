// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Немоного погуглил как выводить в новую строчку, чтобы не увеличивать кол-во строк кода

Console.Write("Write first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("First number = " + a + Environment.NewLine + "Second number = " + b + Environment.NewLine +  a + " > " + b);
}
else
{
    Console.Write("First number = " + a + Environment.NewLine + "Second number = " + b + Environment.NewLine +  b + " > " + a);
}
