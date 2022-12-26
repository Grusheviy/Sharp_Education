// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Ax=");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Ay=");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Az=");
int Az = Convert.ToInt32(Console.ReadLine());
Console.Write("Bx=");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("By=");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Bz=");
int Bz = Convert.ToInt32(Console.ReadLine());

double range = Math.Round(Math.Sqrt(Math.Pow(Bx-Ax, 2)
                                  + Math.Pow(By-Ay, 2) 
                                  + Math.Pow(Bz-Az, 2)), 2);
                                  
Console.WriteLine("Range :" + range);