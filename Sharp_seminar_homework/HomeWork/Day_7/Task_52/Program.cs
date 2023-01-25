// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArrayWithRandom(int[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            // array[i,j] = new Random().Next(0, 10);
            array[i,j] = Convert.ToInt32(Console.ReadLine());
        }
        
    }
}
void PrintArrayWithRandom(int[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void MathAverage(int[,] array, int m, int n)
{
    for (int i = 0; i < n; i++)
    {
    double MathAverage = 0;
        {
        for (int j = 0; j < m; j++)
        {
        MathAverage += array[j,i];
        }
    MathAverage = MathAverage / m;
Console.WriteLine(Math.Round(MathAverage, 1));
// Не совсем разобрался, почему Math.Round округляет по итогу к большему числу,
// но если не убирать знаки после запятой то считает правильно
        }
    }
}

Console.WriteLine("write m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write n:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

FillArrayWithRandom(matrix, m, n);
PrintArrayWithRandom(matrix, m, n);
MathAverage(matrix, m, n);
