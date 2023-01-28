// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
           matrix[i,j] = new Random().Next(0,10);
            
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
int SumElementsInLine(int[,] matrix, int i)
{
  int LineSum = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(0); j++)
  {
    LineSum += matrix[i,j];
  }
  return LineSum;
}
void MinSumLine(int[,] matrix)
{
int MinSumInLine = 0;
int sumInLine = SumElementsInLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumElementsInLine(matrix, i);
  if (sumInLine > temp)
  {
    sumInLine = temp;
    MinSumInLine = i;
  }
}
Console.WriteLine($"String with minimum sum in line - {MinSumInLine + 1}: {sumInLine} elements ");
}

Console.WriteLine("write your  m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write your n:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

FillArrayWithRandom(matrix, m, n);
PrintArrayWithRandom(matrix, m, n);
Console.WriteLine();
MinSumLine(matrix);