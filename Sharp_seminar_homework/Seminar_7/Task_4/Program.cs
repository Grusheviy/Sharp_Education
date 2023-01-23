// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write($"Write {i} {j} element ");
            matrix[i,j] = Convert.ToInt32(Console.ReadLine()); 
        }
        
    }
}
void PrintArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int SumArray(int[,] matrix, int m, int n)
{
int sum = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       if (i == j) 
       {
       sum += matrix[i,j];
       }
    }
}
return sum;
}
Console.WriteLine("write m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];

FillArrayWithRandom(matrix, m, n);
PrintArrayWithRandom(matrix, m, n);
SumArray(matrix, m, n);
Console.WriteLine($"Sum main diagonal:  {SumArray(matrix, m, n)}");
