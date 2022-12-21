// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Write your number: ");
string numb = (Console.ReadLine());

if(numb.Length > 2)
{
Console.WriteLine("Your number" + numb);
Console.WriteLine("the third of your number: " + numb[2]);
}
else
{
    Console.Write("Your write wrong number");
}


