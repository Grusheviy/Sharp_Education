// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArrayWithRandom(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()* 10;
        array[i] = Math.Round(array[i], 1);
    }
}

double FindMin(double[] array)
{
double min = array[0];
    for(int i = 0; i < array.Length; i++) 
    {
        if (min > array[i]) 
        {
        min = array[i];
        array[i] = Math.Round(array[i], 1);
    }
    }
    return min;
}

double FindMax(double[] array)
{
double max = array[0];
    for(int i = 0; i < array.Length; i++) 
    {
        if (max < array[i]) 
        {
        max = array[i];
        }
    }
    return max;
}

Console.Write("Write your array length: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double [length];

FillArrayWithRandom(array);
Console.Write("You random array: ");
Console.WriteLine(string.Join(", ", array));
FindMin(array);
FindMin(array);
double diff = FindMax(array) - FindMin(array);
Console.WriteLine($"Your min array element is: {FindMin(array)}");
Console.WriteLine($"Your min array element is: {FindMax(array)}");
Console.WriteLine($"different betwen even numbers is : {Math.Round(diff, 1)}");
