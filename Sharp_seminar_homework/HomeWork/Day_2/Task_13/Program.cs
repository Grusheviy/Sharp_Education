// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Write your three-digit number: ");
string numb = (Console.ReadLine());

if(numb.Length == 3)
{
    int Number = Convert.ToInt32(numb);
    Console.WriteLine("your random number" + Number);
    int digit = Number % 10; // Остаток от деления, последняя цифра

Console.WriteLine("the third of your random number: " + digit);
}
else
{
    Console.Write("Your write not three-digit number: ");
}
