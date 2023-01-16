// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] FillArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,123);
// }
// return array;
// }

// int[] array = new int [5];
// array = FillArray(array);
// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] >= 10 && array[i] <= 99)
//     {
//         count += 1;
//     }
// }

// Console.Write("You random array: ");
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine();
// Console.WriteLine($"Sum {count}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
Console.Write("Ввдите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));

int newLength = array.Length/2 + array.Length%2;
int[] newArray = new int [newLength];
for(int i = 0; i < array.Length/2; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}
if(array.Length % 2 > 0)
{
    newArray[newArray.Length - 1] = array[array.Length/2];
}
Console.Write("Ваш получившийся массив: ");
Console.WriteLine(string.Join(", ", newArray));
