﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void PrintNumber(int M, int N)
{

    if(M == N)
    {
        return;
    }
    PrintNumber(M, (N - 1));
    Console.Write(N  + " ");
}

Console.WriteLine("Write your first number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your last number: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumber(M - 1, N);