// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1  4 49 2
// 5  9 2  3
// 64 4 4  4

void FillArrayWithRandom(int[,] matrix, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            // Console.Write($"Write {i} {j} element ");
            matrix[i,j] = new Random().Next(0, 10);
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i,j] *= matrix[i,j];
            }
            
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

Console.WriteLine("write m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write n:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

FillArrayWithRandom(matrix, m, n);
PrintArrayWithRandom(matrix, m, n);