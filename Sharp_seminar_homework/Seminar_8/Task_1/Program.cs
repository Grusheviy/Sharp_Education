// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write($"Введите {i} {j} элемент "); // i, j покажет какой элемент массива выводить
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
void ChangeLines(int[,] matrix, int m, int n)
{
int i, j, temp;
for (j = 0; j < n; j++)
{
    temp=matrix[0, j];
    matrix[0, j]=matrix[m - 1, j];
    matrix[m - 1, j] = temp;
}

Console.WriteLine("Your revers Array:");
for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
Console.Write(matrix[i,j] + " ");
    }
Console.WriteLine();
}
}

Console.WriteLine("write your  m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write your n:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

FillArrayWithRandom(matrix, m, n);
PrintArrayWithRandom(matrix, m, n);

ChangeLines(matrix, m, n);