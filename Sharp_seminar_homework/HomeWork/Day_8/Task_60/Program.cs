﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArrayWithRandom(int[,,] matrix)
{
  int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
  int number;
  for(int i = 0; i < temp.GetLength(0); i++)
    {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if(i >= 1)
    {
        for(int j = 0; j < i; j++)
        {
            if(temp[i] == temp[j])
            {
            temp[i] = new Random().Next(10, 100);
            j = 0;
            number = temp[i];
            }
          number = temp[i];
        }
    }
    }
  int count = 0; 
  for(int x = 0; x < matrix.GetLength(0); x++)
  {
    for(int y = 0; y < matrix.GetLength(1); y++)
    {
      for(int z = 0; z < matrix.GetLength(2); z++)
      {
        matrix[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void PrintArrayWithRandom(int[,,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      for(int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write( $"{matrix[i,j,k]}({k},{i},{j}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.WriteLine($"Write matrix size X x Y x Z:");
Console.WriteLine("Write your  X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your  Y:");
int y = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Write your  Z:");
int z = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine();

int[,,] matrix = new int[x, y, z];

FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);
