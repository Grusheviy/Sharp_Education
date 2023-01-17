// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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
    if(array[i] % 2 != 0)
    {
        count += array[i];
    }
}

Console.Write("You random array: ");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Sum of noteven numbers {count}");