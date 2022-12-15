// Console.Write("write number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a >= 100 && a < 1000)
// {
// Console.Write("last number:");
// Console.Write (a % 10);
// }
// else 
// {
//     Console.Write("you write not 3 number number");
// }

//Другой вариант
Console.WriteLine("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
int last_numb = N % 10;
Console.Write(last_numb);
