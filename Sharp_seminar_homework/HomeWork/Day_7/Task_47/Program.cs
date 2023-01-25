// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArrayWithRandom(double[,] array, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            array[i,j] = new Random().NextDouble()* 10;
        }
        
    }
}
void PrintArrayWithRandom(double[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write($"[ {Math.Round(array[i,j], 1)} ] ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("write m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write n:");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double[m,n];

FillArrayWithRandom(array, m, n);
PrintArrayWithRandom(array, m, n);