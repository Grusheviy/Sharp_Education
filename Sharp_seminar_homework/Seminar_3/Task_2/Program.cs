


// Console.Write("Vvedite nomer chetverti 1-4: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if(x == 1)
// {
//     Console.Write("x > 0 and y > 0");
// }
// else if(x == 2)
// {
//     Console.Write("x < 0 and y > 0");
// }
// else if(x == 3)
// {
//     Console.Write("x < 0 and y < 0");
// }
// else if (x == 4)
// {
//      Console.Write("x > 0 and y < 0");
// }
// else
// {
//     Console.Write("you write wrong chetvert number");
// }


string[] quarters = {"x > 0, y > 0", 
                    "x < 0, y > 0", 
                    "x < 0, y < 0", 
                    "x > 0, y < 0"};

Console.Write("Введите цифру плоскости координат ");
int quater = Convert.ToInt32(Console.ReadLine());
if(quater >= 1 && quater <= 4)
{
    Console.WriteLine(quarters[quater - 1]);
}
else
{
    Console.WriteLine("Неверный ввод" );
}
