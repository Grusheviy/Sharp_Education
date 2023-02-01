// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int M, int N)
{
    if(N == M)
    {
        return 1;
    }
    return N + Sum(M, N -1);
}

Console.WriteLine("Write your M number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your N number: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = Sum(M, N);
Console.WriteLine(sum);