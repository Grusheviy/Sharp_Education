// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Этот вариант тоже рабочий, но Вы сказали почитать про String и попробовать решить несколькими вариантами.

// int Number = new Random().Next(101, 1000);
// Console.WriteLine("your random number: " + Number);
// int digit2 = (Number / 10) % 10;

// Console.Write("your second number of you random number: " + digit2);

// Пробовал через функции TrmiStart и TrimEnd но ничего не вышло.
int Number = new Random().Next(101, 1000);
Console.WriteLine("your random number: " + Number);
string inttosttr = Number.ToString(); // Приводим рандомное значение ing к строковому значению string
string numn1 = inttosttr.Remove(0,1); // Удаляем из строкового значения один элемент под индексом 0
string numb3 = numn1.Remove(1,1); // Удаляем из строкового значения один элемент под индексом 1
Console.WriteLine("your second number of you random number: " + numb3);