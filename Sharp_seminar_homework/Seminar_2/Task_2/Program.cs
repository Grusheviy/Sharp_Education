// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int Number = new Random().Next(101, 1000);
Console.WriteLine("your random number" + Number);
int digit1 = Number / 100; // Первая цифра
int digit3 = Number % 10; // Остаток от деления, последняя цифра
int result = digit1*10 + digit3;

Console.Write(digit1);
Console.Write(digit3);
Console.Write($"{digit1}{digit3}");
Console.Write(result);
// Console.Write(digit1*10 + digit3);  так правильно вывести первое и 3 число