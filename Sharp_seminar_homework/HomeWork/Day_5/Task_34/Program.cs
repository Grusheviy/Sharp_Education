// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

Console.Write("Write your array length: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];

FillArrayWithRandom(array);

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count += 1;
    }
}

Console.Write("You random array: ");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Number of even numbers {count}");