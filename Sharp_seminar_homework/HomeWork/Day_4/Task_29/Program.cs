// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,99);
}
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
       Console.Write($"[ "+(array[i])+ " ]");
    }
    Console.WriteLine();
}


Console.WriteLine("Write you array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

FillArray(array);
PrintArray(array); 
