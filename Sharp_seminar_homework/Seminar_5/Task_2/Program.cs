// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 



// int[] FillArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9,10);
// }
// return array;
// }


// int[] array = new int [5];
// array = FillArray(array);
// Console.Write("You random array: ");
// Console.Write(string.Join(", ", array));    


// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] < 0)
//     {
//          array[i]*= (-1); 
//     }
//     else
//     {
//         array[i]*= (-1); 
//     }
// }

// Console.WriteLine();
// Console.Write(string.Join(", ", array));



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
}
return array;
}

void ElementFinder(int[] array, int N)
{

Console.Write("Write you number: ");
int N = Convert.ToInt32(Console.ReadLine());
bool isOk = false;
for(int i = 0; i < array.Length; i++)
{
    if(N == array[i])
    {
        isOk = true;
        break;
    }
}
if(isOk)
{
    Console.Write("Element here");
}
else
{
    Console.Write("Element not here");
}
}

int[] array = new int [5];
array = FillArray(array);
Console.Write("You random array: ");
Console.WriteLine(string.Join(", ", array)); //string.Join метод для вывода данных через разделитель

ElementFinder(array);


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

bool Checked(int[] array, int number)
{
    bool isOk = false;
    for(int i = 0; i < array.Length; i++)
    {
    if(number == array[i])
    {
        isOk = true;
        break;
    }
    }
    return isOk;
}

int[] array = new int [5];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isOk = Checked(array, number);

if(isOk)
{
    Console.Write("Элемент найден");
}
else 
{
    Console.Write("Элемент не найден");
}
