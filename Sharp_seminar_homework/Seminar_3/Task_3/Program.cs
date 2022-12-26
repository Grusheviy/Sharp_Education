// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.Write("x1=");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("x2=");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("y1=");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("y2=");
int By = Convert.ToInt32(Console.ReadLine());

double range = Math.Round(Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2)), 2);
Console.WriteLine("Range :" + range);


// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// // от 1 до N.

// // 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4

// Console.Write("Write your number: ");
// int numb = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= numb; i++)
// {
// Console.Write(Math.Pow(i, 2) + " ");
// }

