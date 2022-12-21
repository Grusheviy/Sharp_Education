// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Vvedite chislo 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite chislo 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a % b;
if(c == 0)
{
Console.Write("kratno");
}
else
{
Console.Write("ne kratno " + c);
}