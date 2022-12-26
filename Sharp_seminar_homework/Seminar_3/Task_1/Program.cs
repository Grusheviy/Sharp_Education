// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.Write("Vvedite X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.Write("1 chetvert");
}
else if(x < 0 && y > 0)
{
    Console.Write("2 chetvert");
}
else if(x < 0 && y < 0)
{
    Console.Write("3 chetvert");
}
else
{
     Console.Write("4 chetvert");
}