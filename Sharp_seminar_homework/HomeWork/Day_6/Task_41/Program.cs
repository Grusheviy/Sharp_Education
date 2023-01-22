// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Write your numbers: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CountPositiv(int[] array)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0)
    {
        count++;
    }
    }
Console.WriteLine($"Number of elements > 0: {count}");
}

Console.Write("Write your array length: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
Console.Write("You array: ");
Console.WriteLine(string.Join(", ", array));
FillArray(array);
CountPositiv(array);


