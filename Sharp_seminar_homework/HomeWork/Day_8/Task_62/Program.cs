// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.WriteLine("write your  m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write your n:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while(temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i,j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
        else
        i--;
    }
}
void PrintArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(matrix[i,j] <= 9)
            {
            Console.Write($"0{matrix[i,j]} ");
            }
            else
            {
            Console.Write(matrix[i,j] + " ");
            }
        }
        Console.WriteLine();
    }
}

FillArrayWithRandom(matrix, m, n);
PrintArrayWithRandom(matrix, m, n);
Console.WriteLine();