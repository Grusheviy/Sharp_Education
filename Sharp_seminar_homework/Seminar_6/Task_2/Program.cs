// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// void TriangleCheck(int a, int b, int c)
// {
// if(x + y > z && y + z > x && x + z > y)
// {
//     Console.WriteLine("Triangle correct");
// }
// else
// {
//     Console.WriteLine("Triangle Not correct");
// }
// }


// Console.Write("Write length first side: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Write length second side: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Write length third side: ");
// int z = Convert.ToInt32(Console.ReadLine());
// TriangleCheck(x, y, z);


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное (РЕКУРСИЯ).
// // 45 -> 101101
// // 3  -> 11
// // 2  -> 10


void ConvertToBinary(int x)
{
string tmp = "";
 while (x > 0)
    {
    tmp += x & 1;
    x /= 2;
    }
 for (int i = tmp.Length - 1; i >= 0; i--)
{
    Console.Write(tmp[i]);
}
}

void ConvertToBinaryRecursing(int x)
{
if(x ==0) return; // если число равно нулю то мы прекращаем работу методу (в рекурсии это по типу Break)
    ConvertToBinaryRecursing(x / 2);
   Console.Write(x % 2);
}

Console.Write("Write your 10 system number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Your number in 2 system: ");
//ConvertToBinary(n);
ConvertToBinaryRecursing(n);


// string dvoic = Convert.ToString(x, 2);
// Console.WriteLine ($"Your number in 2 system:  {dvoic}");



// Вариант через массив
// void ReverseArray(int[] array)
// { 
//     int temp = 0;
//     for(int i = 0; i < array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int number2 = number;
// int length = 0;
// while(number > 0)
// {
//     number/=2;
//     length++;
// }

// int[] array = new int[length];

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = number2%2;
//     number2/=2;
// }
// Console.WriteLine(string.Join(", ", array));
// ReverseArray(array);
// Console.WriteLine(string.Join(", ", array));