// // Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int Number = new Random().Next(10, 100);
Console.WriteLine("your random number" + Number);
int digit1 = Number / 10; // Первая цифра
int digit2 = Number % 10; // Остаток от деления, последняя цифра
if(digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
    Console.WriteLine(digit2);
}