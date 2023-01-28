// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void SelectionSort(int[,] matrix, int m, int n)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      for (int k = 0; k < n - 1; k++)
      {
        if (matrix[i,k] < matrix[i,k + 1])
        {
          int temp = matrix[i,k + 1];
          matrix[i,k + 1] = matrix[i,k];
          matrix[i,k] = temp;
        }
      }
    }
  }
}


Console.WriteLine("write your  m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write your n:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

FillArrayWithRandom(matrix, m, n);
PrintArrayWithRandom(matrix, m, n);
Console.WriteLine();
SelectionSort( matrix, m, n);
Console.WriteLine();
PrintArrayWithRandom(matrix, m, n);