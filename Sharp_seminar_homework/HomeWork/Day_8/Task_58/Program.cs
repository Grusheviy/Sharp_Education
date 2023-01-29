// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("write your  m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write your n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write your b:");
int b = Convert.ToInt32(Console.ReadLine());


int[,] firstMatrix = new int[m,n];
int[,] secondMatrix = new int[n,b];
int[,] resultMatrix = new int[m,b];

void FillArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
        
    }
}
void PrintArrayWithRandom(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void ArrayMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


FillArrayWithRandom(firstMatrix);
FillArrayWithRandom(secondMatrix);
PrintArrayWithRandom(firstMatrix);
Console.WriteLine();
PrintArrayWithRandom(secondMatrix);
ArrayMultiplication(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Result of multiplication First and Second matrix:");
PrintArrayWithRandom(resultMatrix);
