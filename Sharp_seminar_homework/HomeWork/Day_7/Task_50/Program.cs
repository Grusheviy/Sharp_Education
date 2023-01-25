// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

void FillArrayWithRandom(int[,] array, int row, int column)
{
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            // Console.Write($"Write {i} {j} element ");
            array[i,j] = new Random().Next(0, 10);
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
string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}

Console.WriteLine("write m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("write n:");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[m,n];

FillArrayWithRandom(array, m, n);
PrintArrayWithRandom(array, m, n);

Console.WriteLine("Write you array indexes: ");
string InputIndexes = (Console.ReadLine());
string OutputIndexes = RemovingSpaces(InputIndexes);

int a = Convert.ToInt32(OutputIndexes[0].ToString());
int b = Convert.ToInt32(OutputIndexes[2].ToString());
if(a > m || b > n)
{
    Console.WriteLine("There is no such number in your array");
}
else
{
    object c = array.GetValue(a,b);
    Console.WriteLine($"There is your number in array: {c}");
}
